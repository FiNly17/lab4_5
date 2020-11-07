using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class Printer
    {
		public static void IAmPrinting(ref IGetInfo obj)
		{
			switch (obj.GetType().Name)
			{
				case "Inventory":
					Console.WriteLine("Inventory");
					((Inventory)obj).GetInfo();
					break;
				case "Mat":
					Console.WriteLine("Mats");
					((Mat)obj).GetInfo();
					break;
				case "Bench":
					Console.WriteLine("Benchs");
					((Bench)obj).GetInfo();
					break;
				case "Bars":
					Console.WriteLine("Bars");
					((Bars)obj).GetInfo();
					break;
				case "Ball":
					Console.WriteLine("Balls");
					((Ball)obj).GetInfo();
					break;
				case "Type of sport":
					Console.WriteLine("Type of sport");
					((Type_Of_Sport)obj).GetInfo();
					break;
				default:
					Console.WriteLine("Тип объекта не распознан");
					break;
			}
		}

		public static void IAmPrinting(ref object obj)
		{
			switch (obj.GetType().Name)
			{
				case "Inventory":
					Console.WriteLine("Inventory");
					((Inventory)obj).GetInfo();
					break;
				case "Mat":
					Console.WriteLine("Mats");
					((Mat)obj).GetInfo();
					break;
				case "Bench":
					Console.WriteLine("Benchs");
					((Bench)obj).GetInfo();
					break;
				case "Bars":
					Console.WriteLine("Bars");
					((Bars)obj).GetInfo();
					break;
				case "Ball":
					Console.WriteLine("Balls");
					((Ball)obj).GetInfo();
					break;
				case "Type_Of_Sport":
					Console.WriteLine("Type of sport");
					((Type_Of_Sport)obj).GetInfo();
					break;
				default:
					Console.WriteLine("Тип объекта не распознан");
					break;
			}
		}
	}
}
