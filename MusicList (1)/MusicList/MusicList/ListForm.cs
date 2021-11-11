using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicList.Controller;
using MusicList.DAO;
using MusicList.Models;

namespace MusicList
{
    public partial class ListForm : Form
    {

        public MusicController controller;
        public ListForm(MusicController cont)
        {
            controller = cont;
            InitializeComponent();
        }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            var musics = controller.GetAllMusic();
            var viewModels = new List<MusicView>();
            foreach (var item in musics)
                viewModels.Add(new MusicView(item));
            musicListGrid.DataSource = null;
            musicListGrid.DataSource = viewModels;
            musicListGrid.Visible = true;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            Form form = new AddEditForm(controller, -1);
            form.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var musics = controller.GetAllMusic();
            var viewModels = new List<MusicView>();
            foreach (var item in musics)
                viewModels.Add(new MusicView(item));
            musicListGrid.DataSource = null;
            musicListGrid.DataSource = viewModels;
            musicListGrid.Visible = true;
        }

        private void modifyMusicClick(object sender, EventArgs e)
        {
            if (!(musicListGrid.CurrentRow.DataBoundItem is Music music))
                return;
            Form form = new AddEditForm(controller, music.ID);
            form.Show();
        }
    }
}
