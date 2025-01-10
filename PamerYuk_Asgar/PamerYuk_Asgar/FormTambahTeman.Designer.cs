namespace PamerYuk_Asgar
{
    partial class FormTambahTeman
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
            this.dataGridViewTeman = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNama = new System.Windows.Forms.Label();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTambahKonten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeman
            // 
            this.dataGridViewTeman.AllowUserToAddRows = false;
            this.dataGridViewTeman.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username});
            this.dataGridViewTeman.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewTeman.Location = new System.Drawing.Point(11, 107);
            this.dataGridViewTeman.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTeman.Name = "dataGridViewTeman";
            this.dataGridViewTeman.RowHeadersWidth = 51;
            this.dataGridViewTeman.RowTemplate.Height = 24;
            this.dataGridViewTeman.Size = new System.Drawing.Size(405, 212);
            this.dataGridViewTeman.TabIndex = 0;
            this.dataGridViewTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeman_CellContentClick);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.Transparent;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(18, 74);
            this.labelNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(135, 16);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Cari berdasarkan :";
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Items.AddRange(new object[] {
            "Username",
            "Kota",
            "Organisasi"});
            this.comboBoxCari.Location = new System.Drawing.Point(158, 72);
            this.comboBoxCari.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(81, 21);
            this.comboBoxCari.TabIndex = 3;
            this.comboBoxCari.SelectedIndexChanged += new System.EventHandler(this.comboBoxCari_SelectedIndexChanged);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(247, 73);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(146, 20);
            this.textBoxCari.TabIndex = 4;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PamerYuk_Asgar.Properties.Resources.Asset_3;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTambahKonten
            // 
            this.buttonTambahKonten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahKonten.Location = new System.Drawing.Point(226, 329);
            this.buttonTambahKonten.Name = "buttonTambahKonten";
            this.buttonTambahKonten.Size = new System.Drawing.Size(190, 34);
            this.buttonTambahKonten.TabIndex = 42;
            this.buttonTambahKonten.Text = "Friend Request";
            this.buttonTambahKonten.UseVisualStyleBackColor = false;
            this.buttonTambahKonten.Click += new System.EventHandler(this.buttonTambahKonten_Click);
            // 
            // FormTambahTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PamerYuk_Asgar.Properties.Resources.bgregister;
            this.ClientSize = new System.Drawing.Size(428, 375);
            this.Controls.Add(this.buttonTambahKonten);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.comboBoxCari);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.dataGridViewTeman);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTambahTeman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahTeman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTambahTeman_FormClosing);
            this.Load += new System.EventHandler(this.FormTambahTeman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeman;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonTambahKonten;
    }
}