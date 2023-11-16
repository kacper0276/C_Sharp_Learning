using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Dziedziczenie;

public class Car : Vehicle
{
    public Car(string name, int engineCapacity) : base(name, engineCapacity) // base - konstruktor nadrzedny
    {
        vin = 10;
    }

    public override void Start()
    {
        Sound = 150;
        for(int i = 0; i < 100; i++)
        {
        }
        base.Start(); // Funkcja z klasy nadrzednej
    }

    public override void Stop()
    {
        base.Stop();
    }

    public void SetColor(string color)
    {
        if(color == "Grey")
        {
            return;
        }
        Color = color;
    }
}
