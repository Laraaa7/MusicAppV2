namespace MusicAppV2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.songName1 = new SongName();
            this.songSubtitle1 = new MusicAppDLLV2.SongSubtitle();
            this.musicNoteIcon1 = new MusicIconControls.MusicNoteIcon();
            this.songTime2 = new SongTime();
            this.customSlider1 = new MusicAppDLLV2.CustomSlider();
            this.playNextOrRewindButton2 = new MusicAppDLLV2.PlayNextOrRewindButton();
            this.playNextOrRewindButton1 = new MusicAppDLLV2.PlayNextOrRewindButton();
            this.playButton1 = new MusicAppDLLV2.PlayButton();
            this.fileButton1 = new MusicAppDLLV2.FileButton();
            this.closeButton1 = new MusicAppDLLV2.CloseButton();
            this.card1 = new MusicAppDLLV2.Card();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // songName1
            // 
            this.songName1.BackColor = System.Drawing.Color.Transparent;
            this.songName1.Location = new System.Drawing.Point(493, 373);
            this.songName1.Name = "songName1";
            this.songName1.Size = new System.Drawing.Size(200, 30);
            this.songName1.SongTitle = "Song name";
            this.songName1.TabIndex = 15;
            this.songName1.Text = "songName1";
            this.songName1.TitleColor = System.Drawing.Color.White;
            this.songName1.TitleFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            // 
            // songSubtitle1
            // 
            this.songSubtitle1.BackColor = System.Drawing.SystemColors.Control;
            this.songSubtitle1.Location = new System.Drawing.Point(483, 427);
            this.songSubtitle1.Name = "songSubtitle1";
            this.songSubtitle1.Size = new System.Drawing.Size(221, 20);
            this.songSubtitle1.Subtitle = "C# F Mp3 Music Player";
            this.songSubtitle1.SubtitleColor = System.Drawing.Color.White;
            this.songSubtitle1.SubtitleFont = new System.Drawing.Font("Arial", 10F);
            this.songSubtitle1.TabIndex = 14;
            this.songSubtitle1.Text = "songSubtitle1";
            // 
            // musicNoteIcon1
            // 
            this.musicNoteIcon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.musicNoteIcon1.BackgroundColor = System.Drawing.Color.Transparent;
            this.musicNoteIcon1.Image = ((System.Drawing.Image)(resources.GetObject("musicNoteIcon1.Image")));
            this.musicNoteIcon1.IsCircular = true;
            this.musicNoteIcon1.Location = new System.Drawing.Point(463, 92);
            this.musicNoteIcon1.Name = "musicNoteIcon1";
            this.musicNoteIcon1.NoteColor = System.Drawing.Color.White;
            this.musicNoteIcon1.NoteFont = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold);
            this.musicNoteIcon1.Size = new System.Drawing.Size(258, 255);
            this.musicNoteIcon1.TabIndex = 13;
            this.musicNoteIcon1.Text = "musicNoteIcon1";
            // 
            // songTime2
            // 
            this.songTime2.BackColor = System.Drawing.Color.Transparent;
            this.songTime2.Location = new System.Drawing.Point(421, 533);
            this.songTime2.Name = "songTime2";
            this.songTime2.Progress = 0F;
            this.songTime2.ProgressBarColor = System.Drawing.Color.DarkRed;
            this.songTime2.Size = new System.Drawing.Size(343, 23);
            this.songTime2.TabIndex = 11;
            this.songTime2.Text = "songTime2";
            this.songTime2.TextColor = System.Drawing.Color.White;
            // 
            // customSlider1
            // 
            this.customSlider1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customSlider1.Location = new System.Drawing.Point(421, 550);
            this.customSlider1.Max = 100;
            this.customSlider1.Min = 0;
            this.customSlider1.Name = "customSlider1";
            this.customSlider1.Size = new System.Drawing.Size(343, 39);
            this.customSlider1.TabIndex = 6;
            this.customSlider1.Text = "customSlider1";
            this.customSlider1.Value = 0;
            // 
            // playNextOrRewindButton2
            // 
            this.playNextOrRewindButton2.BackColor = System.Drawing.Color.DarkRed;
            this.playNextOrRewindButton2.FlatAppearance.BorderSize = 0;
            this.playNextOrRewindButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playNextOrRewindButton2.Font = new System.Drawing.Font("Arial", 10F);
            this.playNextOrRewindButton2.IconColor = System.Drawing.Color.White;
            this.playNextOrRewindButton2.Location = new System.Drawing.Point(472, 601);
            this.playNextOrRewindButton2.Name = "playNextOrRewindButton2";
            this.playNextOrRewindButton2.RotationDirection = MusicAppDLLV2.RotationDirection.Right;
            this.playNextOrRewindButton2.Size = new System.Drawing.Size(69, 68);
            this.playNextOrRewindButton2.TabIndex = 5;
            this.playNextOrRewindButton2.Text = "playNextOrRewindButton2";
            this.playNextOrRewindButton2.UseVisualStyleBackColor = false;
            // 
            // playNextOrRewindButton1
            // 
            this.playNextOrRewindButton1.BackColor = System.Drawing.Color.DarkRed;
            this.playNextOrRewindButton1.FlatAppearance.BorderSize = 0;
            this.playNextOrRewindButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playNextOrRewindButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.playNextOrRewindButton1.IconColor = System.Drawing.Color.White;
            this.playNextOrRewindButton1.Location = new System.Drawing.Point(651, 601);
            this.playNextOrRewindButton1.Name = "playNextOrRewindButton1";
            this.playNextOrRewindButton1.RotationDirection = MusicAppDLLV2.RotationDirection.Left;
            this.playNextOrRewindButton1.Size = new System.Drawing.Size(70, 68);
            this.playNextOrRewindButton1.TabIndex = 4;
            this.playNextOrRewindButton1.Text = "playNextOrRewindButton1";
            this.playNextOrRewindButton1.UseVisualStyleBackColor = false;
            // 
            // playButton1
            // 
            this.playButton1.BackColor = System.Drawing.Color.DarkRed;
            this.playButton1.FlatAppearance.BorderSize = 0;
            this.playButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.playButton1.IconColor = System.Drawing.Color.White;
            this.playButton1.Location = new System.Drawing.Point(560, 601);
            this.playButton1.Name = "playButton1";
            this.playButton1.RotationDirection = MusicAppDLLV2.RotationDirection.Right;
            this.playButton1.Size = new System.Drawing.Size(72, 68);
            this.playButton1.TabIndex = 3;
            this.playButton1.Text = "playButton1";
            this.playButton1.UseVisualStyleBackColor = false;
            // 
            // fileButton1
            // 
            this.fileButton1.BackColor = System.Drawing.Color.DarkRed;
            this.fileButton1.FlatAppearance.BorderSize = 0;
            this.fileButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.fileButton1.IconColor = System.Drawing.Color.White;
            this.fileButton1.Location = new System.Drawing.Point(411, 18);
            this.fileButton1.Name = "fileButton1";
            this.fileButton1.Size = new System.Drawing.Size(69, 68);
            this.fileButton1.TabIndex = 2;
            this.fileButton1.Text = "fileButton1";
            this.fileButton1.UseVisualStyleBackColor = false;
            // 
            // closeButton1
            // 
            this.closeButton1.BackColor = System.Drawing.Color.DarkRed;
            this.closeButton1.FlatAppearance.BorderSize = 0;
            this.closeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.closeButton1.IconColor = System.Drawing.Color.White;
            this.closeButton1.Location = new System.Drawing.Point(695, 18);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(69, 68);
            this.closeButton1.TabIndex = 1;
            this.closeButton1.Text = "closeButton1";
            this.closeButton1.UseVisualStyleBackColor = false;
            // 
            // card1
            // 
            this.card1.CornerRadius = 40;
            this.card1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.card1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.card1.Location = new System.Drawing.Point(386, 3);
            this.card1.Name = "card1";
            this.card1.Padding = new System.Windows.Forms.Padding(10);
            this.card1.Size = new System.Drawing.Size(404, 711);
            this.card1.TabIndex = 0;
            this.card1.Text = "card1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1222, 719);
            this.Controls.Add(this.songName1);
            this.Controls.Add(this.songSubtitle1);
            this.Controls.Add(this.musicNoteIcon1);
            this.Controls.Add(this.songTime2);
            this.Controls.Add(this.customSlider1);
            this.Controls.Add(this.playNextOrRewindButton2);
            this.Controls.Add(this.playNextOrRewindButton1);
            this.Controls.Add(this.playButton1);
            this.Controls.Add(this.fileButton1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.card1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private MusicAppDLLV2.Card card1;
        private MusicAppDLLV2.CloseButton closeButton1;
        private MusicAppDLLV2.FileButton fileButton1;
        private MusicAppDLLV2.PlayButton playButton1;
        private MusicAppDLLV2.PlayNextOrRewindButton playNextOrRewindButton1;
        private MusicAppDLLV2.PlayNextOrRewindButton playNextOrRewindButton2;
        private MusicAppDLLV2.CustomSlider customSlider1;
        private SongTime songTime2;
        private MusicIconControls.MusicNoteIcon musicNoteIcon1;
        private System.Windows.Forms.ImageList imageList1;
        private MusicAppDLLV2.SongSubtitle songSubtitle1;
        private SongName songName1;
    }
}

