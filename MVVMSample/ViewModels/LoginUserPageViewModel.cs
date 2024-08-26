using AndroidX.Core.Util;
using MVVMSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMSample.ViewModels
{
    internal class LoginUserPageViewModel : ViewModelBase
    {

        #region properties
        private string username;
        private string password;//password
        private string errorMessageUsr;//הודעת שגיאה
        private string errorMessagePss;//הודעת שגיאה
        #endregion

        #region Properties

        // user name
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (username != value)
                {

                    username = value;
                    OnPropertyChanged(nameof(Username));
                    HandleError();//בדוק האם יש השם תקין
                }

            }
        }


        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password != value)
                {

                    password = value;
                    OnPropertyChanged(nameof(Password));
                    HandleError();//בדוק האם יש השם תקין
                }

            }
        }
        //is user name valid
        public bool HasErrorUsr
        {
            get
            {

                return !string.IsNullOrEmpty(ErrorMessageUsr);
                //return string.IsNullOrEmpty(Username) || !ValidUserName() ||
                // string.IsNullOrEmpty(Password) || !ValidPassword();
            }

        }
        public bool HasErrorPss
        {
            get
            {

                return !string.IsNullOrEmpty(ErrorMessagePss);
                //return string.IsNullOrEmpty(Username) || !ValidUserName() ||
                // string.IsNullOrEmpty(Password) || !ValidPassword();
            }

        }

        public bool NoErrors
        {
            get
            {
                return !HasErrorPss && !HasErrorPss;
            }
        }
        //הודעת שגיאה
        public string ErrorMessageUsr
        {
            get
            {
                return errorMessageUsr;
            }
            set
            {
                if (errorMessageUsr != value)
                {
                    errorMessageUsr = value;
                    OnPropertyChanged(nameof(ErrorMessageUsr));
                }
            }
        }

        public string ErrorMessagePss
        {
            get
            {
                return errorMessagePss;
            }
            set
            {
                if (errorMessagePss != value)
                {
                    errorMessagePss = value;
                    OnPropertyChanged(nameof(ErrorMessagePss));
                }
            }
        }


        #endregion

        #region Commands
        //PROPERTY to be Bound to the Button Command
        public ICommand LoginUserCommand
        {
            get; private set;
        }
        #endregion

        #region Constructor
        public LoginUserPageViewModel()
        {
            //connect the property with the action method to perform
            //Command([method Name]) --> for void methods
            //Command<type>([method name]--> for methods that has parameters

            LoginUserCommand = new Command<string>(LoginUser);

        }

        #endregion

        #region Operations 
        //לוגיקת שגיאה
        private void HandleError()
        {
            
            
            if (!ValidUserName())
            {
                ErrorMessageUsr = "Username not valid:" + Username;
            }
            else
            {
                ErrorMessageUsr = string.Empty;
            }
            if (!ValidPassword())
            {
                ErrorMessagePss = "Password not valid:" + Password;
            }
            else
            { 
                ErrorMessagePss = string.Empty; 
            }
            OnPropertyChanged(nameof(HasErrorPss));
            OnPropertyChanged(nameof(HasErrorUsr));
            OnPropertyChanged(nameof(NoErrors));

        }
        #endregion


        #region Implement Valid Checks
        //1. user name no spaces no digits
        private bool ValidUserName()
        {
            if (string.IsNullOrEmpty(Username)) return false;
            Regex reg = new Regex(@"[ \d]"); ;
            return !reg.IsMatch(Username);
        }


        private bool ValidPassword()
        {
            if (string.IsNullOrEmpty(Password)) return false;

            char[] chars = Password.ToCharArray();
            int dgcnt = 0, ltcnt = 0;
            foreach (char c in chars)
            {
                if (c >= '0' && c <= '9') dgcnt++;
                if (c >= 'A' && c <= 'Z') ltcnt++;
            }
            if (dgcnt == 0 || ltcnt == 0)
            {
                return false;
            }

            return true;
            //Regex reg = new Regex(@"(?=[A-Z](?=.\d).+)");
            //return reg.IsMatch(Password);
        }
        #endregion

        //Checking user and name
        private void LoginUser(string name)
        {
           //veridy in db ...

        }
    }
}
