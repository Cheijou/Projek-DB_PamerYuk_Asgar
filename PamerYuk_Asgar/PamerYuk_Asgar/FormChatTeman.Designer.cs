﻿namespace PamerYuk_Asgar
{
    partial class FormChatTeman
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
            this.labelJudul = new System.Windows.Forms.Label();
            this.comboBoxTeman = new System.Windows.Forms.ComboBox();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.labelChat = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonAddChat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(70, 24);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(167, 29);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Pilih Teman :";
            // 
            // comboBoxTeman
            // 
            this.comboBoxTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeman.FormattingEnabled = true;
            this.comboBoxTeman.ItemHeight = 22;
            this.comboBoxTeman.Location = new System.Drawing.Point(236, 24);
            this.comboBoxTeman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTeman.Name = "comboBoxTeman";
            this.comboBoxTeman.Size = new System.Drawing.Size(120, 30);
            this.comboBoxTeman.TabIndex = 25;
            this.comboBoxTeman.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeman_SelectedIndexChanged);
            // 
            // listBoxChat
            // 
            this.listBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 17;
            this.listBoxChat.Location = new System.Drawing.Point(12, 87);
            this.listBoxChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(402, 157);
            this.listBoxChat.TabIndex = 27;
            // 
            // labelChat
            // 
            this.labelChat.AutoSize = true;
            this.labelChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChat.Location = new System.Drawing.Point(10, 66);
            this.labelChat.Name = "labelChat";
            this.labelChat.Size = new System.Drawing.Size(51, 17);
            this.labelChat.TabIndex = 28;
            this.labelChat.Text = "Chat :";
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(13, 284);
            this.textBoxAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAdd.Multiline = true;
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(402, 45);
            this.textBoxAdd.TabIndex = 29;
            this.textBoxAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // buttonAddChat
            // 
            this.buttonAddChat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddChat.Location = new System.Drawing.Point(338, 335);
            this.buttonAddChat.Name = "buttonAddChat";
            this.buttonAddChat.Size = new System.Drawing.Size(75, 23);
            this.buttonAddChat.TabIndex = 31;
            this.buttonAddChat.Text = "Kirim";
            this.buttonAddChat.UseVisualStyleBackColor = false;
            this.buttonAddChat.Click += new System.EventHandler(this.buttonAddChat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kirim Pesan :";
            // 
            // FormChatTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.buttonAddChat);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.labelChat);
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.comboBoxTeman);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormChatTeman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChat";
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.Label labelChat;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonAddChat;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxTeman;
    }
}