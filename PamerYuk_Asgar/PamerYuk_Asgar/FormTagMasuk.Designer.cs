namespace PamerYuk_Asgar
{
    partial class FormTagMasuk
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
            this.dataGridViewKonten = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalUpload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKonten
            // 
            this.dataGridViewKonten.AllowUserToAddRows = false;
            this.dataGridViewKonten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewKonten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKonten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Caption,
            this.TanggalUpload,
            this.Id,
            this.Foto});
            this.dataGridViewKonten.Location = new System.Drawing.Point(14, 157);
            this.dataGridViewKonten.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKonten.Name = "dataGridViewKonten";
            this.dataGridViewKonten.RowHeadersWidth = 51;
            this.dataGridViewKonten.RowTemplate.Height = 24;
            this.dataGridViewKonten.Size = new System.Drawing.Size(775, 304);
            this.dataGridViewKonten.TabIndex = 55;
            this.dataGridViewKonten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKonten_CellContentClick);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // Caption
            // 
            this.Caption.HeaderText = "Caption";
            this.Caption.MinimumWidth = 6;
            this.Caption.Name = "Caption";
            this.Caption.Width = 125;
            // 
            // TanggalUpload
            // 
            this.TanggalUpload.HeaderText = "Tanggal Upload";
            this.TanggalUpload.MinimumWidth = 6;
            this.TanggalUpload.Name = "TanggalUpload";
            this.TanggalUpload.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Foto.Width = 125;
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTutup.Location = new System.Drawing.Point(337, 475);
            this.buttonTutup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(147, 47);
            this.buttonTutup.TabIndex = 56;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PamerYuk_Asgar.Properties.Resources.konten_1_10_2025;
            this.pictureBox2.Location = new System.Drawing.Point(222, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // FormTagMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PamerYuk_Asgar.Properties.Resources.bg_detail_konten;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.dataGridViewKonten);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonTutup);
            this.Name = "FormTagMasuk";
            this.Text = "FormTagMasuk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTagMasuk_FormClosing);
            this.Load += new System.EventHandler(this.FormTagMasuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKonten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caption;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalUpload;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}