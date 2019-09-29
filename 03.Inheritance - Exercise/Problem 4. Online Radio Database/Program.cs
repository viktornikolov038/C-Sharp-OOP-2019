using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var allSongs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                var currentSongInput = Console.ReadLine().Split(';');
                var artistName = currentSongInput[0];
                var songName = currentSongInput[1];
                var timeInput = currentSongInput[2].Split(':');
                var minutes = int.Parse(timeInput[0]);
                var seconds = int.Parse(timeInput[1]);

                try
                {
                    var song = new Song(artistName,songName,minutes,seconds);
                    allSongs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }
            }

            var totalSecs = 0;

            foreach (Song song in allSongs)
            {
                totalSecs += song.TotalSeconds();
            }

            var time = TimeSpan.FromSeconds(totalSecs);
            Console.WriteLine($"Songs added: {allSongs.Count}");
            Console.WriteLine($"Playlist length: {time.Hours}h {time.Minutes}m {time.Seconds}s");
        }
    }
}
