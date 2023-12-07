using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Decorator
{
    interface ISender
    {
        void Send(IMessage message);
    }
}
