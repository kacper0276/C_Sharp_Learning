using System.Text;

namespace OperacjeNaDanych.OperacjeNaPlikach
{
    class OperacjeNaPlikach
    {
        public OperacjeNaPlikach()
        {
            //using (FileStream fileStream = File.Open())
            //{
            //}
            // Równoważny zapis
            //using FileStream fileStream = File.Open(); 

            

            static async Task SaveProductToFile(string path, Product product)
            {
                // using FileStream fileStream = File.Open(path, FileMode.Append, FileAccess.Write); // Append - tylko dopisywanie do pliku
                // using StreamWriter streamWriter = new(fileStream, Encoding.UTF8);
                // await streamWriter.WriteLineAsync(product.ToString());
                // Równoważny zapis
                // File.WriteAllLinesAsync(path, new string[] { product.ToString() }); - zapis
                File.AppendAllLinesAsync(path, new string[] { product.ToString() }); // Tylko dopisywanie do pliku
            }

            static async Task<List<Product>> ReadProductsFromFile(string path)
            {
                // using FileStream fileStream = File.Open(path, FileMode.Append, FileAccess.Write); // Append - tylko dopisywanie do pliku
                // using StreamReader streamReader = new(fileStream, Encoding.UTF8);

                var products = new List<Product>();

                await foreach (var line in File.ReadLinesAsync(path, Encoding.UTF8))
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    var lineSplited = line.Split(';');
                    var idParsed = int.TryParse(lineSplited[0], out var id);
                    var priceParsed = int.TryParse(lineSplited[0], out var price);

                    if (!idParsed || !priceParsed)
                    {
                        continue;
                    }
                    products.Add(new Product { Id = id, Name = lineSplited[1], Price = price });
                }

                return products;
            }

            var currentDirectory = Environment.CurrentDirectory;
            Console.WriteLine(currentDirectory); // C:\Users\kacpe\Desktop\Nauka - C#\OperacjeNaDanych\bin\Debug\net7.0
            var projectDirectory = Directory.GetParent(currentDirectory)?.Parent?.Parent.FullName;
            Console.WriteLine(projectDirectory); // C:\Users\kacpe\Desktop\Nauka - C#\OperacjeNaDanych
            var filePath = projectDirectory + Path.DirectorySeparatorChar + "file.csv";

            var product = new Product { Id = 2, Name = "Product#2", Price = 200M };
            //await SaveProductToFile(filePath, product);

            // var products = await ReadProductsFromFile(filePath);
            //foreach (var productFor in products)
            //{
              //  Console.WriteLine(productFor.ToString());
            // }
        }
    }
}
