using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercicio_1
{
    static class IOUtils
    {
        public static T SecureInput<T>(string NullCaseConsoleLog = "", string FailedConversionConsoleLog = "") where T : IParsable<T>
        {
            while (true)
            {
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) CWIfString(NullCaseConsoleLog);
                else if (T.TryParse(input, CultureInfo.InvariantCulture, out T? output)) return output;
                else CWIfString(FailedConversionConsoleLog);
            }
        }

        public static string NonNullInput(string NullCaseConsoleLog = "")
        {
            while (true)
            {
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) CWIfString(NullCaseConsoleLog);
                else return input;
            }
        }

        public static void CWIfString(string str)
        {
            if (!string.IsNullOrWhiteSpace(str)) Console.WriteLine(str);
        }
    }
}
