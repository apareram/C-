using System;

namespace IntDataTypes{
    /// <summary>
    /// Integer Data Types lecture code
    /// </summary>
    internal class Program{
        /// <summary>
        /// Demonstrates data types
        /// </summary>
        /// <param name="args">command-lines args (utiles con batchs)</param>
        static void Main(string[] args){
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;
            
            /// calculates minutes and seconds played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;

            /// prints minutes and seconds
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);
        }
    }
}