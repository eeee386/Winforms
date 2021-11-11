using System.Collections.Generic;
using MusicList.Models;

namespace MusicList.DAO
{
    public interface IMusicDAO
    {

        public bool AddMusic(MusicView music);
        public bool ModifyMusic(Music music);
        public Music GetMusicById(int ID);
        public List<Music> GetAllMusic();
    }
}
