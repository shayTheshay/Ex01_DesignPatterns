using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class UserSession
    {
        private readonly LoginResult r_LoginResult;
        public LoginResult LoginResult
        {
            get { return r_LoginResult; }
        }

        public User User
        {
            get { return r_LoginResult.LoggedInUser; }
        }

        public UserSession(LoginResult i_LoginResult)
        {
            r_LoginResult = i_LoginResult;
        }
    }

    public class CopyOfUserSession
    {
        public User User { get { return r_LoginResult.LoggedInUser; } }
        private readonly LoginResult r_LoginResult;
        public LoginResult LoginResult { get { return r_LoginResult; } }

        public CopyOfUserSession(LoginResult i_LoginResult)
        {
            r_LoginResult = i_LoginResult;
        }

    }
}
