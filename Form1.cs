using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using FontAwesome.Sharp;
using NAudio.CoreAudioApi;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Label = System.Windows.Forms.Label;

namespace KSWplayer
{
    public partial class Form1 : Form
    {
        private MetadataReader metadataReader;
        private WaveOut player;
        private AudioFileReader audioFileReader;
        Playlist playlist = Playlist.GetInstance();
        string selectedSong;
        bool isMoving = false;
        int moveX;
        int moveY;
        bool isLoopAll = false;
        bool isLoopOne = false;
        bool isRandom = false;
        private string fileName;
        string[] paths;
        private Action<float> setVolumeDelegate;
        Color cPink = Color.FromArgb(227, 42, 112);
        Color cYellow = Color.FromArgb(246, 190, 19);
        Color myColor;
        List<IconPictureBox> buttons = new List<IconPictureBox>();
        List<Label> labels = new List<Label>();

        public Form1()
        {
            InitializeComponent();
            myColor = cPink;
            metadataReader = new MetadataReader();
            myTrack_volume.Value = 50;
            p_bar.ForeColor = myColor;
            p_bar_vol_vert.ForeColor = myColor;
            buttons.Add(ic_open);
            buttons.Add(ic_play);
            buttons.Add(ic_pause);
            buttons.Add(ic_stop);
            buttons.Add(ic_close);
            buttons.Add(ic_preview);
            buttons.Add(ic_next);
            buttons.Add(ic_loop);
            buttons.Add(ic_repeat1);
            buttons.Add(ic_random);
            buttons.Add(ic_color);
            buttons.Add(ic_minim);
            buttons.Add(ic_info);

            labels.Add(lbl_track_start);
            labels.Add(lbl_track_end);
            labels.Add(lbl_volume);
            labels.Add(lbl_v);


            if (player == null)
            {
                player = new WaveOut();
            }

            track_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.track_list_DrawItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ustawienie pozycji startowej okienka na centralna
            int myWidth = Screen.PrimaryScreen.WorkingArea.Size.Width;
            int myHeight = Screen.PrimaryScreen.WorkingArea.Size.Height;
            this.Location = new System.Drawing.Point(myWidth/2-this.Size.Width/2, myHeight/2-this.Size.Height/2);
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSong = playlist.getSongs()[track_list.SelectedIndex].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.PlaybackState == PlaybackState.Playing && audioFileReader != null)
            {
                TimeSpan currentTime = (player.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : audioFileReader.CurrentTime;
                TimeSpan totalTime = audioFileReader.TotalTime;
                

                p_bar.Maximum = (int)(totalTime.TotalMinutes*60 + totalTime.TotalSeconds);
                int pBarValue = (int)(currentTime.TotalMinutes * 60 + currentTime.TotalSeconds);
                //kiedy pasek postepu osiaga wartość maksymalną przeskakuje do nastepnej piosenki
                if (p_bar.Maximum > pBarValue)
                {
                    p_bar.Value = pBarValue;
                }
                else
                {
                    if (isLoopOne)
                    {
                        ic_play_Click(sender, e);
                    }
                    else 
                    {
                        ic_next_Click(sender, e);
                    }
                }

                lbl_track_start.Text = String.Format("{0:00}:{1:00}", (int)currentTime.TotalMinutes, currentTime.Seconds);
                lbl_track_end.Text = String.Format("{0:00}:{1:00}", (int)totalTime.TotalMinutes, totalTime.Seconds);
            }

            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDevice device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            p_bar_vol_vert.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            if (audioFileReader != null) 
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(audioFileReader.TotalTime.TotalSeconds * e.X / p_bar.Width);
            }
        }

