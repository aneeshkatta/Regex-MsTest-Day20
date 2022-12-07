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
        public static string emailregex = "^[0-9a-z]{1,}([.+-_]*)(([0-9a-z]{1,})*)(@)(gmail|bl)(.)(com|co)([.]*)([in]*)$";
        public static bool RegexValidate(string inputemail)
        {
            return Regex.IsMatch(inputemail, emailregex);
        }
    }
}
