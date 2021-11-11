using System.Collections.Generic;
using MusicList.DAO;
using MusicList.Models;

namespace MusicList.Controller
{
    public class MusicController
    {
        public IMusicDAO dao;

        public MusicController(IMusicDAO dao)
        {
            this.dao = dao;
        }

        public bool AddMusic(MusicView music)
        {
            return dao.AddMusic(music);
        }

        public bool ModifyMusic(Music music)
        {
            return dao.ModifyMusic(music);
        }

        public Music GetMusicById(int id)
        {
            return dao.GetMusicById(id);
        }

        public List<Music> GetAllMusic()
        {
            return dao.GetAllMusic();
        }
    }
}
