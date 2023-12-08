using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.Dynamic
{
    class Dynamics
    {
        public Dynamics()
        {
            dynamic variable = "string";
            Console.WriteLine(variable);
            variable = 20;
            Console.WriteLine(variable);
            variable = "dynamic";
            Console.WriteLine(variable);
            variable = new
            {
                A = 1000
            };
            Console.WriteLine(variable);

            variable = new ProgramowanieObiektoweCzęśćII.Dynamic.OldVersion.Mechanic();
            Console.WriteLine(ConvertToNewEmployee(variable));

            static ProgramowanieObiektoweCzęśćII.Dynamic.NewVersion.Employee? ConvertToNewEmployee(dynamic employee)
            {
                if (employee == null)
                    return null;

                if (employee is ProgramowanieObiektoweCzęśćII.Dynamic.OldVersion.Mechanic mechanic)
                    return Convert<ProgramowanieObiektoweCzęśćII.Dynamic.NewVersion.Mechanic, ProgramowanieObiektoweCzęśćII.Dynamic.OldVersion.Mechanic>(mechanic);

                if (employee is ProgramowanieObiektoweCzęśćII.Dynamic.OldVersion.Architect architect)
                    return Convert<ProgramowanieObiektoweCzęśćII.Dynamic.NewVersion.Architect, ProgramowanieObiektoweCzęśćII.Dynamic.OldVersion.Architect>(architect);

                throw new ArgumentException($"Unknown Employee {nameof(employee)}");
            }

            static T? Convert<T, U>(U a)
                where T : class, new()
                where U : class, new()
            {
                return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(a));
            }
        }
    }
}
