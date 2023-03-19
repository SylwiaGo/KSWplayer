using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace KSWplayer
{
    public partial class Form1 : Form
    {
        private WaveOut player = new WaveOut();
        private AudioFileReader audioFileReader;
        private string fileName;
        string[] paths, files;
        private Action<float> setVolumeDelegate;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            fileName = paths[track_list.SelectedIndex];

            if (String.IsNullOrEmpty(fileName))
            {
                return;
            }

            audioFileReader = new AudioFileReader(fileName);

            player.Dispose();
            player = new WaveOut();
            player.Init(audioFileReader);
            player.Play();
            
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (player.PlaybackState == PlaybackState.Playing)
            {
                player.Dispose();
                player.Pause();
            } 

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    track_list.Items.Add(files[i]);
                }
            }
        }
    }
}
