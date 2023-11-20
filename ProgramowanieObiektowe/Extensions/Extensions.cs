using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Extensions
{
    static class Extensions // statyczna klasa
    {
        // każda metoda extension zawsze będzie statyczna
        public static string AddExtraLine(this string text)
        {
            text += "\n-------------------------\n";
            return text;
        }

        public static string AddExtraLineWithText(this string str, string text)
        {
            str += $"\n-------------{text}------------\n";
            return str;
        }
    }
}
