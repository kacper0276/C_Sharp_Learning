using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.DelegatyAnonimoweFunkcjeLambda
{
    public class DelegatyAnonimoweFunkcjeLambda
    {
        private static string text = "abc";

        public static string AddText(string i)
        {
            text += i;
            return text;
        }

        public static string GetText()
        {
            return text;
        }
    }
}
