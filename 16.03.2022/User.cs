using System;
using System.Collections.Generic;
using System.Text;

namespace _16._03._2022
{
    internal class User
    {
        private string _username;
        private string _password;
        public User(string username)
        {
            UserName = username;
        }
        public string UserName
        {
            get
            {
                return this._username;
            }
            set
            {
                if (value.Length > 5 && value.Length < 26 && !string.IsNullOrWhiteSpace(value))
                    this._username = value;
            }
        }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (value.Length > 7 && value.Length < 26 && HasDigit(value) && HasLower(value) && HasUpper(value) && !string.IsNullOrWhiteSpace(value))
                    this._password = value;
            }
        }
        static bool HasDigit(string pasword)
        {
            for (int i = 0; i < pasword.Length; i++)
            {
                if (char.IsDigit(pasword[i]))
                    return true;
            }

            return false;
        }

        static bool HasLower(string pasword)
        {
            for (int i = 0; i < pasword.Length; i++)
            {
                if (char.IsLower(pasword[i]))
                    return true;
            }

            return false;
        }

        static bool HasUpper(string pasword)
        {
            for (int i = 0; i < pasword.Length; i++)
            {
                if (char.IsUpper(pasword[i]))
                    return true;
            }

            return false;
        }
    }

}
