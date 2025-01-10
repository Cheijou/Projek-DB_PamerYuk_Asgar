namespace PamerYuk_Asgar
{
    partial class FormKisahHidup
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
            this.buttonSimpanKisahHidup = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelOrganisasi = new System.Windows.Forms.Label();
            this.comboBoxOrganisasi = new System.Windows.Forms.ComboBox();
            this.labelAwal = new System.Windows.Forms.Label();
            this.buttonTambahOrganisasi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAkhir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDeskripsi = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.textBoxTanggalAwal = new System.Windows.Forms.TextBox();
            this.textBoxTanggalAkhir = new System.Windows.Forms.TextBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.idOrganisasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thawal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.labelKota = new System.Windows.Forms.Label();
            this.buttonHapusKisah = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSimpanKisahHidup
            // 
            this.buttonSimpanKisahHidup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSimpanKisahHidup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpanKisahHidup.Location = new System.Drawing.Point(289, 603);
            this.buttonSimpanKisahHidup.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimpanKisahHidup.Name = "buttonSimpanKisahHidup";
            this.buttonSimpanKisahHidup.Size = new System.Drawing.Size(110, 38);
            this.buttonSimpanKisahHidup.TabIndex = 7;
            this.buttonSimpanKisahHidup.Text = "Simpan Kisah Hidup";
            this.buttonSimpanKisahHidup.UseVisualStyleBackColor = false;
            this.buttonSimpanKisahHidup.Click += new System.EventHandler(this.buttonSimpanKisahHidup_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(225, 75);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(82, 20);
            this.labelUsername.TabIndex = 19;
            this.labelUsername.Text = "Username";
            // 
            // labelOrganisasi
            // 
            this.labelOrganisasi.AutoSize = true;
            this.labelOrganisasi.BackColor = System.Drawing.Color.Transparent;
            this.labelOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrganisasi.Location = new System.Drawing.Point(12, 107);
            this.labelOrganisasi.Name = "labelOrganisasi";
            this.labelOrganisasi.Size = new System.Drawing.Size(84, 15);
            this.labelOrganisasi.TabIndex = 21;
            this.labelOrganisasi.Text = "Organisasi :";
            // 
            // comboBoxOrganisasi
            // 
            this.comboBoxOrganisasi.FormattingEnabled = true;
            this.comboBoxOrganisasi.Location = new System.Drawing.Point(101, 107);
            this.comboBoxOrganisasi.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOrganisasi.Name = "comboBoxOrganisasi";
            this.comboBoxOrganisasi.Size = new System.Drawing.Size(300, 21);
            this.comboBoxOrganisasi.TabIndex = 22;
            this.comboBoxOrganisasi.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrganisasi_SelectedIndexChanged);
            // 
            // labelAwal
            // 
            this.labelAwal.AutoSize = true;
            this.labelAwal.BackColor = System.Drawing.Color.Transparent;
            this.labelAwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAwal.Location = new System.Drawing.Point(14, 187);
            this.labelAwal.Name = "labelAwal";
            this.labelAwal.Size = new System.Drawing.Size(89, 15);
            this.labelAwal.TabIndex = 23;
            this.labelAwal.Text = "Tahun Awal :";
            // 
            // buttonTambahOrganisasi
            // 
            this.buttonTambahOrganisasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTambahOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahOrganisasi.Location = new System.Drawing.Point(100, 133);
            this.buttonTambahOrganisasi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambahOrganisasi.Name = "buttonTambahOrganisasi";
            this.buttonTambahOrganisasi.Size = new System.Drawing.Size(125, 24);
            this.buttonTambahOrganisasi.TabIndex = 24;
            this.buttonTambahOrganisasi.Text = "Tambah Organisasi";
            this.buttonTambahOrganisasi.UseVisualStyleBackColor = false;
            this.buttonTambahOrganisasi.Click += new System.EventHandler(this.buttonTambahOrganisasi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Selamat Datang!";
            // 
            // labelAkhir
            // 
            this.labelAkhir.AutoSize = true;
            this.labelAkhir.BackColor = System.Drawing.Color.Transparent;
            this.labelAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAkhir.Location = new System.Drawing.Point(217, 185);
            this.labelAkhir.Name = "labelAkhir";
            this.labelAkhir.Size = new System.Drawing.Size(91, 15);
            this.labelAkhir.TabIndex = 28;
            this.labelAkhir.Text = "Tahun Akhir :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Deskirpsi :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxDeskripsi
            // 
            this.textBoxDeskripsi.Location = new System.Drawing.Point(45, 240);
            this.textBoxDeskripsi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDeskripsi.Multiline = true;
            this.textBoxDeskripsi.Name = "textBoxDeskripsi";
            this.textBoxDeskripsi.Size = new System.Drawing.Size(319, 110);
            this.textBoxDeskripsi.TabIndex = 30;
            this.textBoxDeskripsi.TextChanged += new System.EventHandler(this.textBoxDeskripsi_TextChanged);
            // 
            // textBoxTanggalAwal
            // 
            this.textBoxTanggalAwal.Location = new System.Drawing.Point(113, 185);
            this.textBoxTanggalAwal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTanggalAwal.Name = "textBoxTanggalAwal";
            this.textBoxTanggalAwal.Size = new System.Drawing.Size(76, 20);
            this.textBoxTanggalAwal.TabIndex = 26;
            // 
            // textBoxTanggalAkhir
            // 
            this.textBoxTanggalAkhir.Location = new System.Drawing.Point(311, 185);
            this.textBoxTanggalAkhir.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTanggalAkhir.Name = "textBoxTanggalAkhir";
            this.textBoxTanggalAkhir.Size = new System.Drawing.Size(76, 20);
            this.textBoxTanggalAkhir.TabIndex = 27;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrganisasi,
            this.organisasi,
            this.kota,
            this.username,
            this.thawal,
            this.thakhir,
            this.deskripsi});
            this.dataGridViewData.Location = new System.Drawing.Point(7, 388);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(392, 206);
            this.dataGridViewData.TabIndex = 32;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            // 
            // idOrganisasi
            // 
            this.idOrganisasi.HeaderText = "IdOrganisasi";
            this.idOrganisasi.MinimumWidth = 6;
            this.idOrganisasi.Name = "idOrganisasi";
            this.idOrganisasi.Width = 125;
            // 
            // organisasi
            // 
            this.organisasi.HeaderText = "Organisasi";
            this.organisasi.MinimumWidth = 6;
            this.organisasi.Name = "organisasi";
            this.organisasi.Width = 125;
            // 
            // kota
            // 
            this.kota.HeaderText = "Kota";
            this.kota.MinimumWidth = 6;
            this.kota.Name = "kota";
            this.kota.Width = 125;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 125;
            // 
            // thawal
            // 
            this.thawal.HeaderText = "Thawal";
            this.thawal.MinimumWidth = 6;
            this.thawal.Name = "thawal";
            this.thawal.Width = 125;
            // 
            // thakhir
            // 
            this.thakhir.HeaderText = "Thakhir";
            this.thakhir.MinimumWidth = 6;
            this.thakhir.Name = "thakhir";
            this.thakhir.Width = 125;
            // 
            // deskripsi
            // 
            this.deskripsi.HeaderText = "Deskripsi";
            this.deskripsi.MinimumWidth = 6;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Width = 125;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(138, 359);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(125, 20);
            this.buttonTambah.TabIndex = 34;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKota.Location = new System.Drawing.Point(100, 161);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(38, 16);
            this.labelKota.TabIndex = 36;
            this.labelKota.Text = "Kota";
            // 
            // buttonHapusKisah
            // 
            this.buttonHapusKisah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHapusKisah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusKisah.Location = new System.Drawing.Point(7, 605);
            this.buttonHapusKisah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHapusKisah.Name = "buttonHapusKisah";
            this.buttonHapusKisah.Size = new System.Drawing.Size(110, 38);
            this.buttonHapusKisah.TabIndex = 37;
            this.buttonHapusKisah.Text = "Hapus";
            this.buttonHapusKisah.UseVisualStyleBackColor = false;
            this.buttonHapusKisah.Click += new System.EventHandler(this.buttonHapusKisah_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Asal Kota :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PamerYuk_Asgar.Properties.Resources.kisah_hidup_1_10_2025;
            this.pictureBox2.Location = new System.Drawing.Point(41, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(331, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // FormKisahHidup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PamerYuk_Asgar.Properties.Resources.bg_kisah_hidup;
            this.ClientSize = new System.Drawing.Size(415, 654);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonHapusKisah);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.textBoxDeskripsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAkhir);
            this.Controls.Add(this.textBoxTanggalAkhir);
            this.Controls.Add(this.textBoxTanggalAwal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTambahOrganisasi);
            this.Controls.Add(this.labelAwal);
            this.Controls.Add(this.comboBoxOrganisasi);
            this.Controls.Add(this.labelOrganisasi);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonSimpanKisahHidup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKisahHidup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKisahHidup";
            this.Load += new System.EventHandler(this.FormKisahHidup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSimpanKisahHidup;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelOrganisasi;
        private System.Windows.Forms.ComboBox comboBoxOrganisasi;
        private System.Windows.Forms.Label labelAwal;
        private System.Windows.Forms.Button buttonTambahOrganisasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAkhir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDeskripsi;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox textBoxTanggalAwal;
        private System.Windows.Forms.TextBox textBoxTanggalAkhir;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrganisasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn thawal;
        private System.Windows.Forms.DataGridViewTextBoxColumn thakhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsi;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.Button buttonHapusKisah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}