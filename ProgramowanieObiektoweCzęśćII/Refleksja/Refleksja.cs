using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.Refleksja
{
    class Refleksja
    {
        public Refleksja()
        {
            // Refleksja to zbiór metod z system. , umożliwia dynamiczne tworzenie zmiennych, klas i obiektów reflection
            var car = Car.Create("Porshe");
            var type = car.GetType();
            Console.WriteLine($"Car {type.Name}"); // - typ zmiennej

            var methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name); // Wszystkie metody
            }
            car.ChangeName("Tester");
            var changeNameMethod = type.GetMethod(nameof(Car.ChangeName));
            changeNameMethod!.Invoke(car, new object[] { "BMW" });
            Console.WriteLine(car);
            var runCarMethod = type.GetMethod(nameof(Car.RunCar));
            runCarMethod!.Invoke(car, null);
            Console.WriteLine(car);
            var idField = type.GetField($"<{nameof(Car.Id)}>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance);
            idField!.SetValue(car, Guid.NewGuid());
            Console.WriteLine(car);
        }
    }
}
