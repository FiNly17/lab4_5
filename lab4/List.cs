using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Versioning;

namespace lab4
{
#pragma warning disable CS0660 // Тип определяет оператор == или оператор !=, но не переопределяет Object.Equals(object o)
#pragma warning disable CS0661 // Тип определяет оператор == или оператор !=, но не переопределяет Object.GetHashCode()
    class MyList
#pragma warning restore CS0661 // Тип определяет оператор == или оператор !=, но не переопределяет Object.GetHashCode()
#pragma warning restore CS0660 // Тип определяет оператор == или оператор !=, но не переопределяет Object.Equals(object o)
    {
        public List<string> Values { get; private set; }

        public Owner Info { get; private set; }
        public DateTime Date { get; private set; }
        public int Count { get { return Values.Count; } }

        //конструкторы

        public MyList(string name, string surname, int id, params dynamic[] items)
        {
            Date = DateTime.Now;
            Info = new Owner(name, surname, id);
            Values = new List<string>();
            foreach (var item in items)
            {
                Values.Add(item.ToString());
            }
        }

        public MyList()
        {
            Date = DateTime.Now;
            Info = new Owner("-", "-", 0);
            Values = new List<string>();
        }

        public string this[int index]
        {
            get => Values[index];
            set => Values[index] = value;
        }

        public void Add(dynamic item)
        {
            Values.Add(item.ToString());
        }

        public void AddFirst(dynamic item)
        {
            Values.Insert(0, item.ToString());
        }

        public void RemoveFirst()
        {
            Values.RemoveAt(0);
        }

       
        public static MyList operator +(dynamic item, MyList list)
        {
            MyList result = new MyList(list.Info.Name, list.Info.Surname, list.Info.Id);
            foreach (var elem in list.Values)
            {
                result.Add(elem);
            }
            result.AddFirst(item);
            return result;
        }

        public static MyList operator --(MyList list)
        {
            MyList result = new MyList(list.Info.Name, list.Info.Surname, list.Info.Id);
            foreach (var item in list.Values)
            {
                result.Add(item);
            }
            result.RemoveFirst();
            return result;
        }


        public static bool operator !=(MyList list1, MyList list2)
        {
            if (list1.Count != list2.Count)
                return true;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1.Values[i] != list2.Values[i])
                    return true;
            }
            return false;
        }
        public static MyList operator >(MyList list1, MyList list2)
        {
            MyList result = new MyList(list2.Info.Name, list2.Info.Surname, list2.Info.Id);
            foreach (var item in list1.Values)
            {
                list2.Add(item);
            }
            return list2;
        }
        public static MyList operator <(MyList list1,MyList list2)
        {
            MyList result = new MyList(list1.Info.Name, list1.Info.Surname, list1.Info.Id);
            foreach (var item in list2.Values)
            {
                list1.Add(item);
            }
            return list1;  
        }
        public static MyList operator !(MyList list1)
        {
            MyList result = new MyList(list1.Info.Name, list1.Info.Surname, list1.Info.Id);
            foreach(var item in list1.Values)
            {
                result.AddFirst(item);
            }
            return result;
        }
        public static bool operator ==(MyList list1, MyList list2)
        {
            if (list1.Count != list2.Count)
                return false;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1.Values[i] != list2.Values[i])
                    return false;
            }
            return true;
        }

        public static MyList operator +(MyList list1, MyList list2)
        {
            MyList result = new MyList(list1.Info.Name, list1.Info.Surname, list1.Info.Id);
            foreach (var item in list1.Values)
            {
                result.Add(item);
            }
            result.Values.AddRange(list2.Values);
            return result;
        }

        public class Owner
        {
            public Owner(string name, string surname, int id)
            {
                Name = name;
                Surname = surname;
                Id = id;
            }

            public Owner(Owner father)
            {
                Name = father.Name;
                Surname = father.Surname;
                Id = father.Id;
            }

            public string Name { get; private set; }
            public string Surname { get; private set; }
            public int Id { get; private set; }
        }
    }

    static class StatisticOperation
    {
        public static string Rem(this MyList list1,int chislo)
        {
            Console.WriteLine("Список: ");
            foreach (var item in list1.Values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Выберите какой элемент вы хотите сократить: ");
            int v = Convert.ToInt32(Console.ReadLine());
            string q=list1.Values[v].Remove(chislo);
            return q;
        }

        public static int Count(MyList list)
        {
            return list.Count;
        }
    }
}
