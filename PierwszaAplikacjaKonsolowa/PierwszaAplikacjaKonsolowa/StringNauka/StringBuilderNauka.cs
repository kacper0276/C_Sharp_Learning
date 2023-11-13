using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa.StringNauka
{
    public class StringBuilderNauka
    {
        public StringBuilderNauka()
        {

            string appendCharacter = "text";

            int[] samples = new int[2] { 100000, 1000000 };

            foreach (int sample in samples)
            {
                var startTime = DateTime.UtcNow;
                //    testAppendString(sample, "", appendCharacter);
                testAppdendStringBuilder(sample, new StringBuilder(""), appendCharacter);
                var endTime = DateTime.UtcNow;
                Console.WriteLine($"Time: {endTime.Subtract(startTime)}");
            }

            static void testAppendString(int n, string str, string appendCharacter)
            {
                for (int i = 1; i <= n; i++)
                {
                    str += appendCharacter;
                }
            }

            static void testAppdendStringBuilder(int n, StringBuilder str, string appendCharacter)
            {
                for (int i = 1; i <= n; i++)
                {
                    str.Append(appendCharacter);
                }
            }
        }
    }
}
