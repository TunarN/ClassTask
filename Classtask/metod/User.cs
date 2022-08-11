using System;
using System.Collections.Generic;
using System.Text;

namespace Classtask.metod
{
    class User
    {
        private string _username;
        private string _password;
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    _username = value;
                }
            }


        }
        public string Password {
            get
            {
                return _password;
            }
            set
            {
                if (HasDigit(value)&&HasUpper(value)&&HasLower(value))
                {
                    _password = value;
                }
            }
        }
        private bool HasDigit (string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]>47 && word[i]<58)
                {
                    return true;
                }
                
            }
            return false;
        }
        private bool HasUpper(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]>64 && word[i]<91)
                {
                    return true;
                }
               
            }
            return false;

        }
        private bool HasLower(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]>96 && word[i]<123)
                {
                    return true;
                }
                
            }
            return false;
        }

    }
}

