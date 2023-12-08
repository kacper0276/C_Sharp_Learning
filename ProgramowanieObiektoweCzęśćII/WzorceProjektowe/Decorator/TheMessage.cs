using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Decorator
{
    class TheMessage : IMessage
    {
        public IDictionary<string, string> Header { get; set; } = new Dictionary<string, string>();
        public string Body { get; set; } = nameof(TheMessage);
    }
}
