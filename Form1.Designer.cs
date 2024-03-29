﻿using System.Drawing;

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
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.lbl_v = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_m = new System.Windows.Forms.Panel();
            this.ic_color = new FontAwesome.Sharp.IconPictureBox();
            this.ic_info = new FontAwesome.Sharp.IconPictureBox();
            this.ic_minim = new FontAwesome.Sharp.IconPictureBox();
            this.ic_close = new FontAwesome.Sharp.IconPictureBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ic_play = new FontAwesome.Sharp.IconPictureBox();
            this.ic_next = new FontAwesome.Sharp.IconPictureBox();
            this.ic_pause = new FontAwesome.Sharp.IconPictureBox();
            this.ic_preview = new FontAwesome.Sharp.IconPictureBox();
            this.ic_stop = new FontAwesome.Sharp.IconPictureBox();
            this.ic_loop = new FontAwesome.Sharp.IconPictureBox();
            this.ic_repeat1 = new FontAwesome.Sharp.IconPictureBox();
            this.ic_open = new FontAwesome.Sharp.IconPictureBox();
            this.ic_random = new FontAwesome.Sharp.IconPictureBox();
            this.myTrack_volume = new KSWplayer.MyTrackBar();
            this.p_bar_vol_vert = new KSWplayer.VerticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_m.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ic_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_minim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_loop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_repeat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_random)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrack_volume)).BeginInit();
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
            this.track_list.Size = new System.Drawing.Size(322, 195);
            this.track_list.TabIndex = 12;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            this.track_list.DoubleClick += new System.EventHandler(this.track_list_DoubleClick);
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
            // panel_m
            // 
            this.panel_m.Controls.Add(this.ic_color);
            this.panel_m.Controls.Add(this.ic_info);
            this.panel_m.Controls.Add(this.ic_minim);
            this.panel_m.Controls.Add(this.ic_close);
            this.panel_m.Location = new System.Drawing.Point(-6, 0);
            this.panel_m.Name = "panel_m";
            this.panel_m.Size = new System.Drawing.Size(642, 87);
            this.panel_m.TabIndex = 24;
            this.panel_m.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_m_MouseDown);
            this.panel_m.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_m_MouseMove);
            this.panel_m.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_m_MouseUp);
            // 
            // ic_color
            // 
            this.ic_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_color.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.ic_color.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_color.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_color.IconSize = 28;
            this.ic_color.Location = new System.Drawing.Point(509, 3);
            this.ic_color.Name = "ic_color";
            this.ic_color.Size = new System.Drawing.Size(28, 28);
            this.ic_color.TabIndex = 36;
            this.ic_color.TabStop = false;
            this.ic_color.Click += new System.EventHandler(this.ic_color_Click);
            // 
            // ic_info
            // 
            this.ic_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_info.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.ic_info.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_info.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_info.IconSize = 20;
            this.ic_info.Location = new System.Drawing.Point(543, 10);
            this.ic_info.Name = "ic_info";
            this.ic_info.Size = new System.Drawing.Size(20, 20);
            this.ic_info.TabIndex = 35;
            this.ic_info.TabStop = false;
            this.ic_info.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // ic_minim
            // 
            this.ic_minim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_minim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_minim.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ic_minim.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_minim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_minim.IconSize = 28;
            this.ic_minim.Location = new System.Drawing.Point(569, 2);
            this.ic_minim.Name = "ic_minim";
            this.ic_minim.Size = new System.Drawing.Size(28, 28);
            this.ic_minim.TabIndex = 34;
            this.ic_minim.TabStop = false;
            this.ic_minim.Click += new System.EventHandler(this.ic_minim_Click);
            // 
            // ic_close
            // 
            this.ic_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_close.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ic_close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_close.IconSize = 28;
            this.ic_close.Location = new System.Drawing.Point(603, 3);
            this.ic_close.Name = "ic_close";
            this.ic_close.Size = new System.Drawing.Size(28, 28);
            this.ic_close.TabIndex = 34;
            this.ic_close.TabStop = false;
            this.ic_close.Click += new System.EventHandler(this.ic_close_Click);
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
            this.ic_loop.Click += new System.EventHandler(this.ic_loop_Click);
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
            this.ic_repeat1.Click += new System.EventHandler(this.ic_repeat1_Click);
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
            // ic_random
            // 
            this.ic_random.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ic_random.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_random.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.ic_random.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(42)))), ((int)(((byte)(112)))));
            this.ic_random.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_random.IconSize = 28;
            this.ic_random.Location = new System.Drawing.Point(80, 319);
            this.ic_random.Name = "ic_random";
            this.ic_random.Size = new System.Drawing.Size(28, 28);
            this.ic_random.TabIndex = 34;
            this.ic_random.TabStop = false;
            this.ic_random.Click += new System.EventHandler(this.ic_random_Click);
            // 
            // myTrack_volume
            // 
            this.myTrack_volume.Location = new System.Drawing.Point(546, 110);
            this.myTrack_volume.Maximum = 100;
            this.myTrack_volume.Name = "myTrack_volume";
            this.myTrack_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.myTrack_volume.Size = new System.Drawing.Size(45, 143);
            this.myTrack_volume.TabIndex = 10;
            this.myTrack_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.myTrack_volume.Scroll += new System.EventHandler(this.myTrack_volume_Scroll);
            // 
            // p_bar_vol_vert
            // 
            this.p_bar_vol_vert.Location = new System.Drawing.Point(597, 101);
            this.p_bar_vol_vert.Name = "p_bar_vol_vert";
            this.p_bar_vol_vert.Size = new System.Drawing.Size(24, 152);
            this.p_bar_vol_vert.Step = 100;
            this.p_bar_vol_vert.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.p_bar_vol_vert.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(633, 358);
            this.Controls.Add(this.myTrack_volume);
            this.Controls.Add(this.p_bar_vol_vert);
            this.Controls.Add(this.ic_random);
            this.Controls.Add(this.ic_open);
            this.Controls.Add(this.ic_repeat1);
            this.Controls.Add(this.ic_loop);
            this.Controls.Add(this.ic_stop);
            this.Controls.Add(this.ic_preview);
            this.Controls.Add(this.ic_pause);
            this.Controls.Add(this.ic_next);
            this.Controls.Add(this.ic_play);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.lbl_v);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_m);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KSWplayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_m.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ic_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_minim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_loop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_repeat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic_random)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrack_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MyTrackBar myTrack_volume;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Label lbl_v;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Timer timer1;
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
        private FontAwesome.Sharp.IconPictureBox ic_minim;
        private FontAwesome.Sharp.IconPictureBox ic_close;
        private FontAwesome.Sharp.IconPictureBox ic_random;
        private VerticalProgressBar p_bar_vol_vert;
        private FontAwesome.Sharp.IconPictureBox ic_info;
        private FontAwesome.Sharp.IconPictureBox ic_color;
    }
}

