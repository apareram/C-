using System;

namespace IfStatements
{
    /// <summary>
    /// If Statements lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates various forms of if statements
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // prompt for and get user input
            Console.Write("Pick up the shiny thing? (1 for yes, 2 for no): ");
            int answer = int.Parse(Console.ReadLine());

            // print appropriate message
            if ( answer == 1 )
            {
                Console.WriteLine("You have the shiny thing");
            }
            else if ( answer == 2 )
            {
                Console.WriteLine("You don't have the shiny thing");
            }
            else
            {
                Console.WriteLine("Invalid input, dork!");
            }
        }
    }
}
