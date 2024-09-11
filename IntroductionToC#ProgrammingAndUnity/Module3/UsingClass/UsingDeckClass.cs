using System;

namespace UsingDeckClass{
    /// <summary>
    /// Class and objects lecture code
    /// </summary>
    internal class Program{
        /// <summary>
        /// Demonstrates using a deck og cards 
        /// </summary>
        /// <param name="args">command-lines args</param>
        static void Main(string[] args){
            // declare and print a deck of cards
            Deck deck = new Deck();
            deck.Print();

            // acsses and print empty property
            // bool isEmpty = deck.Empty;
            // Console.WriteLine("Deck empty: " + isEmpty);
            // Console.WriteLine("Deck empty: " + deck.Empty);

            // shuffle and print deck
            // Console.WriteLine();
            // deck.Shuffle();
            // deck.Print();

            // cut and print deck
            // Console.WriteLine();
            // deck.Cut(26);
            // deck.Print();

            // take and print the top card from the deck
            Console.WriteLine();
            deck.TakeTopCard(); // not storing it anywhere is like trhowing the card away
            Card card = deck.TakeTopCard();
            Console.WriteLine(card.Rank + " of " + card.Suit);
        }
    }
}