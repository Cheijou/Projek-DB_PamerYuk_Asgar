namespace PamerYuk_Asgar
{
    partial class FormTambahKonten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahKonten));
            this.pictureBoxGambar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.buttonTambahPicture = new System.Windows.Forms.Button();
            this.buttonTambahVideo = new System.Windows.Forms.Button();
            this.labelVideo = new System.Windows.Forms.Label();
            this.labelCaption = new System.Windows.Forms.Label();
            this.textBoxCaption = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayerVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonTambahTag = new System.Windows.Forms.Button();
            this.comboBoxTag = new System.Windows.Forms.ComboBox();
            this.labelTag = new System.Windows.Forms.Label();
            this.listBoxTag = new System.Windows.Forms.ListBox();
            this.buttonTambahKonten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGambar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGambar
            // 
            this.pictureBoxGambar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxGambar.Location = new System.Drawing.Point(21, 99);
            this.pictureBoxGambar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxGambar.Name = "pictureBoxGambar";
            this.pictureBoxGambar.Size = new System.Drawing.Size(253, 279);
            this.pictureBoxGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGambar.TabIndex = 0;
            this.pictureBoxGambar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.labelJudul);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 50);
            this.panel1.TabIndex = 24;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(256, 6);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(327, 39);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "TAMBAH KONTEN";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Location = new System.Drawing.Point(21, 77);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(46, 13);
            this.labelPicture.TabIndex = 25;
            this.labelPicture.Text = "Picture :";
            this.labelPicture.Click += new System.EventHandler(this.labelPicture_Click);
            // 
            // buttonTambahPicture
            // 
            this.buttonTambahPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahPicture.Location = new System.Drawing.Point(102, 393);
            this.buttonTambahPicture.Name = "buttonTambahPicture";
            this.buttonTambahPicture.Size = new System.Drawing.Size(72, 29);
            this.buttonTambahPicture.TabIndex = 31;
            this.buttonTambahPicture.Text = "Tambah";
            this.buttonTambahPicture.UseVisualStyleBackColor = false;
            this.buttonTambahPicture.Click += new System.EventHandler(this.buttonTambahPicture_Click);
            // 
            // buttonTambahVideo
            // 
            this.buttonTambahVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahVideo.Location = new System.Drawing.Point(408, 394);
            this.buttonTambahVideo.Name = "buttonTambahVideo";
            this.buttonTambahVideo.Size = new System.Drawing.Size(72, 29);
            this.buttonTambahVideo.TabIndex = 32;
            this.buttonTambahVideo.Text = "Tambah";
            this.buttonTambahVideo.UseVisualStyleBackColor = false;
            this.buttonTambahVideo.Click += new System.EventHandler(this.buttonTambahVideo_Click);
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Location = new System.Drawing.Point(284, 84);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(40, 13);
            this.labelVideo.TabIndex = 33;
            this.labelVideo.Text = "Video :";
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(611, 248);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(49, 13);
            this.labelCaption.TabIndex = 35;
            this.labelCaption.Text = "Caption :";
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Location = new System.Drawing.Point(612, 271);
            this.textBoxCaption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCaption.Multiline = true;
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(240, 94);
            this.textBoxCaption.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.axWindowsMediaPlayerVideo);
            this.panel2.Location = new System.Drawing.Point(286, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 279);
            this.panel2.TabIndex = 36;
            // 
            // axWindowsMediaPlayerVideo
            // 
            this.axWindowsMediaPlayerVideo.Enabled = true;
            this.axWindowsMediaPlayerVideo.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayerVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayerVideo.Name = "axWindowsMediaPlayerVideo";
            this.axWindowsMediaPlayerVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerVideo.OcxState")));
            this.axWindowsMediaPlayerVideo.Size = new System.Drawing.Size(315, 265);
            this.axWindowsMediaPlayerVideo.TabIndex = 0;
            // 
            // buttonTambahTag
            // 
            this.buttonTambahTag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahTag.Location = new System.Drawing.Point(783, 125);
            this.buttonTambahTag.Name = "buttonTambahTag";
            this.buttonTambahTag.Size = new System.Drawing.Size(66, 29);
            this.buttonTambahTag.TabIndex = 37;
            this.buttonTambahTag.Text = "Tambah";
            this.buttonTambahTag.UseVisualStyleBackColor = false;
            this.buttonTambahTag.Click += new System.EventHandler(this.buttonTambahTag_Click);
            // 
            // comboBoxTag
            // 
            this.comboBoxTag.FormattingEnabled = true;
            this.comboBoxTag.Location = new System.Drawing.Point(612, 100);
            this.comboBoxTag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(238, 21);
            this.comboBoxTag.TabIndex = 38;
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(610, 84);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(68, 13);
            this.labelTag.TabIndex = 39;
            this.labelTag.Text = "Tag Teman :";
            // 
            // listBoxTag
            // 
            this.listBoxTag.FormattingEnabled = true;
            this.listBoxTag.Location = new System.Drawing.Point(612, 131);
            this.listBoxTag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxTag.Name = "listBoxTag";
            this.listBoxTag.Size = new System.Drawing.Size(167, 108);
            this.listBoxTag.TabIndex = 40;
            // 
            // buttonTambahKonten
            // 
            this.buttonTambahKonten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahKonten.Location = new System.Drawing.Point(709, 376);
            this.buttonTambahKonten.Name = "buttonTambahKonten";
            this.buttonTambahKonten.Size = new System.Drawing.Size(140, 34);
            this.buttonTambahKonten.TabIndex = 41;
            this.buttonTambahKonten.Text = "Upload";
            this.buttonTambahKonten.UseVisualStyleBackColor = false;
            this.buttonTambahKonten.Click += new System.EventHandler(this.buttonTambahKonten_Click);
            // 
            // FormTambahKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 433);
            this.Controls.Add(this.buttonTambahKonten);
            this.Controls.Add(this.listBoxTag);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.comboBoxTag);
            this.Controls.Add(this.buttonTambahTag);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.textBoxCaption);
            this.Controls.Add(this.labelVideo);
            this.Controls.Add(this.buttonTambahVideo);
            this.Controls.Add(this.buttonTambahPicture);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxGambar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTambahKonten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahKonten";
            this.Load += new System.EventHandler(this.FormTambahKonten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGambar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGambar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Button buttonTambahPicture;
        private System.Windows.Forms.Button buttonTambahVideo;
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.TextBox textBoxCaption;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerVideo;
        private System.Windows.Forms.Button buttonTambahTag;
        private System.Windows.Forms.ComboBox comboBoxTag;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.ListBox listBoxTag;
        private System.Windows.Forms.Button buttonTambahKonten;
    }
}