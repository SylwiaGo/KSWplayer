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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.track_list = new System.Windows.Forms.ListBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.waveformPainter1 = new NAudio.Gui.WaveformPainter();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.lbl_v = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.panel_m = new System.Windows.Forms.Panel();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ic_play = new FontAwesome.Sharp.IconPictureBox();
            this.ic_next = new FontAwesome.Sharp.IconPictureBox();
            this.ic_pause = new FontAwesome.Sharp.IconPictureBox();
            this.ic_preview = new FontAwesome.Sharp.IconPictureBox();
            this.ic_stop = new FontAwesome.Sharp.IconPictureBox();
            this.ic_loop = new FontAwesome.Sharp.IconPictureBox();
            this.ic_repeat1 = new FontAwesome.Sharp.IconPictureBox();
            this.ic_open = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_loop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_repeat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_open)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.track_list.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.track_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 15;
            this.track_list.Location = new System.Drawing.Point(218, 90);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(328, 195);
            this.track_list.TabIndex = 12;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            this.track_list.DoubleClick += new System.EventHandler(this.track_list_DoubleClick);
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(555, 101);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(45, 161);
            this.track_volume.TabIndex = 13;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // p_bar
            // 
            this.p_bar.Cursor = System.Windows.Forms.Cursors.Default;
            this.p_bar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.p_bar.Location = new System.Drawing.Point(12, 302);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(610, 11);
            this.p_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.p_bar.TabIndex = 14;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.lbl_track_start.Location = new System.Drawing.Point(5, 33);
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
            this.lbl_track_end.Location = new System.Drawing.Point(515, 33);
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
            // lbl_v
            // 
            this.lbl_v.AutoSize = true;
            this.lbl_v.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.lbl_v.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_v.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.lbl_v.Location = new System.Drawing.Point(551, 256);
            this.lbl_v.Name = "lbl_v";
            this.lbl_v.Size = new System.Drawing.Size(49, 15);
            this.lbl_v.TabIndex = 19;
            this.lbl_v.Text = "Volume";
            // 
            // lbl_volume
            // 
            this.lbl_volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.lbl_volume.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.lbl_volume.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_volume.Location = new System.Drawing.Point(551, 90);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(28, 15);
            this.lbl_volume.TabIndex = 20;
            this.lbl_volume.Text = "50%";
            this.lbl_volume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.btn_close.Location = new System.Drawing.Point(602, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 23);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_min
            // 
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.btn_min.Location = new System.Drawing.Point(573, 9);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 22;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // panel_m
            // 
            this.panel_m.Location = new System.Drawing.Point(-6, 0);
            this.panel_m.Name = "panel_m";
            this.panel_m.Size = new System.Drawing.Size(642, 87);
            this.panel_m.TabIndex = 24;
            this.panel_m.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_m_MouseDown);
            this.panel_m.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_m_MouseMove);
            this.panel_m.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_m_MouseUp);
            // 
            // trayIcon
            // 
            this.trayIcon.Text = "trayIcon";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // ic_play
            // 
            this.ic_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_play.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.ic_play.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_play.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_play.IconSize = 28;
            this.ic_play.Location = new System.Drawing.Point(253, 319);
            this.ic_play.Name = "ic_play";
            this.ic_play.Size = new System.Drawing.Size(28, 28);
            this.ic_play.TabIndex = 25;
            this.ic_play.TabStop = false;
            this.ic_play.Click += new System.EventHandler(this.ic_play_Click);
            // 
            // ic_next
            // 
            this.ic_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_next.IconChar = FontAwesome.Sharp.IconChar.ForwardStep;
            this.ic_next.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_next.IconSize = 28;
            this.ic_next.Location = new System.Drawing.Point(321, 319);
            this.ic_next.Name = "ic_next";
            this.ic_next.Size = new System.Drawing.Size(28, 28);
            this.ic_next.TabIndex = 26;
            this.ic_next.TabStop = false;
            this.ic_next.Click += new System.EventHandler(this.ic_next_Click);
            // 
            // ic_pause
            // 
            this.ic_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_pause.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.ic_pause.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_pause.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_pause.IconSize = 28;
            this.ic_pause.Location = new System.Drawing.Point(287, 319);
            this.ic_pause.Name = "ic_pause";
            this.ic_pause.Size = new System.Drawing.Size(28, 28);
            this.ic_pause.TabIndex = 27;
            this.ic_pause.TabStop = false;
            this.ic_pause.Click += new System.EventHandler(this.ic_pause_Click);
            // 
            // ic_preview
            // 
            this.ic_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_preview.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            this.ic_preview.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_preview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_preview.IconSize = 28;
            this.ic_preview.Location = new System.Drawing.Point(218, 319);
            this.ic_preview.Name = "ic_preview";
            this.ic_preview.Size = new System.Drawing.Size(28, 28);
            this.ic_preview.TabIndex = 28;
            this.ic_preview.TabStop = false;
            this.ic_preview.Click += new System.EventHandler(this.ic_preview_Click);
            // 
            // ic_stop
            // 
            this.ic_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_stop.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.ic_stop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_stop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_stop.IconSize = 28;
            this.ic_stop.Location = new System.Drawing.Point(355, 319);
            this.ic_stop.Name = "ic_stop";
            this.ic_stop.Size = new System.Drawing.Size(28, 28);
            this.ic_stop.TabIndex = 29;
            this.ic_stop.TabStop = false;
            this.ic_stop.Click += new System.EventHandler(this.ic_stop_Click);
            // 
            // ic_loop
            // 
            this.ic_loop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_loop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_loop.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.ic_loop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_loop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_loop.IconSize = 28;
            this.ic_loop.Location = new System.Drawing.Point(12, 319);
            this.ic_loop.Name = "ic_loop";
            this.ic_loop.Size = new System.Drawing.Size(28, 28);
            this.ic_loop.TabIndex = 31;
            this.ic_loop.TabStop = false;
            // 
            // ic_repeat1
            // 
            this.ic_repeat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_repeat1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_repeat1.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.ic_repeat1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_repeat1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_repeat1.IconSize = 28;
            this.ic_repeat1.Location = new System.Drawing.Point(46, 319);
            this.ic_repeat1.Name = "ic_repeat1";
            this.ic_repeat1.Size = new System.Drawing.Size(28, 28);
            this.ic_repeat1.TabIndex = 32;
            this.ic_repeat1.TabStop = false;
            // 
            // ic_open
            // 
            this.ic_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_open.IconChar = FontAwesome.Sharp.IconChar.Eject;
            this.ic_open.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_open.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_open.IconSize = 28;
            this.ic_open.Location = new System.Drawing.Point(597, 319);
            this.ic_open.Name = "ic_open";
            this.ic_open.Size = new System.Drawing.Size(28, 28);
            this.ic_open.TabIndex = 33;
            this.ic_open.TabStop = false;
            this.ic_open.Click += new System.EventHandler(this.ic_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(633, 358);
            this.Controls.Add(this.ic_open);
            this.Controls.Add(this.ic_repeat1);
            this.Controls.Add(this.ic_loop);
            this.Controls.Add(this.ic_stop);
            this.Controls.Add(this.ic_preview);
            this.Controls.Add(this.ic_pause);
            this.Controls.Add(this.ic_next);
            this.Controls.Add(this.ic_play);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.lbl_v);
            this.Controls.Add(this.volumeMeter1);
            this.Controls.Add(this.waveformPainter1);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_m);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KSWplayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_loop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_repeat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private NAudio.Gui.WaveformPainter waveformPainter1;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private System.Windows.Forms.Label lbl_v;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Panel panel_m;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private FontAwesome.Sharp.IconPictureBox ic_play;
        private FontAwesome.Sharp.IconPictureBox ic_next;
        private FontAwesome.Sharp.IconPictureBox ic_pause;
        private FontAwesome.Sharp.IconPictureBox ic_preview;
        private FontAwesome.Sharp.IconPictureBox ic_stop;
        private FontAwesome.Sharp.IconPictureBox ic_loop;
        private FontAwesome.Sharp.IconPictureBox ic_repeat1;
        private FontAwesome.Sharp.IconPictureBox ic_open;
    }
}

