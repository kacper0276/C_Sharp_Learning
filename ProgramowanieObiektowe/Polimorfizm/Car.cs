using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Polimorfizm
{
    public class Car : Vehicle
    {
        public override void Prepare()
        {
            Console.WriteLine("Prepare Car");
        }
    }
}
