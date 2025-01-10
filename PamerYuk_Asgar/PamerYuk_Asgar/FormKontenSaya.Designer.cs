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
            this.labelKonten = new System.Windows.Forms.Label();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.panelKonten = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonten)).BeginInit();
            this.panelKonten.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKonten
            // 
            this.dataGridViewKonten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKonten.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewKonten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKonten.Name = "dataGridViewKonten";
            this.dataGridViewKonten.RowHeadersWidth = 51;
            this.dataGridViewKonten.RowTemplate.Height = 24;
            this.dataGridViewKonten.Size = new System.Drawing.Size(775, 340);
            this.dataGridViewKonten.TabIndex = 8;
            this.dataGridViewKonten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKonten_CellContentClick);
            // 
            // buttonTambahKonten
            // 
            this.buttonTambahKonten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahKonten.Location = new System.Drawing.Point(12, 415);
            this.buttonTambahKonten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambahKonten.Name = "buttonTambahKonten";
            this.buttonTambahKonten.Size = new System.Drawing.Size(147, 47);
            this.buttonTambahKonten.TabIndex = 7;
            this.buttonTambahKonten.Text = "Tambah Konten";
            this.buttonTambahKonten.UseVisualStyleBackColor = false;
            // 
            // labelKonten
            // 
            this.labelKonten.AutoSize = true;
            this.labelKonten.Font = new System.Drawing.Font("Arial Narrow", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKonten.Location = new System.Drawing.Point(307, 0);
            this.labelKonten.Name = "labelKonten";
            this.labelKonten.Size = new System.Drawing.Size(158, 55);
            this.labelKonten.TabIndex = 3;
            this.labelKonten.Text = "Konten";
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTutup.Location = new System.Drawing.Point(642, 415);
            this.buttonTutup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(147, 47);
            this.buttonTutup.TabIndex = 10;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            // 
            // panelKonten
            // 
            this.panelKonten.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelKonten.Controls.Add(this.labelKonten);
            this.panelKonten.Location = new System.Drawing.Point(11, 12);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(776, 54);
            this.panelKonten.TabIndex = 9;
            // 
            // FormKontenSaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.dataGridViewKonten);
            this.Controls.Add(this.buttonTambahKonten);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.panelKonten);
            this.Name = "FormKontenSaya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKontenSaya";
            this.Load += new System.EventHandler(this.FormKontenSaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonten)).EndInit();
            this.panelKonten.ResumeLayout(false);
            this.panelKonten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKonten;
        private System.Windows.Forms.Button buttonTambahKonten;
        private System.Windows.Forms.Label labelKonten;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Panel panelKonten;
    }
}