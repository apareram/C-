using System;

namespace Exercise6
{
    /// <summary>
    /// Solution for Exercise 6
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Propts for an angle, calculates its cosine and prints it
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            /// prompts for and reads the angle
            Console.Write("Enter angle in degrees: ");
            float angle = float.Parse(Console.ReadLine()); 
            // converts the angle and calculates the cosine and sin
            float cosine = MathF.Cos(angle * MathF.PI / 180);
            float sine = MathF.Sin(angle * MathF.PI / 180);
            /// prints the cosine and sine of the angle
            Console.WriteLine("Cosine of " + angle + " degrees: " + cosine);
            Console.WriteLine("Sine of " + angle + " degrees: " + sine);
        }
    }
}