using System;

namespace one_list_to_list
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"GTA V","Pavlov VR","Roblox","Minecraft","Beatsaber","Call of Duty",
            "Clash of Clans","Firewatch","RDR2","Project Cars 2"};

            Console.Clear();

            Console.WriteLine("10 games die ik speel:");
            Console.WriteLine("");

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
