using System;
using System.Collections.Generic;

namespace CardDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            // Create players
            List<int> p1 = new List<int>();
            List<int> p2 = new List<int>();
            List<int> p3 = new List<int>();
            List<int> p4 = new List<int>();

            // Deal 4 cards to each player
            for (int i = 0; i < 4; i++)
            {
                p1.Add(deck.Deal());
                p2.Add(deck.Deal());
                p3.Add(deck.Deal());
                p4.Add(deck.Deal());
            }
            
            // Print each player's hand
            Console.Write("P1: ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(p1[j] + " ");
            }

            Console.WriteLine();
            Console.Write("P2: ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(p2[j] + " ");
            }

            Console.WriteLine();
            Console.Write("P3: ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(p3[j] + " ");
            }

            Console.WriteLine();
            Console.Write("P4: ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(p4[j] + " ");
            }

            // Print remaining deck to check there are no duplicates
            deck.Print();
        }
    }
}
