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
            this.buttonRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeman
            // 
            this.dataGridViewTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeman.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewTeman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTeman.Name = "dataGridViewTeman";
            this.dataGridViewTeman.RowHeadersWidth = 51;
            this.dataGridViewTeman.RowTemplate.Height = 24;
            this.dataGridViewTeman.Size = new System.Drawing.Size(776, 297);
            this.dataGridViewTeman.TabIndex = 0;
            this.dataGridViewTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeman_CellContentClick);
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCari.Location = new System.Drawing.Point(264, 9);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(277, 54);
            this.labelCari.TabIndex = 1;
            this.labelCari.Text = "Cari Teman";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(172, 71);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(117, 16);
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
            this.comboBoxCari.Location = new System.Drawing.Point(293, 69);
            this.comboBoxCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(107, 24);
            this.comboBoxCari.TabIndex = 3;
            this.comboBoxCari.SelectedIndexChanged += new System.EventHandler(this.comboBoxCari_SelectedIndexChanged);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(405, 70);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(193, 22);
            this.textBoxCari.TabIndex = 4;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(626, 400);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(162, 39);
            this.buttonRequest.TabIndex = 5;
            this.buttonRequest.Text = "Friend Request";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // FormTambahTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.comboBoxCari);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelCari);
            this.Controls.Add(this.dataGridViewTeman);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonRequest;
    }
}