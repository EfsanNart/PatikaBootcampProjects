using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikafyMusicPlatform
{
    internal class Artist
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int ReleaseYear { get; set; }
        public int AlbumSales { get; set; }

        public Artist(string name , string type, int releaseYear, int albumSales)
        {
            Name = name;
            Type = type;
            ReleaseYear = releaseYear;
            AlbumSales = albumSales;
        }
    }
}
