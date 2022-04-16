
namespace AudioEditor.View
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.trbProgress = new System.Windows.Forms.TrackBar();
            this.lblTimer1 = new System.Windows.Forms.Label();
            this.lblTimer2 = new System.Windows.Forms.Label();
            this.btnSavePlayList = new System.Windows.Forms.Button();
            this.btnAddPlayList = new System.Windows.Forms.Button();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.btnRemoveTrack = new System.Windows.Forms.Button();
            this.btnCleanPlayList = new System.Windows.Forms.Button();
            this.lbPlayList = new System.Windows.Forms.ListBox();
            this.lbNameOfPlayList = new System.Windows.Forms.Label();
            this.ofdOpenAudio = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenPlayList = new System.Windows.Forms.Button();
            this.sfdSavePlayList = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenPlayList = new System.Windows.Forms.OpenFileDialog();
            this.cwvWaveVizualisator = new AudioEditor.Logics.CustomWaveViewer();
            this.btnPrevious = new WindowsFormsAudio.RoundButton();
            this.btnNext = new WindowsFormsAudio.RoundButton();
            this.btnStop = new WindowsFormsAudio.RoundButton();
            this.btnPlay = new WindowsFormsAudio.RoundButton();
            this.btnPause = new WindowsFormsAudio.RoundButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.trbVolume);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnPlay);
            this.panel3.Controls.Add(this.btnPause);
            this.panel3.Location = new System.Drawing.Point(0, 384);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 79);
            this.panel3.TabIndex = 10;
            // 
            // trbVolume
            // 
            this.trbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbVolume.Location = new System.Drawing.Point(862, 23);
            this.trbVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trbVolume.Maximum = 100;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(153, 56);
            this.trbVolume.TabIndex = 10;
            this.trbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbVolume.Value = 50;
            // 
            // trbProgress
            // 
            this.trbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.trbProgress.Location = new System.Drawing.Point(13, 331);
            this.trbProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trbProgress.Maximum = 100;
            this.trbProgress.Name = "trbProgress";
            this.trbProgress.Size = new System.Drawing.Size(1020, 56);
            this.trbProgress.TabIndex = 11;
            this.trbProgress.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblTimer1
            // 
            this.lblTimer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer1.AutoSize = true;
            this.lblTimer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(189)))), ((int)(((byte)(213)))));
            this.lblTimer1.Location = new System.Drawing.Point(23, 364);
            this.lblTimer1.Name = "lblTimer1";
            this.lblTimer1.Size = new System.Drawing.Size(56, 17);
            this.lblTimer1.TabIndex = 12;
            this.lblTimer1.Text = "0:00:00";
            // 
            // lblTimer2
            // 
            this.lblTimer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer2.AutoSize = true;
            this.lblTimer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(189)))), ((int)(((byte)(213)))));
            this.lblTimer2.Location = new System.Drawing.Point(959, 364);
            this.lblTimer2.Name = "lblTimer2";
            this.lblTimer2.Size = new System.Drawing.Size(56, 17);
            this.lblTimer2.TabIndex = 13;
            this.lblTimer2.Text = "0:00:00";
            // 
            // btnSavePlayList
            // 
            this.btnSavePlayList.BackgroundImage = global::AudioEditor.Properties.Resources.black_icon_save_playlist;
            this.btnSavePlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSavePlayList.FlatAppearance.BorderSize = 0;
            this.btnSavePlayList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnSavePlayList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnSavePlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePlayList.Location = new System.Drawing.Point(992, 276);
            this.btnSavePlayList.Name = "btnSavePlayList";
            this.btnSavePlayList.Size = new System.Drawing.Size(44, 44);
            this.btnSavePlayList.TabIndex = 15;
            this.btnSavePlayList.UseVisualStyleBackColor = true;
            this.btnSavePlayList.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddPlayList
            // 
            this.btnAddPlayList.BackgroundImage = global::AudioEditor.Properties.Resources.black_icon_add_playlist;
            this.btnAddPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPlayList.FlatAppearance.BorderSize = 0;
            this.btnAddPlayList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnAddPlayList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnAddPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlayList.Location = new System.Drawing.Point(992, 26);
            this.btnAddPlayList.Name = "btnAddPlayList";
            this.btnAddPlayList.Size = new System.Drawing.Size(44, 44);
            this.btnAddPlayList.TabIndex = 16;
            this.btnAddPlayList.UseVisualStyleBackColor = true;
            this.btnAddPlayList.Click += new System.EventHandler(this.btnAddPlayList_Click);
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.BackgroundImage = global::AudioEditor.Properties.Resources.black_icon_add_track;
            this.btnAddTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTrack.FlatAppearance.BorderSize = 0;
            this.btnAddTrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnAddTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnAddTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrack.Location = new System.Drawing.Point(992, 176);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(44, 44);
            this.btnAddTrack.TabIndex = 17;
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // btnRemoveTrack
            // 
            this.btnRemoveTrack.BackgroundImage = global::AudioEditor.Properties.Resources.black_icon_remove_track;
            this.btnRemoveTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveTrack.FlatAppearance.BorderSize = 0;
            this.btnRemoveTrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnRemoveTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnRemoveTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTrack.Location = new System.Drawing.Point(992, 226);
            this.btnRemoveTrack.Name = "btnRemoveTrack";
            this.btnRemoveTrack.Size = new System.Drawing.Size(44, 44);
            this.btnRemoveTrack.TabIndex = 18;
            this.btnRemoveTrack.UseVisualStyleBackColor = true;
            this.btnRemoveTrack.Click += new System.EventHandler(this.btnRemoveTrack_Click);
            // 
            // btnCleanPlayList
            // 
            this.btnCleanPlayList.BackgroundImage = global::AudioEditor.Properties.Resources.black_icon_clean_playlist;
            this.btnCleanPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCleanPlayList.FlatAppearance.BorderSize = 0;
            this.btnCleanPlayList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnCleanPlayList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnCleanPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanPlayList.Location = new System.Drawing.Point(992, 126);
            this.btnCleanPlayList.Name = "btnCleanPlayList";
            this.btnCleanPlayList.Size = new System.Drawing.Size(44, 44);
            this.btnCleanPlayList.TabIndex = 19;
            this.btnCleanPlayList.UseVisualStyleBackColor = true;
            this.btnCleanPlayList.Click += new System.EventHandler(this.btnCleanPlayList_Click);
            // 
            // lbPlayList
            // 
            this.lbPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lbPlayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.lbPlayList.FormattingEnabled = true;
            this.lbPlayList.ItemHeight = 20;
            this.lbPlayList.Location = new System.Drawing.Point(751, 41);
            this.lbPlayList.Name = "lbPlayList";
            this.lbPlayList.Size = new System.Drawing.Size(229, 260);
            this.lbPlayList.TabIndex = 22;
            this.lbPlayList.SelectedIndexChanged += new System.EventHandler(this.lbPlayList_SelectedIndexChanged);
            // 
            // lbNameOfPlayList
            // 
            this.lbNameOfPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNameOfPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameOfPlayList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.lbNameOfPlayList.Location = new System.Drawing.Point(751, 13);
            this.lbNameOfPlayList.Name = "lbNameOfPlayList";
            this.lbNameOfPlayList.Size = new System.Drawing.Size(229, 25);
            this.lbNameOfPlayList.TabIndex = 23;
            this.lbNameOfPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNameOfPlayList.Click += new System.EventHandler(this.lbNameOfPlayList_Click);
            // 
            // ofdOpenAudio
            // 
            this.ofdOpenAudio.Filter = "WAV files|*.wav|MP3 files|*.mp3|AIFF files|*.aiff";
            this.ofdOpenAudio.Multiselect = true;
            // 
            // btnOpenPlayList
            // 
            this.btnOpenPlayList.BackgroundImage = global::AudioEditor.Properties.Resources.black_icon_open_playlist;
            this.btnOpenPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenPlayList.FlatAppearance.BorderSize = 0;
            this.btnOpenPlayList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnOpenPlayList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnOpenPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPlayList.Location = new System.Drawing.Point(992, 76);
            this.btnOpenPlayList.Name = "btnOpenPlayList";
            this.btnOpenPlayList.Size = new System.Drawing.Size(44, 44);
            this.btnOpenPlayList.TabIndex = 24;
            this.btnOpenPlayList.UseVisualStyleBackColor = true;
            this.btnOpenPlayList.Click += new System.EventHandler(this.btnOpenPlayList_Click);
            // 
            // sfdSavePlayList
            // 
            this.sfdSavePlayList.Filter = "PlayList files|*.pls";
            // 
            // ofdOpenPlayList
            // 
            this.ofdOpenPlayList.Filter = "PlayList files|*.pls";
            // 
            // cwvWaveVizualisator
            // 
            this.cwvWaveVizualisator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cwvWaveVizualisator.Location = new System.Drawing.Point(7, 9);
            this.cwvWaveVizualisator.Name = "cwvWaveVizualisator";
            this.cwvWaveVizualisator.PenColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.cwvWaveVizualisator.PenWidth = 1F;
            this.cwvWaveVizualisator.SamplesPerPixel = 128;
            this.cwvWaveVizualisator.Size = new System.Drawing.Size(738, 305);
            this.cwvWaveVizualisator.StartPosition = ((long)(0));
            this.cwvWaveVizualisator.TabIndex = 21;
            this.cwvWaveVizualisator.WaveStream = null;
            this.cwvWaveVizualisator.Load += new System.EventHandler(this.cwvWaveVizualisator_Load);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(323, 0);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(80, 74);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(603, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 74);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(696, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 74);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(416, 0);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 74);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(509, 1);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(80, 74);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1048, 465);
            this.Controls.Add(this.btnOpenPlayList);
            this.Controls.Add(this.lbNameOfPlayList);
            this.Controls.Add(this.lbPlayList);
            this.Controls.Add(this.cwvWaveVizualisator);
            this.Controls.Add(this.btnCleanPlayList);
            this.Controls.Add(this.btnRemoveTrack);
            this.Controls.Add(this.btnAddTrack);
            this.Controls.Add(this.btnAddPlayList);
            this.Controls.Add(this.btnSavePlayList);
            this.Controls.Add(this.lblTimer2);
            this.Controls.Add(this.lblTimer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.trbProgress);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1066, 507);
            this.MinimumSize = new System.Drawing.Size(1066, 507);
            this.Name = "frmMainForm";
            this.Text = "Audio Editor";
            this.Load += new System.EventHandler(this.frmMainForm1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsAudio.RoundButton btnPrevious;
        private WindowsFormsAudio.RoundButton btnPause;
        private WindowsFormsAudio.RoundButton btnPlay;
        private WindowsFormsAudio.RoundButton btnStop;
        private WindowsFormsAudio.RoundButton btnNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.TrackBar trbProgress;
        private System.Windows.Forms.Label lblTimer1;
        private System.Windows.Forms.Label lblTimer2;
        private System.Windows.Forms.Button btnSavePlayList;
        private System.Windows.Forms.Button btnAddPlayList;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.Button btnRemoveTrack;
        private System.Windows.Forms.Button btnCleanPlayList;
        private Logics.CustomWaveViewer cwvWaveVizualisator;
        private System.Windows.Forms.ListBox lbPlayList;
        private System.Windows.Forms.Label lbNameOfPlayList;
        private System.Windows.Forms.OpenFileDialog ofdOpenAudio;
        private System.Windows.Forms.Button btnOpenPlayList;
        private System.Windows.Forms.SaveFileDialog sfdSavePlayList;
        private System.Windows.Forms.OpenFileDialog ofdOpenPlayList;
    }
}