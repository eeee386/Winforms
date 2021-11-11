using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicList.Models
{
    public class MusicView
    {
        public string title { get; set; }
        public string artist { get; set; }
        public int publishYear { get; set; }
        public int length { get; set; }
        public int priority { get; set; }

        public MusicView(Music music)
        {
            this.title = music.title;
            this.artist = music.artist;
            this.publishYear = music.publishYear;
            this.length = music.length;
            this.priority = music.priority;
        }

        public MusicView(string title, string artist, int publishYear, int length, int priority)
        {
            this.title = title;
            this.artist = artist;
            this.publishYear = publishYear;
            this.length = length;
            this.priority = priority;
        }
    }
}
