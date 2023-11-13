using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PierwszaAplikacjaKonsolowa.MetodyNauka;

namespace PierwszaAplikacjaKonsolowa.MetodyNauka
{
    internal class MetodyUzycie
    {
        public MetodyUzycie()
        {
            Metody.Create();
            Metody metody = new Metody();
            // metody.Create(); <- niemożliwy dostęp
        }
    }
}
