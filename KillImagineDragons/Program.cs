using System;
using System.Collections.Generic;
using System.Linq;

namespace KillImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>();

            allSongs.Add(new Song("Imagine Dragon", "Bleeding Out"));
            allSongs.Add(new Song("Imagine Dragon", "Whatever It Takes"));
            allSongs.Add(new Song("Imagine Dragon", "Friction"));
            allSongs.Add(new Song("Imagine Dragon", "Amsterdam"));
            allSongs.Add(new Song("Imagine Dragon", "Believer"));
            allSongs.Add(new Song("Imagine Dragon", "Walking The Wire"));
            allSongs.Add(new Song("Imagine Dragon", "It’s Time"));
            allSongs.Add(new Song("Ed Sheeran", "Shape of You"));
            allSongs.Add(new Song("Ray Charles ", "Georgia On My Mind "));
            allSongs.Add(new Song("Roy Orbison", "Oh Pretty Woman "));
            allSongs.Add(new Song("Dolly Parton", "I Will Always Love You"));
            allSongs.Add(new Song("The Turtles", " Happy Together "));

            goodSongs = allSongs.Where(song => song.Artist != "Imagine Dragon").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }

            Console.ReadLine();
        }
    }
}
