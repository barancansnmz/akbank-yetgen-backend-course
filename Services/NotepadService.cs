

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotify.Entities;

namespace Spotify.Services
{
    internal class NotepadService
    {
        public void WriteToNotepad(Playlist playlist)
        {
            // Saving To Notepad...
            string directory = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Playlists";

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");
            File.WriteAllText(saveFile, playlist.GetSongs());
            Console.WriteLine("Data Successfully Saved to Notepad!");
        }
    }
}
