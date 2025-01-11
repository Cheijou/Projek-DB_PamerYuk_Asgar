namespace PamerYuk_Asgar
{
    partial class FormKontenSaya
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
            this.buttonTambahKonten = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKonten
            // 
            this.dataGridViewKonten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewKonten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKonten.Location = new System.Drawing.Point(9, 76);
            this.dataGridViewKonten.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKonten.Name = "dataGridViewKonten";
            this.dataGridViewKonten.RowHeadersWidth = 51;
            this.dataGridViewKonten.RowTemplate.Height = 24;
            this.dataGridViewKonten.Size = new System.Drawing.Size(581, 247);
            this.dataGridViewKonten.TabIndex = 8;
            this.dataGridViewKonten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKonten_CellContentClick);
            // 
            // buttonTambahKonten
            // 
            this.buttonTambahKonten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahKonten.Location = new System.Drawing.Point(9, 337);
            this.buttonTambahKonten.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambahKonten.Name = "buttonTambahKonten";
            this.buttonTambahKonten.Size = new System.Drawing.Size(110, 38);
            this.buttonTambahKonten.TabIndex = 7;
            this.buttonTambahKonten.Text = "Tambah Konten";
            this.buttonTambahKonten.UseVisualStyleBackColor = false;
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTutup.Location = new System.Drawing.Point(482, 337);
            this.buttonTutup.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(110, 38);
            this.buttonTutup.TabIndex = 10;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PamerYuk_Asgar.Properties.Resources.Asset_1;
            this.pictureBox2.Location = new System.Drawing.Point(77, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(440, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // FormKontenSaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PamerYuk_Asgar.Properties.Resources.bg_konten;
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewKonten);
            this.Controls.Add(this.buttonTambahKonten);
            this.Controls.Add(this.buttonTutup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKontenSaya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKontenSaya";
            this.Load += new System.EventHandler(this.FormKontenSaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKonten;
        private System.Windows.Forms.Button buttonTambahKonten;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}