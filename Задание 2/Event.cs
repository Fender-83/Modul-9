using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Задание_2
{
    public class Event
    {
        internal string[] lastnames;

        public delegate void NumberEnteredDelegate(int number, string[] lastnames);
        public event NumberEnteredDelegate NumberEnteredEvent;
        public void Read()
        {
        link:
            Console.Write(Environment.NewLine + "Выберете тип сортировки:" + Environment.NewLine + "А-Я (нажмите 1) или Я-А (нажмите 2): ");
            int choice = default;
            try
            {

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Выбран метод сортировки  'А-Я'");
                        break;

                    case 2:
                        Console.WriteLine("Выбран метод сортировки 'Я-А'");
                        break;

                    default:
                        throw new Exception("Неверный выбор");
                }
            }
            catch (Exception ex) when (ex.Message == "Выбор некорректен!")
            {
                Console.WriteLine("Выберите сортировку 1 или 2");

                goto link;
            }
            catch (Exception error)
            {

                Console.WriteLine($"Неверно! {error.Message}");
                goto link;
            }
            NumberEntered(choice, lastnames);
        }
        public string[] lnames;
        protected virtual void NumberEntered(int number, string[] lastnames)
        {
            NumberEnteredEvent.Invoke(number, lastnames);
        }
    }
}