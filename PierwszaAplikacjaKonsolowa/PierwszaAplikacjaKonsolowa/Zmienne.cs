using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa
{
    internal class Zmienne
    {
        // Zmienne
        int a = 0;
        float flo = 3.13f;
        double d = 2.5;
        bool isValidate = true;
        char ad = 'a';
        enum Type
        {
            LOW,
            HIGH,
            MEDIUM
        };

        struct Price
        {
            public int ValueDecimal;
            public int ValuePointer;

            public Price(int valueDevcimal, int valuePointer)
            {
                this.ValueDecimal = valueDevcimal;
                this.ValuePointer = valuePointer;
            }
        };

        Price price = new Price(1, 2);
        Price price21 = new(1, 5);
    }
}
