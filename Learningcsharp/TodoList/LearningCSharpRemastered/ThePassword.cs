using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpRemastered
{
    public class ThePassword
    {
        public string password { get; set; }
        public bool isUppercase = false;
        public bool isLowercase = false;
        public bool isNumber = false;

        public ThePassword(string _password)
        {
            password = _password;
        }

        public bool CheckPasswordLength()
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        public bool CheckPassword()
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c)){ isUppercase = true; }
                if (char.IsLower(c)) { isLowercase = true; }
                if (char.IsDigit(c)) { isNumber = true; }
                if (c == 'T' || c == '&') { isUppercase = false; }
            }
            return isUppercase && isLowercase && isNumber;
        }
    }
}
