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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelJudul = new System.Windows.Forms.Label();
            this.comboBoxTeman = new System.Windows.Forms.ComboBox();
            this.labelTeman = new System.Windows.Forms.Label();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.labelChat = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonAddChat = new System.Windows.Forms.Button();
            this.labelDialog = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.labelJudul);
            this.panel1.Location = new System.Drawing.Point(13, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 62);
            this.panel1.TabIndex = 24;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(231, 5);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(118, 52);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Chat";
            // 
            // comboBoxTeman
            // 
            this.comboBoxTeman.FormattingEnabled = true;
            this.comboBoxTeman.Location = new System.Drawing.Point(90, 96);
            this.comboBoxTeman.Name = "comboBoxTeman";
            this.comboBoxTeman.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTeman.TabIndex = 25;
            this.comboBoxTeman.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeman_SelectedIndexChanged);
            // 
            // labelTeman
            // 
            this.labelTeman.AutoSize = true;
            this.labelTeman.Location = new System.Drawing.Point(13, 99);
            this.labelTeman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeman.Name = "labelTeman";
            this.labelTeman.Size = new System.Drawing.Size(56, 16);
            this.labelTeman.TabIndex = 26;
            this.labelTeman.Text = "Teman :";
            // 
            // listBoxChat
            // 
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 16;
            this.listBoxChat.Location = new System.Drawing.Point(16, 160);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(588, 260);
            this.listBoxChat.TabIndex = 27;
            // 
            // labelChat
            // 
            this.labelChat.AutoSize = true;
            this.labelChat.Location = new System.Drawing.Point(13, 141);
            this.labelChat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChat.Name = "labelChat";
            this.labelChat.Size = new System.Drawing.Size(40, 16);
            this.labelChat.TabIndex = 28;
            this.labelChat.Text = "Chat :";
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(16, 465);
            this.textBoxAdd.Multiline = true;
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(588, 55);
            this.textBoxAdd.TabIndex = 29;
            // 
            // buttonAddChat
            // 
            this.buttonAddChat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddChat.Location = new System.Drawing.Point(504, 555);
            this.buttonAddChat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddChat.Name = "buttonAddChat";
            this.buttonAddChat.Size = new System.Drawing.Size(100, 28);
            this.buttonAddChat.TabIndex = 31;
            this.buttonAddChat.Text = "Kirim";
            this.buttonAddChat.UseVisualStyleBackColor = false;
            this.buttonAddChat.Click += new System.EventHandler(this.buttonAddChat_Click);
            // 
            // labelDialog
            // 
            this.labelDialog.AutoSize = true;
            this.labelDialog.Location = new System.Drawing.Point(13, 446);
            this.labelDialog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDialog.Name = "labelDialog";
            this.labelDialog.Size = new System.Drawing.Size(53, 16);
            this.labelDialog.TabIndex = 32;
            this.labelDialog.Text = "Dialog :";
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 596);
            this.Controls.Add(this.labelDialog);
            this.Controls.Add(this.buttonAddChat);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.labelChat);
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.labelTeman);
            this.Controls.Add(this.comboBoxTeman);
            this.Controls.Add(this.panel1);
            this.Name = "FormChat";
            this.Text = "FormChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat_FormClosing);
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.ComboBox comboBoxTeman;
        private System.Windows.Forms.Label labelTeman;
        private System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.Label labelChat;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonAddChat;
        private System.Windows.Forms.Label labelDialog;
    }
}