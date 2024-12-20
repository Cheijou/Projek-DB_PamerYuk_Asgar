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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPermintaan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermintaan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permintaan Pertemanan";
            // 
            // dataGridViewPermintaan
            // 
            this.dataGridViewPermintaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermintaan.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewPermintaan.Name = "dataGridViewPermintaan";
            this.dataGridViewPermintaan.RowHeadersWidth = 51;
            this.dataGridViewPermintaan.RowTemplate.Height = 24;
            this.dataGridViewPermintaan.Size = new System.Drawing.Size(776, 374);
            this.dataGridViewPermintaan.TabIndex = 1;
            this.dataGridViewPermintaan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermintaan_CellContentClick);
            // 
            // FormFriendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPermintaan);
            this.Controls.Add(this.label1);
            this.Name = "FormFriendRequest";
            this.Text = "FormFriendRequest";
            this.Load += new System.EventHandler(this.FormFriendRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermintaan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPermintaan;
    }
}