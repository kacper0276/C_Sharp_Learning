using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.KlasaAbstrakcyjnaVS_Interfejs
{
    public class KlasaAbstrakcyjnaVS_Interfejs
    {
        // Interfejs określa co powinno być zrobione
        public KlasaAbstrakcyjnaVS_Interfejs()
        {
            var service = new ProductService();
            ((IProductService)service).Add(new Product());
        }
    }
}
