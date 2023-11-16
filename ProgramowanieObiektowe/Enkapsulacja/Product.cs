using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Enkapsulacja;

public class Product
{
    public int Id { get; }
    public string Name { get; private set; } = nameof(Product);
    public decimal Price { get; private set; }

    public Product(int id, string? name, decimal price)
    {
        Id = id;
        Name = name;
        ChangePrice(price);
    }

    public void ChangeName(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            return;
        }

        Name = name;
    }

    public void ChangePrice(decimal price)
    {
        Price = price * 1.23M;
    }
}
