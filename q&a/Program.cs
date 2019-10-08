using System;

namespace q_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();





            string a;
            Console.WriteLine("Wat doe jij graag in je vrije tijd?");
            a = Console.ReadLine();

            Console.Clear();

            string b;
            Console.WriteLine("Welke game speel je veel?");
            b = Console.ReadLine();

            Console.Clear();
            
            string c;
            Console.WriteLine("Wat eet jij graag?");
            c = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("{0}", a);
            Console.WriteLine("De game die ik graag speel is: {0}.", b);
            Console.WriteLine("Wat ik graag eet is: {0}", c);

        }
    }
}
