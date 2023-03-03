using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Exception[] exc =
                {
                new NullExc("Аргумент является null!"),
                new ArgumentExc("Непустой аргумент!"),
                new DivideByZeroExc("Деление на ноль недопустимо!"),
                new FileNotFoundExс("Файл не найден!"),
                new IndexOutOfRangeExc("Выход за пределы границ массива!")
            };

                foreach (var error in exc)
                {
                    try
                    {
                        throw error;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
