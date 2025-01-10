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
            this.labelKonten = new System.Windows.Forms.Label();
            this.panelKonten = new System.Windows.Forms.Panel();
            this.buttonTutup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonten)).BeginInit();
            this.panelKonten.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKontenSaya
            // 
            this.buttonKontenSaya.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonKontenSaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKontenSaya.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonKontenSaya.Location = new System.Drawing.Point(13, 415);
            this.buttonKontenSaya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKontenSaya.Name = "buttonKontenSaya";
            this.buttonKontenSaya.Size = new System.Drawing.Size(147, 47);
            this.buttonKontenSaya.TabIndex = 0;
            this.buttonKontenSaya.Text = "Konten Saya";
            this.buttonKontenSaya.UseVisualStyleBackColor = false;
            this.buttonKontenSaya.Click += new System.EventHandler(this.buttonKontenSaya_Click);
            // 
            // buttonTambahKonten
            // 
            this.buttonTambahKonten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahKonten.Location = new System.Drawing.Point(329, 415);
            this.buttonTambahKonten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambahKonten.Name = "buttonTambahKonten";
            this.buttonTambahKonten.Size = new System.Drawing.Size(147, 47);
            this.buttonTambahKonten.TabIndex = 1;
            this.buttonTambahKonten.Text = "Tambah Konten";
            this.buttonTambahKonten.UseVisualStyleBackColor = false;
            this.buttonTambahKonten.Click += new System.EventHandler(this.buttonTambahKonten_Click);
            // 
            // dataGridViewKonten
            // 
            this.dataGridViewKonten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKonten.Location = new System.Drawing.Point(13, 69);
            this.dataGridViewKonten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKonten.Name = "dataGridViewKonten";
            this.dataGridViewKonten.RowHeadersWidth = 51;
            this.dataGridViewKonten.RowTemplate.Height = 24;
            this.dataGridViewKonten.Size = new System.Drawing.Size(775, 340);
            this.dataGridViewKonten.TabIndex = 2;
            this.dataGridViewKonten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKonten_CellContentClick);
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
            this.labelKonten.Click += new System.EventHandler(this.labelKonten_Click);
            // 
            // panelKonten
            // 
            this.panelKonten.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelKonten.Controls.Add(this.labelKonten);
            this.panelKonten.Location = new System.Drawing.Point(12, 12);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(776, 54);
            this.panelKonten.TabIndex = 4;
            this.panelKonten.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKonten_Paint);
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTutup.Location = new System.Drawing.Point(643, 415);
            this.buttonTutup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(147, 47);
            this.buttonTutup.TabIndex = 5;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // FormKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.dataGridViewKonten);
            this.Controls.Add(this.buttonTambahKonten);
            this.Controls.Add(this.buttonKontenSaya);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKonten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKonten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKonten_FormClosing);
            this.Load += new System.EventHandler(this.FormKonten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonten)).EndInit();
            this.panelKonten.ResumeLayout(false);
            this.panelKonten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKontenSaya;
        private System.Windows.Forms.Button buttonTambahKonten;
        private System.Windows.Forms.DataGridView dataGridViewKonten;
        private System.Windows.Forms.Label labelKonten;
        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.Button buttonTutup;
    }
}