using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class Type_Of_Sport : Ball
    {
        public string Sport { get; private set; }
        public Type_Of_Sport(string company, string color, double price, double weight, string type, string sport) :
            base(company, color, price, weight, type)
        {
            Sport = sport;
        }
        public override string ToString()
        {
            return "Мяч" + base.ToString() + $"\n спорт: {Sport} ";
        }
    }
}
