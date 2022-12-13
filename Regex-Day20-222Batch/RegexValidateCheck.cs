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
        public static string mobileNoRegex = "^[0-9][0-9][ -][1-9][0-9]{9}";
        public static bool RegexValidate(string inputMobile)
        {
            return Regex.IsMatch(inputMobile, mobileNoRegex);
        }
    }
}
