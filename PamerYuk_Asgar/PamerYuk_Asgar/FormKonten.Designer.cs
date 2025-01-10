namespace PamerYuk_Asgar
{
    partial class FormKonten
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
            this.buttonKontenSaya = new System.Windows.Forms.Button();
            this.buttonTambahKonten = new System.Windows.Forms.Button();
            this.dataGridViewKonten = new System.Windows.Forms.DataGridView();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKontenSaya
            // 
            this.buttonKontenSaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonKontenSaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKontenSaya.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonKontenSaya.Location = new System.Drawing.Point(10, 337);
            this.buttonKontenSaya.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKontenSaya.Name = "buttonKontenSaya";
            this.buttonKontenSaya.Size = new System.Drawing.Size(110, 38);
            this.buttonKontenSaya.TabIndex = 0;
            this.buttonKontenSaya.Text = "Konten Saya";
            this.buttonKontenSaya.UseVisualStyleBackColor = false;
            this.buttonKontenSaya.Click += new System.EventHandler(this.buttonKontenSaya_Click);
            // 
            // buttonTambahKonten
            // 
            this.buttonTambahKonten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahKonten.Location = new System.Drawing.Point(247, 337);
            this.buttonTambahKonten.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambahKonten.Name = "buttonTambahKonten";
            this.buttonTambahKonten.Size = new System.Drawing.Size(110, 38);
            this.buttonTambahKonten.TabIndex = 1;
            this.buttonTambahKonten.Text = "Tambah Konten";
            this.buttonTambahKonten.UseVisualStyleBackColor = false;
            this.buttonTambahKonten.Click += new System.EventHandler(this.buttonTambahKonten_Click);
            // 
            // dataGridViewKonten
            // 
            this.dataGridViewKonten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewKonten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKonten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewKonten.Location = new System.Drawing.Point(10, 75);
            this.dataGridViewKonten.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKonten.Name = "dataGridViewKonten";
            this.dataGridViewKonten.RowHeadersWidth = 51;
            this.dataGridViewKonten.RowTemplate.Height = 24;
            this.dataGridViewKonten.Size = new System.Drawing.Size(581, 248);
            this.dataGridViewKonten.TabIndex = 2;
            this.dataGridViewKonten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKonten_CellContentClick);
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
            this.buttonTutup.TabIndex = 5;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PamerYuk_Asgar.Properties.Resources.konten_1_10_2025;
            this.pictureBox2.Location = new System.Drawing.Point(162, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // FormKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PamerYuk_Asgar.Properties.Resources.bg_konten;
            this.ClientSize = new System.Drawing.Size(600, 385);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.dataGridViewKonten);
            this.Controls.Add(this.buttonTambahKonten);
            this.Controls.Add(this.buttonKontenSaya);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKonten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKonten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKonten_FormClosing);
            this.Load += new System.EventHandler(this.FormKonten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKontenSaya;
        private System.Windows.Forms.Button buttonTambahKonten;
        private System.Windows.Forms.DataGridView dataGridViewKonten;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}