using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }
        private Random random;

        public Playlist(Song firstSong)
        {
            Id = Guid.NewGuid();
            Songs = new List<Song>();
            random = new();
            AddSong(firstSong);
        }

        public void AddSong(Song song)
        {
            if (song != null)
                Songs.Add(song);
        }
        public string GetSongs()
        {
            return string.Join("\n", Songs.Select(x => $"{x.Title} - {x.Composer}"));
        }


        public void ShuffleSongs()
        {
            int n = Songs.Count;

            while (n > 0)
            {
                n--;
                Song song = Songs[n];
                int randomIndex = random.Next(n);
                Songs[n] = Songs[randomIndex];
                Songs[randomIndex] = song;
            }
        }
    }
}
