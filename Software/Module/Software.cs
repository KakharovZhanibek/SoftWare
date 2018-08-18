﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Module
{
    public abstract class Software
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public abstract  void PrintInfo();
    }
}
