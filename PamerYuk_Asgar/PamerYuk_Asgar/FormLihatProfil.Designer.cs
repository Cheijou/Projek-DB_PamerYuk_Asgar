namespace PamerYuk_Asgar
{
    partial class FormLihatProfil
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTglLahir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKota = new System.Windows.Forms.Label();
            this.labelKisah = new System.Windows.Forms.Label();
            this.dataGridViewKisah = new System.Windows.Forms.DataGridView();
            this.Organisasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThAwal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThAkhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelKonten = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(411, 64);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(68, 25);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal Lahir :";
            // 
            // labelTglLahir
            // 
            this.labelTglLahir.AutoSize = true;
            this.labelTglLahir.BackColor = System.Drawing.Color.Transparent;
            this.labelTglLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglLahir.Location = new System.Drawing.Point(412, 114);
            this.labelTglLahir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTglLahir.Name = "labelTglLahir";
            this.labelTglLahir.Size = new System.Drawing.Size(91, 25);
            this.labelTglLahir.TabIndex = 4;
            this.labelTglLahir.Text = "TglLahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asal Kota :";
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.BackColor = System.Drawing.Color.Transparent;
            this.labelKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKota.Location = new System.Drawing.Point(421, 169);
            this.labelKota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(51, 22);
            this.labelKota.TabIndex = 6;
            this.labelKota.Text = "Kota";
            // 
            // labelKisah
            // 
            this.labelKisah.AutoSize = true;
            this.labelKisah.BackColor = System.Drawing.Color.Transparent;
            this.labelKisah.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKisah.Location = new System.Drawing.Point(66, 232);
            this.labelKisah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKisah.Name = "labelKisah";
            this.labelKisah.Size = new System.Drawing.Size(165, 29);
            this.labelKisah.TabIndex = 7;
            this.labelKisah.Text = "Kisah Hidup ";
            this.labelKisah.Click += new System.EventHandler(this.labelKisah_Click);
            // 
            // dataGridViewKisah
            // 
            this.dataGridViewKisah.AllowUserToAddRows = false;
            this.dataGridViewKisah.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewKisah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKisah.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Organisasi,
            this.Kota,
            this.ThAwal,
            this.ThAkhir,
            this.Deskripsi});
            this.dataGridViewKisah.Location = new System.Drawing.Point(21, 276);
            this.dataGridViewKisah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKisah.Name = "dataGridViewKisah";
            this.dataGridViewKisah.RowHeadersWidth = 51;
            this.dataGridViewKisah.RowTemplate.Height = 24;
            this.dataGridViewKisah.Size = new System.Drawing.Size(567, 310);
            this.dataGridViewKisah.TabIndex = 8;
            // 
            // Organisasi
            // 
            this.Organisasi.HeaderText = "Organisasi";
            this.Organisasi.MinimumWidth = 6;
            this.Organisasi.Name = "Organisasi";
            this.Organisasi.Width = 125;
            // 
            // Kota
            // 
            this.Kota.HeaderText = "Kota";
            this.Kota.MinimumWidth = 6;
            this.Kota.Name = "Kota";
            this.Kota.Width = 90;
            // 
            // ThAwal
            // 
            this.ThAwal.HeaderText = "Tahun Awal";
            this.ThAwal.MinimumWidth = 6;
            this.ThAwal.Name = "ThAwal";
            this.ThAwal.Width = 70;
            // 
            // ThAkhir
            // 
            this.ThAkhir.HeaderText = "Tahun Akhir";
            this.ThAkhir.MinimumWidth = 6;
            this.ThAkhir.Name = "ThAkhir";
            this.ThAkhir.Width = 70;
            // 
            // Deskripsi
            // 
            this.Deskripsi.HeaderText = "Deskripsi";
            this.Deskripsi.MinimumWidth = 6;
            this.Deskripsi.Name = "Deskripsi";
            this.Deskripsi.Width = 500;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(169, 604);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(236, 39);
            this.buttonTambah.TabIndex = 9;
            this.buttonTambah.Text = "Tambah Teman";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelKonten
            // 
            this.labelKonten.AutoSize = true;
            this.labelKonten.BackColor = System.Drawing.Color.Transparent;
            this.labelKonten.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKonten.Location = new System.Drawing.Point(276, 232);
            this.labelKonten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKonten.Name = "labelKonten";
            this.labelKonten.Size = new System.Drawing.Size(108, 29);
            this.labelKonten.TabIndex = 10;
            this.labelKonten.Text = "Konten ";
            this.labelKonten.Click += new System.EventHandler(this.labelKonten_Click);
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.BackColor = System.Drawing.Color.Transparent;
            this.labelTag.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(465, 232);
            this.labelTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(53, 29);
            this.labelTag.TabIndex = 11;
            this.labelTag.Text = "Tag";
            this.labelTag.Click += new System.EventHandler(this.labelTag_Click);
            // 
            // FormLihatProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PamerYuk_Asgar.Properties.Resources.bgregister;
            this.ClientSize = new System.Drawing.Size(605, 666);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.labelKonten);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewKisah);
            this.Controls.Add(this.labelKisah);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTglLahir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLihatProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLihatProfil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLihatProfil_FormClosing);
            this.Load += new System.EventHandler(this.FormLihatProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTglLahir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.Label labelKisah;
        private System.Windows.Forms.DataGridView dataGridViewKisah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organisasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThAwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThAkhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deskripsi;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label labelKonten;
        private System.Windows.Forms.Label labelTag;
    }
}