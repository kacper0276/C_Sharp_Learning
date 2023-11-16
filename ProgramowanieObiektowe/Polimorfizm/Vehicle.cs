using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Polimorfizm
{
    public abstract class Vehicle // Nie można utworzyć obiektu z klasy abstrakcyjnej
    {
        public void Run()
        {
            Console.WriteLine("Implementation");
            Prepare();
        }

        public abstract void Prepare(); // Abstrakcyjna metoda nie ma ciała
    }
}
