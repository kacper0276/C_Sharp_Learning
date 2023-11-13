using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa.Pola_Wlasciwosci
{
    internal class Item
    {
        private string name = ""; // Pole
        public int Id { get; set; } // Getter i Setter <- właściwość
        public string Name { get; set; }
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }
        public string TylkoOdczyt { get; }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
