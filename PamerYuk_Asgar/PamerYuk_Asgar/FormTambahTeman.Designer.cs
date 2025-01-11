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
            this.buttonFriendRequest = new System.Windows.Forms.Button();
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
            this.dataGridViewTeman.Location = new System.Drawing.Point(15, 132);
            this.dataGridViewTeman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTeman.Name = "dataGridViewTeman";
            this.dataGridViewTeman.RowHeadersWidth = 51;
            this.dataGridViewTeman.RowTemplate.Height = 24;
            this.dataGridViewTeman.Size = new System.Drawing.Size(540, 261);
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
            this.labelNama.Location = new System.Drawing.Point(24, 91);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(165, 20);
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
            this.comboBoxCari.Location = new System.Drawing.Point(211, 89);
            this.comboBoxCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(107, 24);
            this.comboBoxCari.TabIndex = 3;
            this.comboBoxCari.SelectedIndexChanged += new System.EventHandler(this.comboBoxCari_SelectedIndexChanged);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(329, 90);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(193, 22);
            this.textBoxCari.TabIndex = 4;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PamerYuk_Asgar.Properties.Resources.Asset_3;
            this.pictureBox1.Location = new System.Drawing.Point(81, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // buttonFriendRequest
            // 
            this.buttonFriendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonFriendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriendRequest.Location = new System.Drawing.Point(301, 405);
            this.buttonFriendRequest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFriendRequest.Name = "buttonFriendRequest";
            this.buttonFriendRequest.Size = new System.Drawing.Size(253, 42);
            this.buttonFriendRequest.TabIndex = 42;
            this.buttonFriendRequest.Text = "Friend Request";
            this.buttonFriendRequest.UseVisualStyleBackColor = false;
            this.buttonFriendRequest.Click += new System.EventHandler(this.buttonFriendRequest_Click);
            // 
            // FormTambahTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PamerYuk_Asgar.Properties.Resources.bgregister;
            this.ClientSize = new System.Drawing.Size(571, 462);
            this.Controls.Add(this.buttonFriendRequest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.comboBoxCari);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.dataGridViewTeman);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonFriendRequest;
    }
}