using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.DelegatyAnonimoweFunkcjeLambda
{
    delegate string ChangeText(string text);

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

        // Gotowe delegaty func, action
        // Action - służy do zapisania metody która nic nie zwraca
        // Func - działa jak zwykła delegata

        public static void Main(string[] args)
        {
            ChangeText changeText = new ChangeText(AddText);
            changeText(" abc123");
            Console.WriteLine("Wartość tekstu: {0}", GetText());
            changeText += changeText; // Dwa razy wykona tą samą metodę
            changeText("dwa");
            AddText(" test 123");
            Console.WriteLine("Wartość tekstu: {0}", GetText());
            Func<string, string> func = delegate (string t) { text += t; return text; };  // <co przyjmuje, co zwraca>
            func(" From Func ");
            Console.WriteLine("Wartość tekstu: {0}", GetText());
            Func<string, string> func1 = AddText;
            func1(" Func1 ");
            Console.WriteLine("Wartość tekstu: {0}", GetText());

            // Funkcja anonimowa (nie istnieją na poziomie klas)
            Func<int, int, int> func2 = (int a, int b) => a + b;

            ShowResult(Add(1, 2));
            ShowResult(func2(1, 2));

            // Action - nic nie zwraca
            Action<int> action = delegate (int result) { Console.WriteLine(result); };
            action(Add(3, 4));
            Action<int> action1 = (result) => Console.WriteLine(result);
            action1(Add(4, 5));

            Console.ReadKey();
        }

        // Wyrażenie Lambda
        public static void ShowResult(int result) => Console.WriteLine(result);

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
