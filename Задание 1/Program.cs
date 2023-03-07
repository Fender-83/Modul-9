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
                new FileNotFoundException("Файл не найден!"),
                new ArgumentNullException("Аргумент является null!"),
                new IndexOutOfRangeException("Выход за пределы границ массива!"),
                new DivideByZeroException("Деление на ноль недопустимо!"),
                new ArgumentException ("Непустой аргумент!"),
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

