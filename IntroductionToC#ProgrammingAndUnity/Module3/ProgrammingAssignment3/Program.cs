﻿using System;
using ConsoleCards;

// IMPORTANT: Only add code in the section
// indicated below. The code I've provided
// makes your solution work with the 
// automated grader on Coursera

/// <summary>
/// Programming Assignment 3
/// </summary>
class Program
{
    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    /// <param name="args">command-line args</param>
    static void Main(string[] args)
    {
        // loop while there's more input
        string input = Console.ReadLine();
        while (input[0] != 'q')
        {

            // Add your code between this comment
            // and the comment below. You can of
            // course add more space between the
            // comments as needed

            // declare a deck variables and create a deck object
            // DON'T SHUFFLE THE DECK
            Deck deck = new Deck();

            // deal 2 cards each to 4 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card Player1Card1 = deck.TakeTopCard();
            Card Player2Card1 = deck.TakeTopCard();
            Card Player3Card1 = deck.TakeTopCard();
            Card Player4Card1 = deck.TakeTopCard();
            Card Player1Card2 = deck.TakeTopCard();
            Card Player2Card2 = deck.TakeTopCard();
            Card Player3Card2 = deck.TakeTopCard();
            Card Player4Card2 = deck.TakeTopCard();


            // deal 1 more card to players 2 and 3
            Card Player2Card3 = deck.TakeTopCard();
            Card Player3Card3 = deck.TakeTopCard();

            // flip all the cards over
            Player1Card1.FlipOver();
            Player2Card1.FlipOver();
            Player3Card1.FlipOver();
            Player4Card1.FlipOver();
            Player1Card2.FlipOver();
            Player2Card2.FlipOver();
            Player3Card2.FlipOver();
            Player4Card2.FlipOver();
            Player2Card3.FlipOver();
            Player3Card3.FlipOver();

            // print the cards for player 1
            Console.WriteLine(Player1Card1.Rank + "," + Player1Card1.Suit);
            Console.WriteLine(Player1Card2.Rank + "," + Player1Card2.Suit);

            // print the cards for player 2
            Console.WriteLine(Player2Card1.Rank + "," + Player2Card1.Suit);
            Console.WriteLine(Player2Card2.Rank + "," + Player2Card2.Suit);
            Console.WriteLine(Player2Card3.Rank + "," + Player2Card3.Suit);

            // print the cards for player 3
            Console.WriteLine(Player3Card1.Rank + "," + Player3Card1.Suit);
            Console.WriteLine(Player3Card2.Rank + "," + Player3Card2.Suit);
            Console.WriteLine(Player3Card3.Rank + "," + Player3Card3.Suit);

            // print the cards for player 4
            Console.WriteLine(Player4Card1.Rank + "," + Player4Card1.Suit);
            Console.WriteLine(Player4Card2.Rank + "," + Player4Card2.Suit);

            // Don't add or modify any code below
            // this comment
            input = Console.ReadLine();
        }
    }
}