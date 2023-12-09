using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.KontenerIoC
{
    interface IItemService
    {
        void AddItem(Item item);
        bool DeleteItem(Guid id);
    }
}
