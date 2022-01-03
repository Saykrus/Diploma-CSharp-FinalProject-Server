using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using wyUpdate;

/* Benjamin Wearn - P467480
 * 
 * 
 * 
 * 
 */


namespace Activity4Server
{
    public partial class JMCServer : Form
    {
        private PipeServer pipeServer = new PipeServer();
        private ASCIIEncoding encoder = new ASCIIEncoding();
        private List<User> UserDB = new List<User>();

        public JMCServer()
        {
            //Init Form
            InitializeComponent();

            //Add "admin" user
            User root = new User("root", PasswordHash("admin"));
            UserDB.Add(root);
            UpdateUsers();

            //Pipe Methods
            pipeServer.MessageReceived += pipeServer_MessageReceived;
            pipeServer.ClientDisconnected += pipeServer_ClientDisconnected;
        }

        #region ClientConnectionsAndDisconnections
        void pipeServer_ClientDisconnected()
        {
            Invoke(new PipeServer.ClientDisconnectedHandler(ClientDisconnected));
        }

        void ClientDisconnected()
        {
            UpdateClientsConnected();
        }
        #endregion

        #region MessagesToAndFrom
        void pipeServer_MessageReceived(byte[] message)
        {
            Invoke(new PipeServer.MessageReceivedHandler(DisplayMessageReceived),
                new object[] { message });
        }

        void DisplayMessageReceived(byte[] message)
        {
            UpdateClientsConnected();
            
            string str = encoder.GetString(message, 0, message.Length);

            //recieving login attempt
            OutputStream("Login Attempt");
            //split into username and password
            string[] splitString = str.Split(':');
            //Validate
            bool remoteLoginAttempt = ValidatePassword(splitString[0], splitString[1]);
            if (remoteLoginAttempt == true)
            {
                OutputStream("Login Attempt successful");
                //SEND MESSAGE TO CLIENT
                byte[] messageBuffer = encoder.GetBytes("Login Succeeded");
                pipeServer.SendMessage(messageBuffer);
            }
            else
            {
                OutputStream("Login Attempt failed");
                byte[] messageBuffer = encoder.GetBytes("Login Failed");
                pipeServer.SendMessage(messageBuffer);
            }


        }
        #endregion

        #region ButtonEvents
        private void ButtonStartServer_Click(object sender, EventArgs e)
        {
            //start the pipe server if it's not already running
            if (!pipeServer.Running)
            {
                pipeServer.Start(TextboxPipeName.Text);
                ButtonStartServer.Enabled = false;
            }
            else
                MessageBox.Show("Server already running.");
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            string newUserName = TextboxNewUserName.Text.ToLower();
            User newUser = new User(newUserName, PasswordHash(TextboxNewUserPass.Text));

            UserDB.Add(newUser);

            //Notify Client of new user credentials
            byte[] messageBuffer = encoder.GetBytes("New User created. Username: " + newUserName + " Password: " + TextboxNewUserPass.Text);
            pipeServer.SendMessage(messageBuffer);

            TextboxNewUserName.Clear();
            TextboxNewUserPass.Clear();
            UpdateUsers();

        }
        #endregion

        #region UpdateFields
        void UpdateUsers()
        {
            ListboxUsers.Items.Clear();
            for (int i = 0; i < UserDB.Count; i++)
            {
                ListboxUsers.Items.Add(UserDB.ElementAt(i).GetUserName() + " : " + UserDB.ElementAt(i).GetHashedPass());
            }
        }

        private void UpdateClientsConnected()
        {
            TextboxClientsConnected.Text = pipeServer.TotalConnectedClients.ToString();
        }

        private void OutputStream(String x)
        {
            ListboxOutput.Items.Add(x);
        }
        #endregion

        #region PasswordHashingAndValidation
        private string PasswordHash(string input)
        {
            //Create the salt value with a cryptographic PRNG
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            //Create the Rfc2898DeriveBytes and get the hash value
            var pbkdf2 = new Rfc2898DeriveBytes(input, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            //Combine the salt and password bytes for later use
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            //Turn the combined salt+hash into a string for storage
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }

        private bool ValidatePassword(string UserName, string input)
        {
            /* Fetch the stored value */
            try
            {
                User user = UserDB.Find(x => x.GetUserName().Contains(UserName));
                if (user == null)
                {
                    return false;
                }
                else
                {
                    string savedPasswordHash = user.GetHashedPass();
                    /* Extract the bytes */
                    byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                    /* Get the salt */
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);
                    /* Compute the hash on the password the user entered */
                    var pbkdf2 = new Rfc2898DeriveBytes(input, salt, 100000);
                    byte[] hash = pbkdf2.GetBytes(20);
                    /* Compare the results */
                    for (int i = 0; i < 20; i++)
                    {
                        if (hashBytes[i + 16] != hash[i])
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                MessageBox.Show("Password validation failed, got to unexpected area");
                return false;
            }
            catch
            {
                ListboxOutput.Items.Add("User not found");
                return false;
            }
        }

        private void ButtonValidateUser_Click(object sender, EventArgs e)
        {
            TextboxValidator.Clear();
            string username = TextboxValidateName.Text;
            User user = UserDB.Find(x => x.GetUserName().Contains(username));
            if (user == null)
            {
                TextboxValidator.Text = "Validation failed - Doesn't exist";
            }
            else
            {
                bool wasvalidated = ValidatePassword(user.GetUserName(), TextboxValidatePass.Text);
                if (wasvalidated == true)
                {
                    TextboxValidator.Text = "User Validated";
                }
                else
                {
                    TextboxValidator.Text = "Validation failed - Wrong password";
                }
                TextboxValidateName.Clear();
                TextboxValidatePass.Clear();
            }
        }
        #endregion
    }
}
