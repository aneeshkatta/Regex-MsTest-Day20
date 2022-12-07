using Regex_Day20_222Batch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Day20_Mstest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputMobile = "91-9876543210";
            bool result = RegexValidateCheck.RegexValidate(inputMobile);
            Console.WriteLine("\n{0}", result);
            Console.ReadKey();
        }
    }
}
