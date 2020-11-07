using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace lab5
{
    abstract class Inventory : IGetInfo
    {
        public string Company { get; private set; }
        public string Color { get; private set; }
        public double Price { get; private set; }
        public double Weight { get; private set; }
        public Inventory(string company, string color, double price, double weight)
        {
            Company = company;
            Color = color;
            Price = price;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"Компания: {Company}; Цвет: {Color}; Цена: {Price}; Вес: {Weight};";
        }
        public abstract void GetInfo();
    }
    interface IGetInfo
    {
        void GetInfo();
    }
}
