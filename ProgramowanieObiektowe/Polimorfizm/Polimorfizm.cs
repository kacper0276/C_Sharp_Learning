using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Polimorfizm
{
    public class Polimorfizm // Polimorfizm - wiele kształtów, czyli przeciążanie metod
    {
        public Polimorfizm()
        {
            PrintData printData = new PrintData();

            printData.Print(10);
            printData.Print("Napis");
            printData.Print((double)10);
            printData.Print((long)15);

            Employee employee = new Employee();
            Driver driver = new Driver();
            employee.Work();
            driver.Work();

            Car car = new Car();
            car.Prepare();
            car.Run();

        }
    }
}
