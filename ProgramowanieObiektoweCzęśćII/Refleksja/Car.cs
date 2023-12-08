using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.Refleksja
{
    public class Car
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; private set; } = nameof(Car);
        public bool IsRunning { get; private set; } = false;

        private Car() { }

        public static Car Create(string name)
        {
            return new Car { Name = name };
        }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void RunCar()
        {
            IsRunning = true;
        }

        public void StopCar()
        {
            IsRunning = false;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {IsRunning}";
        }
    }
}
