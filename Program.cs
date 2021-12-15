using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGamesList = new List<string>()
            {
                "Halo",
                "Rust",
                "Doom Eternal",
                "Pub G",
                "GTA"
            };

            var gamesListOrdered = videoGamesList.OrderBy(name => name.Length).ToList();

            //foreach (var gameName in gamesListOrdered)
            //{
            //    Console.WriteLine(gameName);
            //}

            gamesListOrdered.ForEach(game => Console.WriteLine(game));
        }
    }
}
