namespace PamerYuk_Asgar
{
    partial class FormDetailKonten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailKonten));
            this.panelKonten = new System.Windows.Forms.Panel();
            this.labelKomen = new System.Windows.Forms.Label();
            this.labelCaption = new System.Windows.Forms.Label();
            this.pictureBoxGambar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayerVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelKomentar = new System.Windows.Forms.Label();
            this.listBoxKomentar = new System.Windows.Forms.ListBox();
            this.labelHasilCaption = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTextBox = new System.Windows.Forms.Label();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.textBoxKomen = new System.Windows.Forms.TextBox();
            this.buttonTambahKomentar = new System.Windows.Forms.Button();
            this.buttonLike = new System.Windows.Forms.Button();
            this.labelTotalLike = new System.Windows.Forms.Label();
            this.panelKonten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGambar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerVideo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKonten
            // 
            this.panelKonten.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelKonten.Controls.Add(this.labelKomen);
            this.panelKonten.Location = new System.Drawing.Point(9, 2);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(662, 44);
            this.panelKonten.TabIndex = 5;
            // 
            // labelKomen
            // 
            this.labelKomen.AutoSize = true;
            this.labelKomen.Font = new System.Drawing.Font("Arial Narrow", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKomen.Location = new System.Drawing.Point(272, -1);
            this.labelKomen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKomen.Name = "labelKomen";
            this.labelKomen.Size = new System.Drawing.Size(125, 44);
            this.labelKomen.TabIndex = 3;
            this.labelKomen.Text = "Konten";
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaption.Location = new System.Drawing.Point(411, 50);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(73, 17);
            this.labelCaption.TabIndex = 29;
            this.labelCaption.Text = "Caption :";
            // 
            // pictureBoxGambar
            // 
            this.pictureBoxGambar.Location = new System.Drawing.Point(9, 365);
            this.pictureBoxGambar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxGambar.Name = "pictureBoxGambar";
            this.pictureBoxGambar.Size = new System.Drawing.Size(390, 203);
            this.pictureBoxGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGambar.TabIndex = 31;
            this.pictureBoxGambar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axWindowsMediaPlayerVideo);
            this.panel1.Location = new System.Drawing.Point(9, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 310);
            this.panel1.TabIndex = 32;
            // 
            // axWindowsMediaPlayerVideo
            // 
            this.axWindowsMediaPlayerVideo.Enabled = true;
            this.axWindowsMediaPlayerVideo.Location = new System.Drawing.Point(0, -1);
            this.axWindowsMediaPlayerVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayerVideo.Name = "axWindowsMediaPlayerVideo";
            this.axWindowsMediaPlayerVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerVideo.OcxState")));
            this.axWindowsMediaPlayerVideo.Size = new System.Drawing.Size(380, 306);
            this.axWindowsMediaPlayerVideo.TabIndex = 0;
            this.axWindowsMediaPlayerVideo.Enter += new System.EventHandler(this.axWindowsMediaPlayerVideo_Enter);
            // 
            // labelKomentar
            // 
            this.labelKomentar.AutoSize = true;
            this.labelKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKomentar.Location = new System.Drawing.Point(411, 152);
            this.labelKomentar.Name = "labelKomentar";
            this.labelKomentar.Size = new System.Drawing.Size(87, 17);
            this.labelKomentar.TabIndex = 33;
            this.labelKomentar.Text = "Komentar :";
            // 
            // listBoxKomentar
            // 
            this.listBoxKomentar.FormattingEnabled = true;
            this.listBoxKomentar.Location = new System.Drawing.Point(414, 171);
            this.listBoxKomentar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxKomentar.Name = "listBoxKomentar";
            this.listBoxKomentar.Size = new System.Drawing.Size(262, 277);
            this.listBoxKomentar.TabIndex = 34;
            // 
            // labelHasilCaption
            // 
            this.labelHasilCaption.AutoSize = true;
            this.labelHasilCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasilCaption.Location = new System.Drawing.Point(411, 75);
            this.labelHasilCaption.Name = "labelHasilCaption";
            this.labelHasilCaption.Size = new System.Drawing.Size(17, 17);
            this.labelHasilCaption.TabIndex = 35;
            this.labelHasilCaption.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTextBox);
            this.panel2.Controls.Add(this.buttonBatal);
            this.panel2.Controls.Add(this.textBoxKomen);
            this.panel2.Controls.Add(this.buttonTambahKomentar);
            this.panel2.Location = new System.Drawing.Point(414, 460);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 95);
            this.panel2.TabIndex = 38;
            // 
            // labelTextBox
            // 
            this.labelTextBox.AutoSize = true;
            this.labelTextBox.BackColor = System.Drawing.Color.White;
            this.labelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextBox.Location = new System.Drawing.Point(3, 4);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(166, 17);
            this.labelTextBox.TabIndex = 42;
            this.labelTextBox.Text = "Tambahkan Komentar";
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.Location = new System.Drawing.Point(76, 65);
            this.buttonBatal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(90, 28);
            this.buttonBatal.TabIndex = 40;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = false;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // textBoxKomen
            // 
            this.textBoxKomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxKomen.Location = new System.Drawing.Point(0, 0);
            this.textBoxKomen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKomen.Multiline = true;
            this.textBoxKomen.Name = "textBoxKomen";
            this.textBoxKomen.Size = new System.Drawing.Size(262, 56);
            this.textBoxKomen.TabIndex = 39;
            this.textBoxKomen.Click += new System.EventHandler(this.textBoxKomen_Click);
            // 
            // buttonTambahKomentar
            // 
            this.buttonTambahKomentar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahKomentar.Location = new System.Drawing.Point(171, 65);
            this.buttonTambahKomentar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTambahKomentar.Name = "buttonTambahKomentar";
            this.buttonTambahKomentar.Size = new System.Drawing.Size(90, 28);
            this.buttonTambahKomentar.TabIndex = 38;
            this.buttonTambahKomentar.Text = "Komentar";
            this.buttonTambahKomentar.UseVisualStyleBackColor = false;
            this.buttonTambahKomentar.Click += new System.EventHandler(this.buttonTambahKomentar_Click);
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(414, 98);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(56, 19);
            this.buttonLike.TabIndex = 39;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // labelTotalLike
            // 
            this.labelTotalLike.AutoSize = true;
            this.labelTotalLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLike.Location = new System.Drawing.Point(411, 119);
            this.labelTotalLike.Name = "labelTotalLike";
            this.labelTotalLike.Size = new System.Drawing.Size(88, 17);
            this.labelTotalLike.TabIndex = 40;
            this.labelTotalLike.Text = "Total Likes";
            // 
            // FormDetailKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 587);
            this.Controls.Add(this.labelTotalLike);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelHasilCaption);
            this.Controls.Add(this.listBoxKomentar);
            this.Controls.Add(this.labelKomentar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxGambar);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.panelKonten);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDetailKonten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKomen";
            this.Load += new System.EventHandler(this.FormDetailKonten_Load);
            this.panelKonten.ResumeLayout(false);
            this.panelKonten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGambar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerVideo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.Label labelKomen;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKomentar;
        private System.Windows.Forms.Label labelHasilCaption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTextBox;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.TextBox textBoxKomen;
        private System.Windows.Forms.Button buttonTambahKomentar;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerVideo;
        public System.Windows.Forms.ListBox listBoxKomentar;
        public System.Windows.Forms.PictureBox pictureBoxGambar;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Label labelTotalLike;
    }
}