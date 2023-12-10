using System.Text.Json;

namespace OperacjeNaDanych.PlikiJSON
{
    class PlikiJSON
    {
        public PlikiJSON()
        {
            List<Product> products = new()
            {
                new Product { Id = 1, Name = "Product#1", Cost = 100M },
                new Product { Id = 2, Cost = 200M },
                new Product { Id = 3, Name = "Product#3", Cost = 300M },
                new Product { Id = 4, Name = "Product#4", Cost = 400M },
                new Product { Id = 5, Name = "Product#5", Cost = 500M },
            };

            var currentDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(currentDirectory)?.Parent?.Parent?.FullName;
            var filePath = projectDirectory + Path.DirectorySeparatorChar + "products.json";
            using FileStream fileStreamWrite = new(path: filePath, FileMode.Create);
            JsonSerializer.Serialize(fileStreamWrite, products);
            fileStreamWrite.Dispose(); // Usuwanie z pamięci fileStream

            using FileStream fileStreamRead = new(path: filePath, FileMode.Open);
            var productsFromFile = JsonSerializer.Deserialize<List<Product>>(fileStreamRead);
            fileStreamRead.Dispose();

            foreach (var product in productsFromFile)
            {
                Console.WriteLine($"{product.Id} {product.Name} {product.Cost}");
            }
        }
    }
}
