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
        string selectedSong;

        private string fileName;
        string[] paths;
        private Action<float> setVolumeDelegate;

        public Form1()
        {
            InitializeComponent();
            metadataReader = new MetadataReader();
            track_volume.Value = 50;

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
                fileName = selectedSong;
            }

            if (player != null && player.PlaybackState == PlaybackState.Playing) { 
                player.Stop();
                player = null;
            }
            

            if (String.IsNullOrEmpty(fileName))
            {
                return;
            }

            if (player == null)
            {
                player = new WaveOut();
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
                    playlist.addSongToPlaylist(paths[i].ToString());
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
            lbl_volume.Text = track_volume.Value.ToString() + "%";
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSong = playlist.getSongs()[track_list.SelectedIndex].ToString();
            pictureBox1.Image = metadataReader.ImageFromAudioFile(selectedSong, pictureBox1.Width, pictureBox1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.PlaybackState == PlaybackState.Playing && audioFileReader != null)
            {
                TimeSpan currentTime = (player.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : audioFileReader.CurrentTime;
                TimeSpan totalTime = audioFileReader.TotalTime;

                //p_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                //p_bar.Value = (int)player.Ctlcontrols.currentPosition;
                try
                {
                    lbl_track_start.Text = String.Format("{0:00}:{1:00}", (int)currentTime.TotalMinutes, currentTime.Seconds);
                    lbl_track_end.Text = String.Format("{0:00}:{1:00}", (int)totalTime.TotalMinutes, totalTime.Seconds);
                }
                catch
                {

                }
            }
        }
    }
}
