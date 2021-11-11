using System;
using System.Windows.Forms;
using MusicList.Controller;
using MusicList.Models;

namespace MusicList
{
    public partial class AddEditForm : Form
    {

        MusicController controller;
        public int id;

        public AddEditForm(MusicController controller, int id)
        {
            this.id = id;
            this.controller = controller;
            if(id != -1)
            {
                addButton.Text = "Módosítás";
            }
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string artist = artistTextBox.Text;
            int publishYear = (int)publishYearInput.Value;
            int musicLength = (int)lengthInput.Value;
            int priority = (int)priorityInput.Value;
            if (title == string.Empty || artist == string.Empty)
                return;
            if (id == -1)
            {
                MusicView music = new MusicView(title, artist, publishYear, musicLength, priority);
                controller.AddMusic(music);
            } else
            {
                Music music = new Music(id, title, artist, publishYear, musicLength, priority);
                controller.ModifyMusic(music);
            }

        }
    }
}
