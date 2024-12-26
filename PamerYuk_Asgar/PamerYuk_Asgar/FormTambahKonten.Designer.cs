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
            this.pictureBoxGambar.Location = new System.Drawing.Point(26, 246);
            this.pictureBoxGambar.Name = "pictureBoxGambar";
            this.pictureBoxGambar.Size = new System.Drawing.Size(314, 298);
            this.pictureBoxGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGambar.TabIndex = 0;
            this.pictureBoxGambar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.labelJudul);
            this.panel1.Location = new System.Drawing.Point(65, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 62);
            this.panel1.TabIndex = 24;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(341, 8);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(413, 52);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "TAMBAH KONTEN";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Location = new System.Drawing.Point(23, 227);
            this.labelPicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(54, 16);
            this.labelPicture.TabIndex = 25;
            this.labelPicture.Text = "Picture :";
            this.labelPicture.Click += new System.EventHandler(this.labelPicture_Click);
            // 
            // buttonTambahPicture
            // 
            this.buttonTambahPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahPicture.Location = new System.Drawing.Point(121, 551);
            this.buttonTambahPicture.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambahPicture.Name = "buttonTambahPicture";
            this.buttonTambahPicture.Size = new System.Drawing.Size(96, 36);
            this.buttonTambahPicture.TabIndex = 31;
            this.buttonTambahPicture.Text = "Tambah";
            this.buttonTambahPicture.UseVisualStyleBackColor = false;
            this.buttonTambahPicture.Click += new System.EventHandler(this.buttonTambahPicture_Click);
            // 
            // buttonTambahVideo
            // 
            this.buttonTambahVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahVideo.Location = new System.Drawing.Point(539, 551);
            this.buttonTambahVideo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambahVideo.Name = "buttonTambahVideo";
            this.buttonTambahVideo.Size = new System.Drawing.Size(96, 36);
            this.buttonTambahVideo.TabIndex = 32;
            this.buttonTambahVideo.Text = "Tambah";
            this.buttonTambahVideo.UseVisualStyleBackColor = false;
            this.buttonTambahVideo.Click += new System.EventHandler(this.buttonTambahVideo_Click);
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Location = new System.Drawing.Point(379, 104);
            this.labelVideo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(49, 16);
            this.labelVideo.TabIndex = 33;
            this.labelVideo.Text = "Video :";
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(18, 104);
            this.labelCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(59, 16);
            this.labelCaption.TabIndex = 35;
            this.labelCaption.Text = "Caption :";
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Location = new System.Drawing.Point(21, 123);
            this.textBoxCaption.Multiline = true;
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(319, 71);
            this.textBoxCaption.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.axWindowsMediaPlayerVideo);
            this.panel2.Location = new System.Drawing.Point(382, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 421);
            this.panel2.TabIndex = 36;
            // 
            // axWindowsMediaPlayerVideo
            // 
            this.axWindowsMediaPlayerVideo.Enabled = true;
            this.axWindowsMediaPlayerVideo.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayerVideo.Name = "axWindowsMediaPlayerVideo";
            this.axWindowsMediaPlayerVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerVideo.OcxState")));
            this.axWindowsMediaPlayerVideo.Size = new System.Drawing.Size(403, 430);
            this.axWindowsMediaPlayerVideo.TabIndex = 0;
            // 
            // buttonTambahTag
            // 
            this.buttonTambahTag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahTag.Location = new System.Drawing.Point(1044, 154);
            this.buttonTambahTag.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambahTag.Name = "buttonTambahTag";
            this.buttonTambahTag.Size = new System.Drawing.Size(88, 36);
            this.buttonTambahTag.TabIndex = 37;
            this.buttonTambahTag.Text = "Tambah";
            this.buttonTambahTag.UseVisualStyleBackColor = false;
            this.buttonTambahTag.Click += new System.EventHandler(this.buttonTambahTag_Click);
            // 
            // comboBoxTag
            // 
            this.comboBoxTag.FormattingEnabled = true;
            this.comboBoxTag.Location = new System.Drawing.Point(816, 123);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(316, 24);
            this.comboBoxTag.TabIndex = 38;
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(813, 104);
            this.labelTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(84, 16);
            this.labelTag.TabIndex = 39;
            this.labelTag.Text = "Tag Teman :";
            // 
            // listBoxTag
            // 
            this.listBoxTag.FormattingEnabled = true;
            this.listBoxTag.ItemHeight = 16;
            this.listBoxTag.Location = new System.Drawing.Point(816, 154);
            this.listBoxTag.Name = "listBoxTag";
            this.listBoxTag.Size = new System.Drawing.Size(221, 388);
            this.listBoxTag.TabIndex = 40;
            // 
            // buttonTambahKonten
            // 
            this.buttonTambahKonten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahKonten.Location = new System.Drawing.Point(967, 630);
            this.buttonTambahKonten.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambahKonten.Name = "buttonTambahKonten";
            this.buttonTambahKonten.Size = new System.Drawing.Size(159, 36);
            this.buttonTambahKonten.TabIndex = 41;
            this.buttonTambahKonten.Text = "Upload";
            this.buttonTambahKonten.UseVisualStyleBackColor = false;
            this.buttonTambahKonten.Click += new System.EventHandler(this.buttonTambahKonten_Click);
            // 
            // FormTambahKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 679);
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
            this.Name = "FormTambahKonten";
            this.Text = "FormTambahKonten";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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