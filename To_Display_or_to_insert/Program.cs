using System;

namespace To_Display_or_to_insert
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isGameRunning = true;
            //int aantal = 0;

            while (isGameRunning == true)
            {
                AGAIN:
                Console.Clear();
                Console.WriteLine("Wil jij de lijst invullen of weergeven?");
                Console.WriteLine("Typ: Invullen om de lijst in te vullen. Typ: Weergeven om de lijst weer te geven.");
                string input = Console.ReadLine();
                if (input == "Invullen" || input == "invullen")
                {
                    Console.Clear();
                    Console.WriteLine("HI");
                    Console.ReadLine();
                } else if (input == "Weergeven" || input == "weergeven")
                {

                } else
                {
                    goto AGAIN;
                }
            }
        }
    }
}
