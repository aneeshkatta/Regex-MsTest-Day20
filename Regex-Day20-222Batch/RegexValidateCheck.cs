using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Day20_222Batch
{
    public class RegexValidateCheck
    {
        public static string PasswordRegex = "(?=.*[A-Z])(?=.*[0-9]).{8}";
        public static bool RegexValidate(string Password)
        {
            return Regex.IsMatch(Password, PasswordRegex);
        }
    }
}
