using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MMPlayer
{
    public partial class MainView : Form
    {
        private Player player;
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        public MainView()
        {
            InitializeComponent();
        }

        private void PlayPause_Click(object sender, EventArgs e)
        {
            if (player.isPlaying)
            {
                player.Pause();
            }
            else
            {
                player.Play();
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK && 
                !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                player = new Player(files);
            }
        }

        private void onVolumeChange(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            player.setVolume(trackBar.Value);
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            player.Next();
        }

        private void Revert_Click(object sender, EventArgs e)
        {
            player.Previous();
        }
    }
}
