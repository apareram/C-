using System;

namespace FloatingPointDataType{
    /// <summary>
    /// Floating Point Data Types lecture code
    /// </summary>
    internal class Program{
        /// <summary>
        /// Demonstrates floating point data types
        /// </summary>
        /// <param name="args">command-lines args</param>
        static void Main(string[] args){
            int score = 1360;
            int totalSecondsPlayed = 10000;

            // calculates and prints points per second
            float pointPerSecond = (float)score / totalSecondsPlayed; 
            // escribir (float) una vez hace que los dos se traten como flaot
            // no es necesario hacer el typecast a los dos
            Console.WriteLine("Points per second: " + pointPerSecond);
        }
    }
}