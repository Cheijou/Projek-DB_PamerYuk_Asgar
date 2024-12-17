namespace PamerYuk_Asgar
{
    partial class FormOrganisasi
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
            this.buttonTambahOrganisasi = new System.Windows.Forms.Button();
            this.labelOrganisasi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKota = new System.Windows.Forms.ComboBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelKisahHidup = new System.Windows.Forms.Panel();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelKota = new System.Windows.Forms.Label();
            this.panelKisahHidup.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTambahOrganisasi
            // 
            this.buttonTambahOrganisasi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahOrganisasi.Location = new System.Drawing.Point(349, 285);
            this.buttonTambahOrganisasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambahOrganisasi.Name = "buttonTambahOrganisasi";
            this.buttonTambahOrganisasi.Size = new System.Drawing.Size(147, 47);
            this.buttonTambahOrganisasi.TabIndex = 31;
            this.buttonTambahOrganisasi.Text = "Tambah Organisasi";
            this.buttonTambahOrganisasi.UseVisualStyleBackColor = false;
            this.buttonTambahOrganisasi.Click += new System.EventHandler(this.buttonTambahOrganisasi_Click);
            // 
            // labelOrganisasi
            // 
            this.labelOrganisasi.AutoSize = true;
            this.labelOrganisasi.Font = new System.Drawing.Font("Arial Narrow", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrganisasi.Location = new System.Drawing.Point(132, -1);
            this.labelOrganisasi.Name = "labelOrganisasi";
            this.labelOrganisasi.Size = new System.Drawing.Size(223, 55);
            this.labelOrganisasi.TabIndex = 3;
            this.labelOrganisasi.Text = "Organisasi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Selamat Datang :";
            // 
            // comboBoxKota
            // 
            this.comboBoxKota.FormattingEnabled = true;
            this.comboBoxKota.Location = new System.Drawing.Point(137, 207);
            this.comboBoxKota.Name = "comboBoxKota";
            this.comboBoxKota.Size = new System.Drawing.Size(359, 24);
            this.comboBoxKota.TabIndex = 35;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(16, 152);
            this.labelNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(118, 16);
            this.labelNama.TabIndex = 34;
            this.labelNama.Text = "Nama Organisasi :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(134, 94);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(70, 16);
            this.labelUsername.TabIndex = 33;
            this.labelUsername.Text = "Username";
            // 
            // panelKisahHidup
            // 
            this.panelKisahHidup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelKisahHidup.Controls.Add(this.labelOrganisasi);
            this.panelKisahHidup.Location = new System.Drawing.Point(11, 15);
            this.panelKisahHidup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelKisahHidup.Name = "panelKisahHidup";
            this.panelKisahHidup.Size = new System.Drawing.Size(508, 54);
            this.panelKisahHidup.TabIndex = 32;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(141, 152);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(355, 22);
            this.textBoxNama.TabIndex = 39;
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Location = new System.Drawing.Point(16, 210);
            this.labelKota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(40, 16);
            this.labelKota.TabIndex = 40;
            this.labelKota.Text = "Kota :";
            // 
            // FormOrganisasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 356);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.buttonTambahOrganisasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKota);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.panelKisahHidup);
            this.Name = "FormOrganisasi";
            this.Text = "FormOrganisasi";
            this.Load += new System.EventHandler(this.FormOrganisasi_Load);
            this.panelKisahHidup.ResumeLayout(false);
            this.panelKisahHidup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTambahOrganisasi;
        private System.Windows.Forms.Label labelOrganisasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKota;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelKisahHidup;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelKota;
    }
}