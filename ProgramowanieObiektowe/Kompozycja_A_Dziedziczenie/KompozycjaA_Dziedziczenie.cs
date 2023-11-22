using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Kompozycja_A_Dziedziczenie
{
    public class KompozycjaA_Dziedziczenie
    {
        public KompozycjaA_Dziedziczenie()
        {
            var butterfly = new Butterfly(new FlyingAnimal(), "Nazwa");
            Console.WriteLine(butterfly);
            Console.WriteLine(butterfly.GetName());
        }
    }
}
