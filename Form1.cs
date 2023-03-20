using System;
using System.Windows.Forms;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace KSWplayer
{
    public partial class Form1 : Form
    {
        private MetadataReader metadataReader;
        private WaveOut player;
        private AudioFileReader audioFileReader;
        Playlist playlist = Playlist.GetInstance();

        private string fileName;
        string[] paths;
        private Action<float> setVolumeDelegate;

        public Form1()
        {
            InitializeComponent();
            metadataReader = new MetadataReader();

            if (player == null)
            {
                player = new WaveOut();
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            

            if (track_list.SelectedIndex >= 0 && player.PlaybackState == PlaybackState.Paused)
            {
                player.Play();
                return;
            }

            if (track_list.Items.Count == 0) 
            {
                btn_open_Click(sender, e);
            }

            if (track_list.SelectedIndex == -1)
            {
                track_list.SelectedIndex = 0;
                fileName = paths[0];
            }
            else 
            {
                fileName = paths[track_list.SelectedIndex];
            }

            if (player != null && player.PlaybackState == PlaybackState.Playing) { 
                player.Stop();
                player = null;
            }
            

            if (String.IsNullOrEmpty(fileName))
            {
                return;
            }
            
            if (player.PlaybackState == PlaybackState.Paused) 
            {
                player.Resume();
                return;
            }
            
            audioFileReader = new AudioFileReader(fileName);
            player.Init(audioFileReader);
            player.Play();
            
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0 && player.PlaybackState == PlaybackState.Playing)
            {
                player.Pause();
                return;
            }
            if (track_list.SelectedIndex >= 0 && player.PlaybackState == PlaybackState.Paused)
            {
                player.Play();
                return;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (player != null && player.PlaybackState == PlaybackState.Playing)
            {
                player.Stop();
            }          
        }


        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                paths = ofd.FileNames;
                for (int i = 0; i < paths.Length; i++)
                {
                    track_list.Items.Add(paths[i]);
                    //playlist.addSongToPlaylist(paths[i]);
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
                btn_play_Click(sender, e);
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
                btn_play_Click(sender, e);
            }
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            float glosnosc = track_volume.Value;
            player.Volume = (float)(glosnosc * 0.01);
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = metadataReader.ImageFromAudioFile(paths[track_list.SelectedIndex], pictureBox1.Width, pictureBox1.Height);
        }
    }


}
