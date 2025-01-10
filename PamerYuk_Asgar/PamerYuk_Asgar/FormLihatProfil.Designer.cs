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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTglLahir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKota = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewKisah = new System.Windows.Forms.DataGridView();
            this.Organisasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThAwal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThAkhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisah)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 153);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(308, 52);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 20);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal Lahir :";
            // 
            // labelTglLahir
            // 
            this.labelTglLahir.AutoSize = true;
            this.labelTglLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglLahir.Location = new System.Drawing.Point(309, 93);
            this.labelTglLahir.Name = "labelTglLahir";
            this.labelTglLahir.Size = new System.Drawing.Size(73, 20);
            this.labelTglLahir.TabIndex = 4;
            this.labelTglLahir.Text = "TglLahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asal Kota :";
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKota.Location = new System.Drawing.Point(316, 137);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(43, 18);
            this.labelKota.TabIndex = 6;
            this.labelKota.Text = "Kota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kisah Hidup :";
            // 
            // dataGridViewKisah
            // 
            this.dataGridViewKisah.AllowUserToAddRows = false;
            this.dataGridViewKisah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKisah.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Organisasi,
            this.Kota,
            this.ThAwal,
            this.ThAkhir,
            this.Deskripsi});
            this.dataGridViewKisah.Location = new System.Drawing.Point(16, 224);
            this.dataGridViewKisah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewKisah.Name = "dataGridViewKisah";
            this.dataGridViewKisah.RowHeadersWidth = 51;
            this.dataGridViewKisah.RowTemplate.Height = 24;
            this.dataGridViewKisah.Size = new System.Drawing.Size(425, 171);
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
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(130, 410);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(177, 32);
            this.buttonTambah.TabIndex = 9;
            this.buttonTambah.Text = "Tambah Teman";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // FormLihatProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 452);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewKisah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTglLahir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLihatProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLihatProfil";
            this.Load += new System.EventHandler(this.FormLihatProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisah)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewKisah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organisasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThAwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThAkhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deskripsi;
        private System.Windows.Forms.Button buttonTambah;
    }
}