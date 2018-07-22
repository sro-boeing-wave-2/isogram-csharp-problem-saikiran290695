using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Isogram
{
    public class IsogramClass
    {
        public static bool IsogramMethod(string text)
        {
            Regex reg = new Regex("[ -]");
            string modText = reg.Replace(text, "");
            var unique = modText.ToCharArray().Distinct();
            bool response = (unique.Count() == modText.Length) ? true : false;            
            return response;
        }
    }
}
