using KSWplayer.Properties;
using System.Drawing;
using System.IO;

namespace KSWplayer
{
    internal class MetadataReader
    {
        public MetadataReader() { }


        /*  Funkcja odpowiadająca za aktualizację ikonki aktualnie odtwarzanego utowru
            Obraz pobierany jest z metadanych zapisanych w pliku muzycznym.
            Pobrane informacje o pliku za pomocą strumienia danych (MemoryStream) przekazywane są do obiektu BitMap'y
        */
        public Bitmap ImageFromAudioFile(string filename, int Width, int Height)
        {
            var track = TagLib.File.Create(filename);
            if (track.Tag.Pictures.Length > 0)
            {
                MemoryStream ms = new MemoryStream(track.Tag.Pictures[0].Data.Data);
                ms.Seek(0, SeekOrigin.Begin);
                Bitmap bmp = new Bitmap(ms);
                var resizeBmp = new Bitmap(bmp, Width, Height);
                return resizeBmp;
            }
            return Resources.DefaultTrackImage;
        }
    }
}
