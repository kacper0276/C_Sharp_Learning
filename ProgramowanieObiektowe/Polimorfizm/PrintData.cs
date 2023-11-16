using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Polimorfizm
{
    public class PrintData
    {
        public void Print(int a)
        {
            Console.WriteLine("Print number: {0}", a); // W miejsce 0 wartość a
        }

        public void Print(double a)
        {
            Console.WriteLine("Print double number: {0}", a); // W miejsce 0 wartość a
        }

        public void Print(long a)
        {
            Console.WriteLine("Print long number: {0}", a); // W miejsce 0 wartość a
        }

        public void Print(string a)
        {
            Console.WriteLine("Print string: {0}", a); // W miejsce 0 wartość a
        }
    }
}
