using System;
using System.Collections.Generic;

namespace CardDealer
{

    public class Deck
    {
        List<int> deck = new List<int>();

        // Initialize deck with values 1 - 52
        public Deck()
        {
            for(int i = 1; i < 53; i++)
            {
                deck.Add(i);
            }
        }

        // Deals one card to a player and removes it from the deck
        public int Deal()
        {
            Random rand = new Random();
            int index = 0, result = 0;

            // Choose a random index between 0 and number of cards remaining
            index = rand.Next(0, deck.Count-1);

            result = deck[index];

            // remove chosen card from the deck
            deck.RemoveAt(index);

            // return that card to player
            return result;
        } 

        // Print remaining cards in deck
        public void Print()
        {
            Console.WriteLine();
            for(int j = 0; j < deck.Count; j++)
            {
                Console.Write(deck[j] + " ");
            }
            Console.WriteLine("\nCount = " + deck.Count);
        }
    }
}
