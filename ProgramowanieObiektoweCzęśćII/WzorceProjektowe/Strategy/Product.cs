﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Strategy
{
    class Product
    {
        public Guid Id => Guid.NewGuid();
        public string Name { get; set; }
    }
}
