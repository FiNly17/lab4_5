﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class Mat : Inventory, IGetInfo
    {
        public string Type { get; private set; }

        public Mat(string company, string color, double price, double weight, string type) :
             base(company, color, price, weight)
        {
            Type = type;
        }
        public override string ToString()
        {
            Console.WriteLine("1");
            return base.ToString() + $"\n Вид матов: {Type}";
        }
        
       void IGetInfo.GetInfo()
       {
           Console.WriteLine(ToString());
       }
       
        public override void GetInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
