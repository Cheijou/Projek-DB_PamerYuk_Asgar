namespace PamerYuk_Asgar
{
    partial class FormProfile
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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listBoxDetail = new System.Windows.Forms.ListBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.comboBoxDetail = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonTeman = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(147, 135);
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama :";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 153);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(147, 30);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit Profil";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listBoxDetail
            // 
            this.listBoxDetail.FormattingEnabled = true;
            this.listBoxDetail.ItemHeight = 16;
            this.listBoxDetail.Location = new System.Drawing.Point(171, 98);
            this.listBoxDetail.Name = "listBoxDetail";
            this.listBoxDetail.Size = new System.Drawing.Size(261, 148);
            this.listBoxDetail.TabIndex = 4;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(221, 12);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(47, 16);
            this.labelNama.TabIndex = 5;
            this.labelNama.Text = "Nama ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tanggal Lahir :";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(267, 40);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(81, 16);
            this.labelTanggal.TabIndex = 8;
            this.labelTanggal.Text = "yyyy-MM-dd";
            this.labelTanggal.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxDetail
            // 
            this.comboBoxDetail.FormattingEnabled = true;
            this.comboBoxDetail.Items.AddRange(new object[] {
            "Kisah Hidup",
            "Organisasi"});
            this.comboBoxDetail.Location = new System.Drawing.Point(222, 68);
            this.comboBoxDetail.Name = "comboBoxDetail";
            this.comboBoxDetail.Size = new System.Drawing.Size(126, 24);
            this.comboBoxDetail.TabIndex = 9;
            this.comboBoxDetail.SelectedIndexChanged += new System.EventHandler(this.comboBoxDetail_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Detail :";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 225);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(147, 30);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonTeman
            // 
            this.buttonTeman.Location = new System.Drawing.Point(12, 189);
            this.buttonTeman.Name = "buttonTeman";
            this.buttonTeman.Size = new System.Drawing.Size(147, 30);
            this.buttonTeman.TabIndex = 12;
            this.buttonTeman.Text = "LihatTeman";
            this.buttonTeman.UseVisualStyleBackColor = true;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 262);
            this.Controls.Add(this.buttonTeman);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDetail);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.listBoxDetail);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxProfile);
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ListBox listBoxDetail;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.ComboBox comboBoxDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonTeman;
    }
}