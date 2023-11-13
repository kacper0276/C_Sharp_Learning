using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa.KlasyPodstawa
{
    public class Vehicle
    {
        public string Name { get; set; } = "";
        public int EngineCapacity { get; set; }
        public string Color { get; set; } = "White";
        public int Sound { get; set; } = 0;

        public Vehicle()
        {   }

        public Vehicle(int  engineCapacity, string name)
        {
            EngineCapacity = engineCapacity;
            Name = name;
        }

        public void Start()
        {
            Sound = 100;
        }

        public void Stop()
        {
            Sound = 0;
        }

        public override string ToString()
        {
            return $"Name {Name}, EngineCapacity {EngineCapacity}";
        }
    }
}
