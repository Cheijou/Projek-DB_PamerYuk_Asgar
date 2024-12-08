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
            this.labelCari = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeman
            // 
            this.dataGridViewTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeman.Location = new System.Drawing.Point(9, 80);
            this.dataGridViewTeman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTeman.Name = "dataGridViewTeman";
            this.dataGridViewTeman.RowHeadersWidth = 51;
            this.dataGridViewTeman.RowTemplate.Height = 24;
            this.dataGridViewTeman.Size = new System.Drawing.Size(582, 275);
            this.dataGridViewTeman.TabIndex = 0;
            this.dataGridViewTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeman_CellContentClick);
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCari.Location = new System.Drawing.Point(198, 7);
            this.labelCari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(228, 44);
            this.labelCari.TabIndex = 1;
            this.labelCari.Text = "Cari Teman";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(129, 58);
            this.labelNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(93, 13);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Cari berdasarkan :";
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Items.AddRange(new object[] {
            "ID",
            "Username"});
            this.comboBoxCari.Location = new System.Drawing.Point(220, 56);
            this.comboBoxCari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(81, 21);
            this.comboBoxCari.TabIndex = 3;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(304, 57);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(146, 20);
            this.textBoxCari.TabIndex = 4;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // FormTambahTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.comboBoxCari);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelCari);
            this.Controls.Add(this.dataGridViewTeman);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTambahTeman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTambahTeman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTambahTeman_FormClosing);
            this.Load += new System.EventHandler(this.FormTambahTeman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeman;
        private System.Windows.Forms.Label labelCari;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.TextBox textBoxCari;
    }
}