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
        public static string LastNameRegex = "^[A-Z]{1}[a-z]{2,}$";
        public static bool RegexValidate(string inputLastName)
        {
            return Regex.IsMatch(inputLastName, LastNameRegex);
        }
    }
}