        private void track_list_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) 
            {
                return;
            }

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(0, 0, 0));//kolor zaznaczenia
            }
                
            e.DrawBackground();

            SolidBrush fontBrush = new SolidBrush(Color.FromArgb(227, 42, 112));

            e.Graphics.DrawString(track_list.Items[e.Index].ToString(), e.Font, fontBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void myTrack_volume_Scroll(object sender, EventArgs e)
        {
            float glosnosc = myTrack_volume.Value;
            player.Volume = (float)(glosnosc * 0.01);
            lbl_volume.Text = myTrack_volume.Value.ToString() + "%";
        }

        private void panel_m_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            moveX = e.X;
            moveY = e.Y;
        }

        private void panel_m_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving) 
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel_m_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayIcon.Icon = this.Icon;
                trayIcon.Text = "PlayerKSW";
                trayIcon.Visible = true;
            }
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        private void track_list_DoubleClick(object sender, EventArgs e)
        {
            if (track_list.SelectedItem == null) 
            {
                return;
            }
            selectedSong = playlist.getSongs()[track_list.SelectedIndex].ToString();
            this.ic_play_Click(sender, e);

        }

        private void ic_play_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0 && player.PlaybackState == PlaybackState.Paused)
            {
                player.Play();
                return;
            }

            if (track_list.Items.Count == 0)
            {
                ic_open_Click(sender, e);
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

            if (player != null && player.PlaybackState == PlaybackState.Playing)
            {
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
            pictureBox1.Image = metadataReader.ImageFromAudioFile(selectedSong, pictureBox1.Width, pictureBox1.Height);
        }

        private void ic_next_Click(object sender, EventArgs e)
        {
            if (isRandom) 
            {
                int randomSong = chooseRandomSong();
                track_list.SelectedIndex = randomSong;
                ic_play_Click(sender, e);
                return;
            }
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
                ic_play_Click(sender, e);
            }
            else if (track_list.SelectedIndex == track_list.Items.Count -1 && isLoopAll)
            {
                track_list.SelectedIndex = 0;
                ic_play_Click(sender, e);
            }
        }

        private int chooseRandomSong() 
        {
            Random random = new Random();
            int randomSong = random.Next(0, track_list.Items.Count);

            return randomSong;

        }

        private void ic_pause_Click(object sender, EventArgs e)
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

        private void ic_preview_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
                ic_play_Click(sender, e);
            }
        }

        private void ic_stop_Click(object sender, EventArgs e)
        {
            if (player != null && player.PlaybackState == PlaybackState.Playing)
            {
                player.Stop();
            }
        }

        private void ic_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                paths = ofd.FileNames;
                for (int i = 0; i < paths.Length; i++)
                {
                    string songNameFromMD = metadataReader.SongNameFromAudioFile(paths[i]);
                    if (songNameFromMD != null)
                    {
                        track_list.Items.Add(i + 1 + ". " + songNameFromMD);
                    }
                    else
                    {
                        string songName = Path.GetFileName(paths[i]);
                        track_list.Items.Add(songName);
                    }


                    playlist.addSongToPlaylist(paths[i].ToString());
                }
            }
        }

        private void ic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ic_minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ic_loop_Click(object sender, EventArgs e)
        {
            isLoopAll = !isLoopAll;
            if (isLoopAll)
            {
                changeStatusLoopOne(false, myColor);
                changeStatusLooAll(true, Color.White);
            }
            else
            {
                changeStatusLooAll(false, myColor);
            }
        }

        private void ic_repeat1_Click(object sender, EventArgs e)
        {
            isLoopOne = !isLoopOne;
            if (isLoopOne)
            {
                changeStatusLooAll(false, myColor);
                changeStatusLoopOne(true, Color.White);
            }
            else
            {
                changeStatusLoopOne(false, myColor);
            }
        }

        private void changeStatusLooAll(bool isActive, Color color)
        {
            isLoopAll = isActive;
            ic_loop.ForeColor = color;
        }

        private void changeStatusLoopOne(bool isActive, Color color)
        {
            isLoopOne = isActive;
            ic_repeat1.ForeColor = color;
        }

        private void ic_random_Click(object sender, EventArgs e)
        {
            isRandom = !isRandom;
            if(isRandom)
            {
                ic_random.ForeColor = Color.White;
            }
            else
            {
                ic_random.ForeColor = myColor;
            }    
            
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            string message = ".NET Platform Project\nUniversity of Zielona Gora 2023\ncreated by Sylwia Gornicz, Wiktor Jablonki, Kacper Kuczminski\nhttps://github.com/SylwiaGo/KSWplayer";
            System.Windows.Forms.MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ic_color_Click(object sender, EventArgs e)
        {
            if (myColor == cPink) 
            {               
                myColor = cYellow;

            } else
            {
                myColor = cPink;
            }
            p_bar.ForeColor = myColor;
            p_bar_vol_vert.ForeColor = myColor;
            foreach (IconPictureBox button in buttons) { button.ForeColor = myColor; }
            foreach(Label label in labels) { label.ForeColor = myColor;}

        }
    }
}
