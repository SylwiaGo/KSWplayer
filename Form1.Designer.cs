namespace KSWplayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.track_list = new System.Windows.Forms.ListBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.waveformPainter1 = new NAudio.Gui.WaveformPainter();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_open
            // 
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.btn_open.Location = new System.Drawing.Point(570, 322);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(52, 27);
            this.btn_open.TabIndex = 11;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.btn_stop.Location = new System.Drawing.Point(432, 322);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(99, 27);
            this.btn_stop.TabIndex = 10;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.btn_pause.Location = new System.Drawing.Point(327, 322);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(99, 27);
            this.btn_pause.TabIndex = 9;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.btn_play.Location = new System.Drawing.Point(222, 322);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(99, 27);
            this.btn_play.TabIndex = 8;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.btn_next.Location = new System.Drawing.Point(117, 322);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(99, 27);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.btn_preview.Location = new System.Drawing.Point(12, 322);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(99, 27);
            this.btn_preview.TabIndex = 6;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.track_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 15;
            this.track_list.Location = new System.Drawing.Point(218, 90);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(328, 195);
            this.track_list.TabIndex = 12;
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(552, 101);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(45, 161);
            this.track_volume.TabIndex = 13;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // p_bar
            // 
            this.p_bar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.p_bar.Location = new System.Drawing.Point(12, 302);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(610, 11);
            this.p_bar.TabIndex = 14;
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.lbl_track_start.Location = new System.Drawing.Point(12, 9);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(107, 37);
            this.lbl_track_start.TabIndex = 15;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.lbl_track_end.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.lbl_track_end.Location = new System.Drawing.Point(515, 9);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(107, 37);
            this.lbl_track_end.TabIndex = 16;
            this.lbl_track_end.Text = "00:00";
            // 
            // waveformPainter1
            // 
            this.waveformPainter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.waveformPainter1.Location = new System.Drawing.Point(138, 9);
            this.waveformPainter1.Name = "waveformPainter1";
            this.waveformPainter1.Size = new System.Drawing.Size(339, 75);
            this.waveformPainter1.TabIndex = 17;
            this.waveformPainter1.Text = "waveformPainter1";
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.volumeMeter1.Location = new System.Drawing.Point(603, 101);
            this.volumeMeter1.MaxDb = 18F;
            this.volumeMeter1.MinDb = -60F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(19, 154);
            this.volumeMeter1.TabIndex = 18;
            this.volumeMeter1.Text = "volumeMeter1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.volumeMeter1);
            this.Controls.Add(this.waveformPainter1);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "KSWplayer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private NAudio.Gui.WaveformPainter waveformPainter1;
        private NAudio.Gui.VolumeMeter volumeMeter1;
    }
}

