using PierwszaAplikacjaKonsolowa.KlasyPodstawa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PierwszaAplikacjaKonsolowa.KlasyPodstawa;

namespace PierwszaAplikacjaKonsolowa.Klasy_ObiektyPodstawa
{
    public class KlasyObiektyUzycie
    {
        public KlasyObiektyUzycie()
        {
            // Klasy i Obiekty

            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Vehicle #1";
            vehicle.EngineCapacity = 1000;
            Console.WriteLine(vehicle);
            Vehicle vehicle1 = new() { Name = "Vehicle #2", EngineCapacity = 200 };
            Console.WriteLine(vehicle1);

            // Jak vehicle is null - spełni się drugi warunek, jak nie to vehicle2 = vehicle
            Vehicle vehicle2 = vehicle ?? new() { Name = "Vehicle #2", EngineCapacity = 200 };
        }
    }
}
