using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Extensions
{
    public class ExtensionsUzycie
    {
        public ExtensionsUzycie()
        {
            string text = "TestText";
            text = text.AddExtraLine();
            Console.WriteLine(text);

            string textExtra = "TestText";
            textExtra = textExtra.AddExtraLineWithText("NAPIS AUU");
            Console.WriteLine(textExtra);
        }
    }
}
