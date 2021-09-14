using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Programm küsib kasutajat sisestada tema lemmikvärvi
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline" ;
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas" ;
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber" ;
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled ükssarvik" ;    

            Console.WriteLine("Sisesta oma lemmikvärv");
            string userColor = Console.ReadLine();

            switch (userColor) 
            {

                case "punane":
                    Console.WriteLine("oled romantiline");
                    break;
                case"sinine":
                        Console.WriteLine("oled töökas");
                    break;
                case "roheline":
                        Console.WriteLine("oled looduse sõber");
                    break;
                default:
                    Console.WriteLine("oled ükssarvik");
                    break;
                    

            }

            Console.WriteLine("Kena päeva!");       
        }

    }
}
