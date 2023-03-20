using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSWplayer
{
    internal class Playlist
    {
        private static Playlist playlistInstance;

        private ArrayList songs = new ArrayList();
        private Playlist() { }


        public static Playlist GetInstance()
        {
            if(playlistInstance == null)
            {
                playlistInstance = new Playlist();
            }
            return playlistInstance;
        }

        //Zwrócenie aktualnej listy utworów przy pomocy ArrayListy
        public ArrayList getSongs()
        {
            return songs;
        }

        //Zamiana listy utworów na listę podaną w argumencie funkcji
        private void setSongs(ArrayList songsFromSource)
        {
            this.songs = songsFromSource;
        }

        public void addSongToPlaylist(string songPath)
        {
            songs.Add(songPath);
        }


        //Zamiana playlisty podanej w tablicy na playlistę w formacie ArrayList
        private void setSongs(string[] songsFromSource)
        {
            this.songs.Clear();
            for (int i = 0; i < songsFromSource.Length - 1; i++)
            {
                this.songs.Add(songsFromSource[i]);
            }
        }

        //Zapisanie playlisty utworów do pliku o nazwie podanej w argumencie
        public void savePlaylistToFile(string playlistFileName)
        {
            try
            {
                foreach (var song in songs)
                {
                    File.AppendAllText(playlistFileName + ".playlist", song.ToString() + "\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void loadPlaylistFromFile()
        {
            //TODO: WYKONAĆ POBIERANIE DANYCH Z PLIKU ORAZ ZASTĄPIENIE AKTUALNEJ PLAYLISTY TĄ Z PLIKU
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "*.playlist";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string dataFromFile = sr.ReadToEnd();
                    string[] sliceData = dataFromFile.Split('\n');
                    setSongs(sliceData);
                }
            }
        }
    }
}
