using System;

namespace C_
{
    //Class example
    public class Song
    {
        public string title, artist;
        public int duration;

        //static variable, applies to all "Song" objects
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration){
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
            Console.WriteLine("Total Song Count: " + songCount);
        }

    }


}