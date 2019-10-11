using System;
using System.Threading;

namespace If_Only_That_Were_True
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();



            Console.WriteLine("Welkom bij de ja of nee quiz. Tijdens deze quiz kan je alleem met Ja of Nee antwoorden. Alle andere woorden worden genegeerd.");
            Console.WriteLine("Typ: start om te beginnen.");
            goto test;

            test:
                String start = Console.ReadLine();
                if (start == "Start" || start == "start")
                {
                        Console.Clear();
                        Console.WriteLine("Vraag 1: Vind jij school leuk?");
                        Console.WriteLine("Typ ja of nee");
                goto vraag1;
            vraag1:
                String vraag1 = Console.ReadLine();
                
                if (vraag1 == "Ja" && vraag1 == "Ja" || vraag1 == "ja")
                {
                    Console.Clear();
                    Console.WriteLine("Top!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Vraag 2: Vind jij het leuk als je huiswerk krijgt?");
                    Console.WriteLine("Typ ja of nee");
                    goto vraag2;
                } else if (vraag1 == "nee" || vraag1 == "Nee")
                {
                    Console.Clear();
                    Console.WriteLine("Dat is vervelend!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Vraag 2: Vind jij het leuk als je huiswerk krijgt?");
                    Console.WriteLine("Typ ja of nee");
                    goto vraag2;
                } else
                {
                    Console.WriteLine("Let op: Je kan alleen met ja of nee antwoorden!");
                    goto vraag1;
                }
            vraag2:
                String vraag2 = Console.ReadLine();
                
                if (vraag2 == "Ja" || vraag2 == "ja")
                {
                    Console.Clear();
                    
                    Console.WriteLine("Top!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Vraag 3: Vind jij appeltaart lekker?");
                    Console.WriteLine("Typ ja of nee");
                    goto vraag3;
                }
                else if (vraag2 == "nee" || vraag2 == "Nee")
                {
                    Console.Clear();
                    Console.WriteLine("Ben ik het helemaal mee eens.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Vraag 3: Vind jij appeltaart lekker?");
                    Console.WriteLine("Typ ja of nee");
                    goto vraag3;
                }
                else
                {
                    Console.WriteLine("Let op: Je kan alleen met ja of nee antwoorden!");
                    goto vraag2;
                }
            vraag3:
                String vraag3 = Console.ReadLine();
                
                if (vraag3 == "Ja" || vraag3 == "ja")
                {
                    Console.Clear();
                    Console.WriteLine("Goedzo!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Vraag 4: Heb jij tot nu toe goede cijfers gehaald op school?");
                    Console.WriteLine("Typ ja of nee");
                    goto vraag4;
                }
                else if (vraag3 == "nee" || vraag3 == "Nee")
                {
                    Console.Clear();
                    Console.WriteLine("WAT? Hoe kan je appeltaart niet lekker vinden?");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Vraag 4: Heb jij tot nu toe goede cijfers gehaald op school?");
                    Console.WriteLine("Typ ja of nee");
                    goto vraag4;
                }
                else
                {
                    Console.WriteLine("Let op: Je kan alleen met ja of nee antwoorden!");
                    goto vraag3;
                }
            vraag4:
                String vraag4 = Console.ReadLine();
                
                if (vraag4 == "Ja" || vraag4 == "ja")
                {
                    Console.Clear();
                    Console.WriteLine("Goedzo! Blijf zo door gaan!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Goedzo, je hebt de vragenlijst afgerond!");
                    Console.WriteLine("Typ 'Exit' om deze applicatie meteen af te sluiten of typ 'Antwoorden' om jou ingevulde antwoorden te zien.");
                    goto finish;
                }
                else if (vraag4 == "nee" || vraag4 == "Nee")
                {
                    Console.Clear();
                    Console.WriteLine("Misschien een idee om beter je best te doen?.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Goedzo, je hebt de vragenlijst afgerond!");
                    Console.WriteLine("Typ 'Exit' om deze applicatie meteen af te sluiten of typ 'Antwoorden' om jou ingevulde antwoorden te zien.");
                    goto finish;
                }
                else
                {
                    Console.WriteLine("Let op: Je kan alleen met ja of nee antwoorden!");
                    goto vraag4;
                }
            finish:
                String finish = Console.ReadLine();
                if (finish == "Antwoorden" || finish == "antwoorden")
                {
                    Console.Clear();
                    Console.WriteLine("Antwoorden:");
                    Console.WriteLine("\nVraag 1: {0}", vraag1);
                    Console.WriteLine("Vraag 2: {0}", vraag2);
                    Console.WriteLine("Vraag 3: {0}", vraag3);
                    Console.WriteLine("Vraag 4: {0}", vraag4);
                } else if (finish == "Exit" || finish == "exit")
                {
                    Environment.Exit(0);
                } else
                {
                    Console.WriteLine("Kies uit 'Exit' of 'Antwoorden'");
                }
            } else
                {
                Console.WriteLine("Typ: start om te beginnen.");
                goto test;
                }


            
        }
    }
}
