namespace PamerYuk_Asgar
{
    partial class FormFriendRequest
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
            this.dataGridViewPermintaan = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermintaan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPermintaan
            // 
            this.dataGridViewPermintaan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewPermintaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermintaan.Location = new System.Drawing.Point(19, 66);
            this.dataGridViewPermintaan.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPermintaan.Name = "dataGridViewPermintaan";
            this.dataGridViewPermintaan.RowHeadersWidth = 51;
            this.dataGridViewPermintaan.RowTemplate.Height = 24;
            this.dataGridViewPermintaan.Size = new System.Drawing.Size(425, 257);
            this.dataGridViewPermintaan.TabIndex = 1;
            this.dataGridViewPermintaan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermintaan_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PamerYuk_Asgar.Properties.Resources.permintaan_pertemanan_1_10_2025;
            this.pictureBox2.Location = new System.Drawing.Point(9, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(435, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormFriendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PamerYuk_Asgar.Properties.Resources.bgregister;
            this.ClientSize = new System.Drawing.Size(458, 349);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewPermintaan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFriendRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFriendRequest";
            this.Load += new System.EventHandler(this.FormFriendRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermintaan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPermintaan;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}