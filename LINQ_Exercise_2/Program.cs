using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameList = new List<string>
            {
                "Halo",
                "Bioshock",
                "Mario",
                "Dead Space",
                "Apex Legends",
                "Pokemon",
                "Metal Gear Solid"
            };

            var sortedList = gameList.OrderBy(str => str.Length);

            foreach (var game in sortedList)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine();

            //for (int i = 0; i < sortedList.Count(); i++)
            //{
            //    Console.WriteLine();       * How do I access the strings within sortedList? *
            //}
        }
    }
}
