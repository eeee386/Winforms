using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicList.Models
{
    public class Music
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public int publishYear { get; set; }
        public int length { get; set; }
        public int priority { get; set; }

        public Music(int iD, string title, string artist, int publishYear, int length, int priority)
        {
            ID = iD;
            this.title = title;
            this.artist = artist;
            this.publishYear = publishYear;
            this.length = length;
            this.priority = priority;
        }

        public Music()
        {
        }

        public Music(MusicView music)
        {
            ID = -1;
            title = music.title;
            artist = music.artist;
            publishYear = music.publishYear;
            length = music.length;
            priority = music.priority;
        }
    }
}
