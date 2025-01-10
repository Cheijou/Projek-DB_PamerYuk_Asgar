namespace PamerYuk_Asgar
{
    partial class FormOrganisasi
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
            this.buttonTambahOrganisasi = new System.Windows.Forms.Button();
            this.comboBoxKota = new System.Windows.Forms.ComboBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelKota = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTambahOrganisasi
            // 
            this.buttonTambahOrganisasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTambahOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahOrganisasi.Location = new System.Drawing.Point(95, 177);
            this.buttonTambahOrganisasi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambahOrganisasi.Name = "buttonTambahOrganisasi";
            this.buttonTambahOrganisasi.Size = new System.Drawing.Size(123, 56);
            this.buttonTambahOrganisasi.TabIndex = 31;
            this.buttonTambahOrganisasi.Text = "Tambah Organisasi";
            this.buttonTambahOrganisasi.UseVisualStyleBackColor = false;
            this.buttonTambahOrganisasi.Click += new System.EventHandler(this.buttonTambahOrganisasi_Click);
            // 
            // comboBoxKota
            // 
            this.comboBoxKota.FormattingEnabled = true;
            this.comboBoxKota.Location = new System.Drawing.Point(152, 133);
            this.comboBoxKota.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKota.Name = "comboBoxKota";
            this.comboBoxKota.Size = new System.Drawing.Size(136, 21);
            this.comboBoxKota.TabIndex = 35;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.Transparent;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(12, 94);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(135, 16);
            this.labelNama.TabIndex = 34;
            this.labelNama.Text = "Nama Organisasi :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(152, 93);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(165, 20);
            this.textBoxNama.TabIndex = 39;
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.BackColor = System.Drawing.Color.Transparent;
            this.labelKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKota.Location = new System.Drawing.Point(91, 131);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(56, 20);
            this.labelKota.TabIndex = 40;
            this.labelKota.Text = "Kota :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PamerYuk_Asgar.Properties.Resources.organisasi_text;
            this.pictureBox1.Location = new System.Drawing.Point(31, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FormOrganisasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::PamerYuk_Asgar.Properties.Resources.bgregister;
            this.ClientSize = new System.Drawing.Size(339, 244);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.buttonTambahOrganisasi);
            this.Controls.Add(this.comboBoxKota);
            this.Controls.Add(this.labelNama);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOrganisasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrganisasi";
            this.Load += new System.EventHandler(this.FormOrganisasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTambahOrganisasi;
        private System.Windows.Forms.ComboBox comboBoxKota;
        private System.Windows.Forms.Label labelNama;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}