using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.KlasaAbstrakcyjnaVS_Interfejs
{
    // W interfejsie wszystkie publiczne metody, w klasie abstrakcyjnej nie
    public class ProductService : IProductService
    {
        public static string GetProductName()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public int Add(Product product) 
        {
            return 1;
        }

    }
}
