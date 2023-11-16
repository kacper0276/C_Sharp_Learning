using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Dziedziczenie;

public class Vehicle // sealed - blokuje możliwość dziedziczenia z tej klasy public sealed class Vehicle
{
    public string Name { get; set; } = "";
    public int EngineCapacity { get; set; }
    public string Color { get; set; } = "White";
    public int Sound { get; protected set; } = 0;
    protected int vin = 0;

    public Vehicle(string name, int engineCapacity)
    {
        Name = name;
        EngineCapacity = engineCapacity;
    }

    public virtual void Start() // virtual - umożliwia przesłonięcie metody
    {
        Sound = 50;
    }

    public virtual void Stop()
    {
        Sound = 0;
    }

    public override string ToString()
    {
        return $"Name {Name}, EngineCapacity {EngineCapacity}, Color {Color}, Sound {Sound}";
    }
}

