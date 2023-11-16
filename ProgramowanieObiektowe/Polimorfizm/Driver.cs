using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Polimorfizm
{
    public class Driver : Employee
    {
        public override void Work() // Przeciążanie dynamiczne
        {
            base.Work();
            Console.WriteLine("Driver.Work()");
        }
    }
}
