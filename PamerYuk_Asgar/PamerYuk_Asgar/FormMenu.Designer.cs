﻿namespace PamerYuk_Asgar
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMulai = new System.Windows.Forms.Button();
            this.buttonCariTeman = new System.Windows.Forms.Button();
            this.buttonEditProfil = new System.Windows.Forms.Button();
            this.buttonChat = new System.Windows.Forms.Button();
            this.buttonKonten = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pamer Yuk!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMulai
            // 
            this.buttonMulai.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulai.Location = new System.Drawing.Point(376, 305);
            this.buttonMulai.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMulai.Name = "buttonMulai";
            this.buttonMulai.Size = new System.Drawing.Size(297, 87);
            this.buttonMulai.TabIndex = 2;
            this.buttonMulai.Text = "MULAI";
            this.buttonMulai.UseVisualStyleBackColor = true;
            this.buttonMulai.Click += new System.EventHandler(this.buttonMulai_Click);
            // 
            // buttonCariTeman
            // 
            this.buttonCariTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCariTeman.Location = new System.Drawing.Point(112, 100);
            this.buttonCariTeman.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCariTeman.Name = "buttonCariTeman";
            this.buttonCariTeman.Size = new System.Drawing.Size(297, 87);
            this.buttonCariTeman.TabIndex = 3;
            this.buttonCariTeman.Text = "cari teman";
            this.buttonCariTeman.UseVisualStyleBackColor = true;
            this.buttonCariTeman.Click += new System.EventHandler(this.buttonCariTeman_Click);
            // 
            // buttonEditProfil
            // 
            this.buttonEditProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditProfil.Location = new System.Drawing.Point(112, 320);
            this.buttonEditProfil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditProfil.Name = "buttonEditProfil";
            this.buttonEditProfil.Size = new System.Drawing.Size(297, 87);
            this.buttonEditProfil.TabIndex = 4;
            this.buttonEditProfil.Text = "edit profil";
            this.buttonEditProfil.UseVisualStyleBackColor = true;
            this.buttonEditProfil.Click += new System.EventHandler(this.buttonEditProfil_Click);
            // 
            // buttonChat
            // 
            this.buttonChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChat.Location = new System.Drawing.Point(665, 100);
            this.buttonChat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(297, 87);
            this.buttonChat.TabIndex = 5;
            this.buttonChat.Text = "chat";
            this.buttonChat.UseVisualStyleBackColor = true;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // buttonKonten
            // 
            this.buttonKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKonten.Location = new System.Drawing.Point(665, 320);
            this.buttonKonten.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKonten.Name = "buttonKonten";
            this.buttonKonten.Size = new System.Drawing.Size(297, 87);
            this.buttonKonten.TabIndex = 6;
            this.buttonKonten.Text = "konten";
            this.buttonKonten.UseVisualStyleBackColor = true;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.Location = new System.Drawing.Point(854, 451);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(191, 51);
            this.buttonKeluar.TabIndex = 7;
            this.buttonKeluar.Text = "Keluar Akun";
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKonten);
            this.Controls.Add(this.buttonChat);
            this.Controls.Add(this.buttonEditProfil);
            this.Controls.Add(this.buttonCariTeman);
            this.Controls.Add(this.buttonMulai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMulai;
        public System.Windows.Forms.Button buttonCariTeman;
        public System.Windows.Forms.Button buttonEditProfil;
        public System.Windows.Forms.Button buttonChat;
        public System.Windows.Forms.Button buttonKonten;
        public System.Windows.Forms.Button buttonKeluar;
    }
}

