using System;

namespace Achievement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string a;
            Console.WriteLine("Wat is jou naam?");
            a = Console.ReadLine();

            Console.Clear();

            string b;
            Console.WriteLine("Hoe oud ben jij?");
            b = Console.ReadLine();

            Console.Clear();

            string c;
            Console.WriteLine("Wat is de kleur van jou ogen?");
            c = Console.ReadLine();

            Console.Clear();

            string d;
            Console.WriteLine("Wat is jou postcode?");
            d = Console.ReadLine();

            Console.Clear();

            string e;
            Console.WriteLine("Wat is jou woonplaats?");
            e = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Hallo, leuk om jou te zien {0}.", a);
            Console.WriteLine("Ik zie dat jij {0} jaar bent.", b);
            Console.WriteLine("{0} is echt een mooie kleur van jou ogen.", c);
            Console.WriteLine("Ik zie dat jij in {0} woont", e);
            Console.WriteLine("en dat jou postcode: {0} is.", d);
        }
    }
}
