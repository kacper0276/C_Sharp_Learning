using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa.ZakresyWidocznosci
{
    public class ZakresyWidocznosci
    {
        public string Name { get; set; }
        private int Id { get; set; }
        protected int priority { get; set; } = 0; // Współdzielenie między klasami które dziedziczą
         // internal -  Dostęp do zmiennej - dostępna tylko w jednym projekcie

        public void SetId(int id)
        {
            if(id < 0)
            {
                Id = 1000;
                return;
            }

            Id = id;
        }

        public int GetId()
        {
            return Id;
        }

        public ZakresyWidocznosci()
        {
            
        }
    }

    public class Item2 : ZakresyWidocznosci
    {
        public Item2()
        {
            priority = 2;
        }
    }
}
