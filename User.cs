using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Benjamin Wearn
 * User Class for Activity 4
 */

namespace Activity4Server
{
    class User
    {
        private string UserName;
        private string HashedPass;

        #region Constructor
        public User(string UserName, string HashedPass)
        {
            this.HashedPass = HashedPass;
            this.UserName = UserName;
        }
        #endregion

        #region AccessorMethods
        public void SetUserName(string UserName)
        {
            this.UserName = UserName;
        }
        
        public string GetUserName()
        {
            return UserName;
        }

        public void SetHashedPass(string HashedPass)
        {
            this.HashedPass = HashedPass;
        }

        public string GetHashedPass()
        {
            return HashedPass;
        }
        #endregion

    }
}
