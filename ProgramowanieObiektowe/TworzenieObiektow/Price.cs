using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.TworzenieObiektow
{
    public class Price
    {
        public decimal Amount { get; }

        public Price(decimal amount)
        {
            Amount = amount;
        }

        public Price()
        {
            
        }

        public static Price Create(decimal amount)
        {
            return new Price(amount);
        }

        public string GetValue(string pattern)
        {
            return string.Format(pattern, Amount);
        }

        public string GetValue()
        {
            return Amount.ToString();
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Price);
        }

        public bool Equals(Price other)
        {
            if(ReferenceEquals(other, null)) return false;
            if(ReferenceEquals(other, this)) return true;

            return this.Amount == other.Amount;
        }
    }
}
