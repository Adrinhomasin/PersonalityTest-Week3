using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Mis hinde sa said");
            String number = Console.ReadLine();

            switch (number)
            {
                case "5":
                    Console.WriteLine("suurepärane");
                    break;
                case "4":
                    Console.WriteLine("väga hea");
                    break;
                case "3":
                    Console.WriteLine("hea");
                    break;
                case "2":
                    Console.WriteLine("rahuldav")
                        break;
                case "1":
                    Console.WriteLine("uudulik");
                    break;
                default:
                    Console.WriteLine("puudulik");
            }
            Console.WriteLine("kena päeva!");
        }
    }
}
