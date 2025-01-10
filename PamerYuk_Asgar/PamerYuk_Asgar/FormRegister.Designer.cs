namespace PamerYuk_Asgar
{
    partial class FormRegister
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTglLahir = new System.Windows.Forms.Label();
            this.labelFoto = new System.Windows.Forms.Label();
            this.labelKota = new System.Windows.Forms.Label();
            this.comboBoxKota = new System.Windows.Forms.ComboBox();
            this.labelNoKtp = new System.Windows.Forms.Label();
            this.textBoxNoKTP = new System.Windows.Forms.TextBox();
            this.dateTimePickerTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxPFP = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(176, 368);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(106, 36);
            this.buttonRegister.TabIndex = 30;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(376, 381);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(75, 23);
            this.buttonTutup.TabIndex = 28;
            this.buttonTutup.Text = "TUTUP";
            this.buttonTutup.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(130, 122);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(299, 20);
            this.textBoxPassword.TabIndex = 27;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(130, 83);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(300, 20);
            this.textBoxUsername.TabIndex = 26;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(41, 124);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 16);
            this.labelPassword.TabIndex = 25;
            this.labelPassword.Text = "Password :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(30, 83);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(95, 18);
            this.labelUsername.TabIndex = 24;
            this.labelUsername.Text = "Username :";
            // 
            // labelTglLahir
            // 
            this.labelTglLahir.AutoSize = true;
            this.labelTglLahir.BackColor = System.Drawing.Color.Transparent;
            this.labelTglLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglLahir.Location = new System.Drawing.Point(15, 163);
            this.labelTglLahir.Name = "labelTglLahir";
            this.labelTglLahir.Size = new System.Drawing.Size(111, 16);
            this.labelTglLahir.TabIndex = 31;
            this.labelTglLahir.Text = "Tanggal Lahir :";
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.BackColor = System.Drawing.Color.Transparent;
            this.labelFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoto.Location = new System.Drawing.Point(71, 239);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(53, 18);
            this.labelFoto.TabIndex = 32;
            this.labelFoto.Text = "Foto :";
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.BackColor = System.Drawing.Color.Transparent;
            this.labelKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKota.Location = new System.Drawing.Point(42, 327);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(81, 16);
            this.labelKota.TabIndex = 33;
            this.labelKota.Text = "Asal Kota :";
            // 
            // comboBoxKota
            // 
            this.comboBoxKota.FormattingEnabled = true;
            this.comboBoxKota.Location = new System.Drawing.Point(135, 327);
            this.comboBoxKota.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKota.Name = "comboBoxKota";
            this.comboBoxKota.Size = new System.Drawing.Size(220, 21);
            this.comboBoxKota.TabIndex = 36;
            // 
            // labelNoKtp
            // 
            this.labelNoKtp.AutoSize = true;
            this.labelNoKtp.BackColor = System.Drawing.Color.Transparent;
            this.labelNoKtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoKtp.Location = new System.Drawing.Point(57, 202);
            this.labelNoKtp.Name = "labelNoKtp";
            this.labelNoKtp.Size = new System.Drawing.Size(68, 16);
            this.labelNoKtp.TabIndex = 37;
            this.labelNoKtp.Text = "No KTP :";
            // 
            // textBoxNoKTP
            // 
            this.textBoxNoKTP.Location = new System.Drawing.Point(135, 201);
            this.textBoxNoKTP.Name = "textBoxNoKTP";
            this.textBoxNoKTP.Size = new System.Drawing.Size(294, 20);
            this.textBoxNoKTP.TabIndex = 38;
            // 
            // dateTimePickerTanggalLahir
            // 
            this.dateTimePickerTanggalLahir.Location = new System.Drawing.Point(131, 160);
            this.dateTimePickerTanggalLahir.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTanggalLahir.Name = "dateTimePickerTanggalLahir";
            this.dateTimePickerTanggalLahir.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerTanggalLahir.TabIndex = 39;
            // 
            // pictureBoxPFP
            // 
            this.pictureBoxPFP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPFP.Location = new System.Drawing.Point(133, 240);
            this.pictureBoxPFP.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPFP.Name = "pictureBoxPFP";
            this.pictureBoxPFP.Size = new System.Drawing.Size(84, 75);
            this.pictureBoxPFP.TabIndex = 40;
            this.pictureBoxPFP.TabStop = false;
            this.pictureBoxPFP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPFP_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PamerYuk_Asgar.Properties.Resources.register_1_10_2025;
            this.pictureBox1.Location = new System.Drawing.Point(104, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PamerYuk_Asgar.Properties.Resources.bgregister;
            this.ClientSize = new System.Drawing.Size(463, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxPFP);
            this.Controls.Add(this.dateTimePickerTanggalLahir);
            this.Controls.Add(this.textBoxNoKTP);
            this.Controls.Add(this.labelNoKtp);
            this.Controls.Add(this.comboBoxKota);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.labelTglLahir);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTglLahir;
        private System.Windows.Forms.Label labelFoto;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.ComboBox comboBoxKota;
        private System.Windows.Forms.Label labelNoKtp;
        private System.Windows.Forms.TextBox textBoxNoKTP;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalLahir;
        private System.Windows.Forms.PictureBox pictureBoxPFP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}