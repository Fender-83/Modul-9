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
            string[] lastname = new string[5];
            for (int i = 0; i < lastname.Length; i++)
            {
                Console.WriteLine("Введите фамилию " + (i + 1) + "-й персоны");
                lastname[i] = Console.ReadLine();
            }
            Event Event = new Event();
            Event.lastnames = lastname;
            Console.Write("Массив: ");

            foreach (var name in lastname)
            {
                Console.Write(name + " ");
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
                   
                    Array.Sort(lastnames);

                    foreach (var i in lastnames)
                    {
                        Console.Write("{0} ", i);
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                    return;

                case 2:
                   

                    Array.Sort(lastnames);
                    Array.Reverse(lastnames);

                    foreach (var i in lastnames)
                    {
                        Console.Write("{0} ", i);
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                    return;
            }
        }
    }
}
        
