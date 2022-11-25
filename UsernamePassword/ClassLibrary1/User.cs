using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        public User(string username)
        {
            this._userName = username;
        }

        private string _userName;
        private string _password;
        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public bool HasDigit(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasLower(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
