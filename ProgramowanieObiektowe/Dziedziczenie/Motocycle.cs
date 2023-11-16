using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Dziedziczenie;

public class Motocycle : Vehicle
{
    public Motocycle(string name, int engineCapacity) : base(name, engineCapacity)
    {
        vin = 100;
    }

    public override void Start()
    {
        Sound = 40;
    }

    public void SetColor(string color)
    {
        Color = color;
    }
}
