namespace PamerYuk_Asgar
{
    partial class FormChat
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
            this.panelKonten = new System.Windows.Forms.Panel();
            this.labelKonten = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatTerbaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonChatTeman = new System.Windows.Forms.Button();
            this.panelKonten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKonten
            // 
            this.panelKonten.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelKonten.Controls.Add(this.labelKonten);
            this.panelKonten.Location = new System.Drawing.Point(12, 11);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(755, 54);
            this.panelKonten.TabIndex = 5;
            // 
            // labelKonten
            // 
            this.labelKonten.AutoSize = true;
            this.labelKonten.Font = new System.Drawing.Font("Arial Narrow", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKonten.Location = new System.Drawing.Point(255, 0);
            this.labelKonten.Name = "labelKonten";
            this.labelKonten.Size = new System.Drawing.Size(240, 55);
            this.labelKonten.TabIndex = 3;
            this.labelKonten.Text = "Chat Masuk";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.ChatTerbaru});
            this.dataGridViewData.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(756, 306);
            this.dataGridViewData.TabIndex = 6;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // ChatTerbaru
            // 
            this.ChatTerbaru.HeaderText = "Chat Terbaru";
            this.ChatTerbaru.MinimumWidth = 6;
            this.ChatTerbaru.Name = "ChatTerbaru";
            this.ChatTerbaru.Width = 300;
            // 
            // buttonChatTeman
            // 
            this.buttonChatTeman.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChatTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChatTeman.Location = new System.Drawing.Point(590, 391);
            this.buttonChatTeman.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChatTeman.Name = "buttonChatTeman";
            this.buttonChatTeman.Size = new System.Drawing.Size(180, 40);
            this.buttonChatTeman.TabIndex = 41;
            this.buttonChatTeman.Text = "Chat Teman";
            this.buttonChatTeman.UseVisualStyleBackColor = false;
            this.buttonChatTeman.Click += new System.EventHandler(this.buttonChatTeman_Click);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 437);
            this.Controls.Add(this.buttonChatTeman);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panelKonten);
            this.Name = "FormChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat_FormClosing);
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.panelKonten.ResumeLayout(false);
            this.panelKonten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.Label labelKonten;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonChatTeman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatTerbaru;
    }
}