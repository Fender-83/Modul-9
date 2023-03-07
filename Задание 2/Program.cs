using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lastname = new string[] { "Иванов", "Петров", "Сидоров", "Кузнецов", "Кузьмин" };

            Event Event = new Event();
            Event.lastnames = lastname;
            Console.Write("Массив: ");

            foreach (var name in lastname)
            {
                Console.Write(lastname + " ");
            }
            Event.NumberEnteredEvent += Sort;
            Event.Read();

            Console.ReadKey();
        }

        static void Sort(int choice, string[] lastnames)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Введено {choice}");
                    SortMaxMin(lastnames);
                    break;
                case 2:
                    Console.WriteLine($"Введено {choice}");
                    SortMaxMin(lastnames);
                    break;
            }
        }
        public static void SortMinMax(string[] lastname)
        {
            Array.Sort(lastname);
            foreach (string str in lastname)
            {
                Console.Write(str + " ");
            }
        }

        public static void SortMaxMin(string[] lastname)
        {
            Array.Sort(lastname);
            foreach (string str in lastname)
            {
                Console.Write(str + " ");
            }
        }
    }
}
        
