using System;

namespace ReadingDocumentation{
    /// <summary>
    /// Reading Documentation lecture code
    /// </summary>
    internal class Program{
        /// <summary>
        /// Demonstrates reading documentation
        /// </summary>
        /// <param name="args">command-lines args</param>
        static void Main(string[] args){
            // calculate the cosine of 45 degrees
            // float cosine = (float)Math.Cos(45 * Math.PI / 180);
            float cosine = MathF.Cos(45 * MathF.PI / 180);
            Console.WriteLine("Cosine of 45: " + cosine);
        }
    }
}