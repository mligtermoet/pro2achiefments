using System;
using System.Collections;
using System.Collections.Generic;
namespace To_Display_or_to_insert
{
    class Program
    {
        public static ArrayList lijst = new ArrayList();
        static void Main(string[] args)
        {

            bool isGameRunning = true;
            //int aantal = 0;

            while (isGameRunning == true)
            {
                
                Console.Clear();
                Console.WriteLine("Wil jij de lijst invullen of weergeven?");
                Console.WriteLine("Typ: Invullen om de lijst in te vullen. Typ: Weergeven om de lijst weer te geven.");
                Console.WriteLine("");

                string input = Console.ReadLine();
                if (input == "Invullen" || input == "invullen")
                {
                    Console.Clear();
                    Console.WriteLine("Hoeveel namen wil jij invullen?");
                    int aantal = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    
                    for (int i = 0; i < aantal; i++)
                    {
                        Console.WriteLine("Typ nu steeds 1 naam en druk op Enter");
                        input = Console.ReadLine();
                        lijst.Add(input);
                        Console.Clear();
                    }
                    
                } else if (input == "Weergeven" || input == "weergeven")
                {
                    foreach(String s in lijst)
                    {
                        Console.WriteLine(s);
                        
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Druk op een knop om terug naar het menu te gaan.");
                    Console.ReadKey();
                }

                if (input == "exit") {
                    isGameRunning = false;
                }
            }
        }
    }
}
