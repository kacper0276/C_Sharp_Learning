using System.Xml.Serialization;

namespace OperacjeNaDanych.PlikiXML
{
    class PlikiXML
    {
        public PlikiXML()
        {
            List<Product> products = new()
            {
                new Product { Id = 1, Name = "Product#1", Cost = 100M },
                new Product { Id = 2, Name = "Product#2", Cost = 200M },
                new Product { Id = 3, Name = "Product#3", Cost = 300M },
                new Product { Id = 4, Name = "Product#4", Cost = 400M },
                new Product { Id = 5, Name = "Product#5", Cost = 500M },
            };

            XmlRootAttribute root = new()
            {
                ElementName = "Products",
                IsNullable = true
            };
            XmlSerializer xmlSerializer = new(typeof(List<Product>), root);

            var currentDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(currentDirectory)?.Parent?.Parent?.FullName;
            var filePath = projectDirectory + Path.DirectorySeparatorChar + "products.xml";
            using FileStream fileStream = new(path: filePath, FileMode.Create);
            xmlSerializer.Serialize(fileStream, products);

            fileStream.Close();

            List<Priority> priorities = new()
            {
                new Priority{ Id = 1, Name = "Priority#1" },
                new Priority{ Id = 2, Name = "Priority#2" },
                new Priority{ Id = 3, Name = "Priority#3" },
                new Priority{ Id = 4, Name = "Priority#4" },
                new Priority{ Id = 5, Name = "Priority#5" },
            };
            var filePathPriorities = projectDirectory + Path.DirectorySeparatorChar + "priorities.xml";
            using FileStream fileStreamPriorities = new(path: filePathPriorities, FileMode.Create);
            XmlSerializer xmlSerializerPriorities = new(typeof(List<Priority>));
            xmlSerializerPriorities.Serialize(fileStreamPriorities, priorities);
            fileStreamPriorities.Close();

            using StreamReader readerProducts = new(filePath);
            using StreamReader readerPriorities = new(filePathPriorities);
            var listProducts = (List<Product>)xmlSerializer.Deserialize(readerProducts);
            var listPriorities = (List<Priority>)xmlSerializerPriorities.Deserialize(readerPriorities);

            foreach (var product in listProducts)
            {
                Console.WriteLine($"{product.Id} {product.Name} {product.Cost}");
            }

            Console.WriteLine("-----------------------------------------------");

            foreach (var priority in listPriorities)
            {
                Console.WriteLine($"{priority.Id} {priority.Name}");
            }
        }
    }
}
