using System;
using System.Collections.Generic;
using System.Text;

namespace KillImagineDragons
{
    class Song
    {
        //properties
        public string Artist { get; set; }
        public string Name { get; set; }

        //Constructors
        public Song(string artist, string name)
        {
            Artist = artist;
            Name = name;
        }
    }
}
