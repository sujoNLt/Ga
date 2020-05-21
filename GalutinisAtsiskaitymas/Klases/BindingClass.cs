using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace GalutinisAtsiskaitymas
{
    public class BindingClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyChange(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private string _userName;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value != _userName)
                {
                    _userName = value;
                    if (_userName.ToCharArray().Length < 5)
                    {
                        ForeUser = Color.Red;
                    }
                    else
                    {
                        ForeUser = Color.Black;
                    }
                    NotifyChange("UserName");
                }
            }
        }

        private Color _ForeUser;

        public Color ForeUser
        {
            get
            {
                return _ForeUser;
            }
            set
            {
                if (value != _ForeUser)
                {
                    _ForeUser = value;
                    NotifyChange("ForeUserName");
                }
            }
        }

        private string _Password;

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                if (value != _Password)
                {
                    _Password = value;
                    if (_Password.ToCharArray().Length < 8)
                    {
                        ForePassword = Color.Red;
                    }
                    else
                    {
                        ForePassword = Color.Black;
                    }
                    NotifyChange("Password");
                }
            }
        }

        private Color _ForePassword;

        public Color ForePassword
        {
            get
            {
                return _ForePassword;
            }
            set
            {
                if (value != _ForePassword)
                {
                    _ForePassword = value;
                    NotifyChange("ForePassword");
                }
            }
        }

        private string _Password2;

        public string Password2
        {
            get
            {
                return _Password2;
            }
            set
            {
                if (value != _Password2)
                {
                    _Password2 = value;
                    if (_Password2.ToCharArray().Length < 8)
                    {
                        ForePassword2 = Color.Red;
                    }
                    else
                    {
                        ForePassword2 = Color.Black;
                    }
                    NotifyChange("Password2");
                }
            }
        }

        private Color _ForePassword2;

        public Color ForePassword2
        {
            get
            {
                return _ForePassword2;
            }
            set
            {
                if (value != _ForePassword2)
                {
                    _ForePassword2 = value;
                    NotifyChange("ForePassword2");
                }
            }
        }

        private string _Email;

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if (value != _Email)
                {
                    _Email = value;
                    if (_Email.Contains("@") && _Email.Contains("."))
                    {
                        ForeEmail = Color.Black;
                    }
                    else
                    {
                        ForeEmail = Color.Red;
                    }
                    NotifyChange("Email");
                }
            }
        }

        private Color _ForeEmail;

        public Color ForeEmail
        {
            get
            {
                return _ForeEmail;
            }
            set
            {
                if (value != _ForeEmail)
                {
                    _ForeEmail = value;
                    NotifyChange("ForeEmail");
                }
            }
        }
    }
}
