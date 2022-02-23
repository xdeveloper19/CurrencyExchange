using Converter.Models;
using System;

namespace Converter.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = true;

            while (f)
            {
                Console.WriteLine("Это конвертер валют.");
                Console.WriteLine("Введите баланс РУБ");

                var userinput2 = 0;
                Int32.TryParse(Console.ReadLine(), out userinput2);

                if (userinput2 == 0)
                    Console.WriteLine("!!!!!");

                Console.WriteLine("   выберите действие \n 1 - РУБ > USD  \n 2 - РУБ > EUR \n 3 - РУБ > FRA \n 4 - ДОПОЛНИТЕЛЬНОЕ МЕНЮ \n 5- ВЫХОД НА)(УЙ");
                string swiher = Console.ReadLine();
                switch (swiher)
                {
                    case "1":
                        Console.WriteLine("\n \n \n выбрано первое действие РУБ > USD \n" + Math.Round(userinput2 / ConverterModel.USA));
                        break;
                    case "2":
                        Console.WriteLine("\n \n \n выбрано первое действие РУБ > EUR \n" + " значение округлено до целых \n " + "   " + Math.Round(userinput2 / ConverterModel.EUR));
                        break;
                    case "3":
                        Console.WriteLine("\n \n \n выбрано первое действие РУБ > FRA \n" + " значение округлено до целых \n " + "   " + Math.Round(userinput2 / ConverterModel.FRA));
                        break;
                    case "4":
                        Console.WriteLine("Меняем цвет");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        break;
                    case "5":
                        f = false;
                        Console.Clear();
                        Console.WriteLine("Говно бля!");
                        break;
                }
            }

            Console.ReadKey();
            return;
        }
    }
}
