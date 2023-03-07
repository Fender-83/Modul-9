using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string [] ara = new string[] { "Иванов", "Астахов", "Сидоров", "Якушин", "Кузьмин" };
            //массив до сортировки
            foreach (var i in ara)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            /*сортировка по убыванию, в начале нужно отсортировать по возрастанию, если этого
            не зделать метод Reverse отобразит значения массива с конца*/
            Array.Sort(ara);
            Array.Reverse(ara);
            //массив после сортировки
            foreach (var i in ara)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.ReadKey();
            return ;
        }
    }
}
