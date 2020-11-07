using System;
using System.Collections.Generic;

namespace lab5
{
    class Program
    {
            static List<Inventory> inventory = new List<Inventory>
        {
            new Bars("Nike", "red", 2000, 20, "jump"),
            new Bench("Puma", "black", 1000, 20, "jump"),
            new Mat("White", "white", 300, 5, "gimnastika"),
            new Mat("Amd", "white", 200, 4, "bor'ba"),
            new Type_Of_Sport("Adidas", "orange", 100, 1, "qwe", "Basketball"),
            new Type_Of_Sport("Nike", "green", 5, 0.02, "qwe" ,"Tennis")
        };
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = 0; i < inventory.Count; i++)
            {
                object link = inventory[i];
                Printer.IAmPrinting(ref link);
                Console.WriteLine("\n\n\n");
            }

            Console.WriteLine("\nВызов одноимённого override метода");
            inventory[0].GetInfo();
            Console.WriteLine("\nВызов одноимённого интерфейса");
            ((IGetInfo)inventory[0]).GetInfo();
        }
    }
}
