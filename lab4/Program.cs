using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace lab4
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            
            while (true)
            {
                var list1 = new MyList("dannil", "finskiy", 1, "text", 111, "Text111", "TEXt111");
                var list1copy = new MyList("dannil", "finskiy", 1, "text", 111, "Text111", "TEXt111");
                var list2 = new MyList("vlad", "simakovich", 2, "text", 222, "Text222");
                var list3 = new MyList("zayac", "roman", 3, "text", 333, "Text333", 333);
                var list3copy = new MyList("zayac", "roman", 3, "text", 333, "Text333", 333);

                //операторы 
                var list4 = !list1;
                var list5 = list1 + list2;
                Console.WriteLine(
                    "1 - усечение строки до заданной длины" +
                    "\n2 - вывод объектов класса " +
                    "\n3 - сумма элементов списка " +
                    "\n4 - инверсия элементов списка " +
                    "\n5 - объединение двух списков" +
                    "\n6 - проверка на неравенство" +
                    "\n7 - добавление одного списка к другому"
                    );
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите длину: ");
                            int ch = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(
                                "1 - list1" +
                                "\n2 - list2" +
                                "\n3 - list3" +
                                "\n4 - list4" +
                                "\n5 - list5"
                                );
                            int chisl = Convert.ToInt32(Console.ReadLine());
                            switch (chisl)
                            {
                                case 1:
                                    Console.WriteLine("Сокращенный элемент: " + list1.Rem(ch));
                                    break;
                                case 2:
                                    Console.WriteLine("Сокращенный элемент: " + list2.Rem(ch));
                                    break;
                                case 3:
                                    Console.WriteLine("Сокращенный элемент: " + list3.Rem(ch));
                                    break;
                                case 4:
                                    Console.WriteLine("Сокращенный элемент: " + list4.Rem(ch));
                                    break;
                                case 5:
                                    Console.WriteLine("Сокращенный элемент: " + list5.Rem(ch));
                                    break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("list1:");
                            foreach (var item in list1.Values)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine("\nlist2:");
                            foreach (var item in list2.Values)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine("\nlist3:");
                            foreach (var item in list3.Values)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine("\nlist3copy:");
                            foreach (var item in list3copy.Values)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine(
                                "1 - длина списка list1" +
                                "\n2 - длина списка list2" +
                                "\n3 - длина списка list3" +
                                "\n4 - длина списка list4" +
                                "\n5 - длина списка list5"
                                );
                            int chisl = Convert.ToInt32(Console.ReadLine());
                            switch (chisl)
                            {
                                case 1: Console.WriteLine("Длина списка list1: "+list1.Count);
                                    break;
                                case 2:
                                    Console.WriteLine("Длина списка list2: " + list2.Count);
                                    break;
                                case 3:
                                    Console.WriteLine("Длина списка list3: " + list3.Count);
                                    break;
                                case 4:
                                    Console.WriteLine("Длина списка list4: " + list4.Count);
                                    break;
                                case 5:
                                    Console.WriteLine("Длина списка list5: " + list5.Count);
                                    break;
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine($"список list1:");
                            foreach (var item in list1.Values)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            Console.WriteLine($"инверсия элементов списка list1:");
                            foreach (var item in list4.Values)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine($"Объединение двух списков:");
                            foreach (var item in list5.Values)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Проверка на неравенство(true - равно, false - неравно):");
                            Console.WriteLine($"list1 == list2: {list1 == list2} ");
                            Console.WriteLine($"list3 == list3copy: {list3 == list3copy} ");
                        }
                        break;
                    case 7:
                        {

                            var list6 = list1 < list2;
                            Console.WriteLine($"Присоединение list2 k list1: ");
                            foreach (var item in list6.Values)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
