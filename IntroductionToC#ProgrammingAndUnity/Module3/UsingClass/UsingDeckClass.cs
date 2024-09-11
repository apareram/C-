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
            // deck.Print();

            // acsses and print empty property
            // bool isEmpty = deck.Empty;
            // Console.WriteLine("Deck empty: " + isEmpty);
            Console.WriteLine("Deck empty: " + deck.Empty);
        }
    }
}