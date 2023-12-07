using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Strategy
{
    public class MongoClient : IMongoClient
    {
        public void Connect()
        {
            Console.WriteLine("Connecting...");
            Console.WriteLine("Connected");
        }
    }
}
