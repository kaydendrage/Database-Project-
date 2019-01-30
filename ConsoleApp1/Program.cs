using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> Deck = new List<String>();
            while (true)
            {


                Console.WriteLine("Manage Deck, add, remove, view.");
                String command = Console.ReadLine();
                if (command == "add")
                {
                    Console.WriteLine("What is the Card?");
                    String name = Console.ReadLine();
                    Deck.Add (name);
                    Console.WriteLine("Card was added to Deck");
                }
                if (command == "remove")
                {
                    Console.WriteLine("What is the Card?");
                    String name = Console.ReadLine();
                    if (Deck.Contains(name))
                    {
                        Deck.Remove(name);
                        Console.WriteLine("Card was removed from Deck");
                        Console.WriteLine(Deck.Contains(name));
                    }
                    else
                        Console.WriteLine("Not found."); 
                }
                if (command == "view")
                {
                    Deck.ForEach(el => Console.WriteLine(el));
                }
            }

        }

    }
}
