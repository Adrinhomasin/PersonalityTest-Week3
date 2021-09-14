using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Mis hinde sa said?");
            string number = Console.ReadLine();

            if (number == "5")
            {
                Console.WriteLine("suurepärane!");
            }
            else if (number == "4")
            {
                Console.WriteLine("Väga hea");
            }
            else if (number == "3")
            {
                Console.WriteLine("Hea");
            }                       
            else if (number == "2")
            {
                Console.WriteLine("rahuldav");
            }
            else if (number == "1")
            {
                Console.WriteLine("puudulik");
            }
            else
            {
                Console.WriteLine("puudulik");
            }

        }
    }
}
