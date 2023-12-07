using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Decorator
{
    interface IMessage
    {
        public IDictionary<string, string> Header { get; set; }
        public string Body { get; set; }
    }
}
