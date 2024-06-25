﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanKruger_Software1
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse() { }
        public Inhouse(string name, decimal price, int inStock, int min, int max, int machineID) : base(name, price, inStock, min, max)
        {
            MachineID = machineID;
        }
        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID) : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }

    }
}
