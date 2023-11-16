using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Polimorfizm
{
    public class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee.Work()");
        }
    }
}
