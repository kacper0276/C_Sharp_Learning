using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Dziedziczenie
{
    public class Dziedziczenie
    {
        public Dziedziczenie()
        {
            Car car = new Car("BMW", 3200);
            Motocycle motocycle = new Motocycle("Honda", 600);

            Console.WriteLine(car);
            Console.WriteLine(motocycle);

            StartVehicle(car);
            StartVehicle(motocycle);

            Console.WriteLine(car);
            Console.WriteLine(motocycle);

            static void StartVehicle(Vehicle vehicle)
            {
                vehicle.Start(); // Uruchamia metody ovveride a nie z Vehicle
            }
        }
    }
}
