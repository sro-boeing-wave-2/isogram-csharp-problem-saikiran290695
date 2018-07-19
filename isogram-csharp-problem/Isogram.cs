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
            bool response = false;
            Regex reg = new Regex("[ -]");
            var unique = reg.Replace(text, "").ToCharArray().Distinct();
            if (unique.Count() == reg.Replace(text, "").Length)
            {
                response = true;
            }
            return response;
        }
    }
}



