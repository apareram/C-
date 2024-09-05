using System;

namespace Exercise3
{
    /// <summary>
    /// Solution for Exercise 3
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Prints age
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            /// prompts for the altitudes
            Console.Write("Enter altitude at first location:  ");
            /// reads, parses, and stores an altitude typed in by the user
            int firstAltitude = int.Parse(Console.ReadLine()); 

            Console.Write("Enter altitude at second location: ");
            int secondAltitude = int.Parse(Console.ReadLine());

            /// calculates the altitude change moving from the first point to the second point
            int altitudeChange = secondAltitude - firstAltitude;

            /// prints altitude change
            Console.Write("Altitude change: " + altitudeChange);
        }
    }
}