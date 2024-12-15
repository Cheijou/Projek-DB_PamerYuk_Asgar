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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTglLahir = new System.Windows.Forms.Label();
            this.labelFoto = new System.Windows.Forms.Label();
            this.labelKota = new System.Windows.Forms.Label();
            this.textBoxFoto = new System.Windows.Forms.TextBox();
            this.comboBoxKota = new System.Windows.Forms.ComboBox();
            this.labelNoKtp = new System.Windows.Forms.Label();
            this.textBoxNoKTP = new System.Windows.Forms.TextBox();
            this.dateTimePickerTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 62);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(504, 419);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(100, 28);
            this.buttonRegister.TabIndex = 30;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(13, 419);
            this.buttonTutup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(100, 28);
            this.buttonTutup.TabIndex = 28;
            this.buttonTutup.Text = "TUTUP";
            this.buttonTutup.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(119, 151);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(485, 22);
            this.textBoxPassword.TabIndex = 27;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(119, 102);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(485, 22);
            this.textBoxUsername.TabIndex = 26;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(13, 151);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 16);
            this.labelPassword.TabIndex = 25;
            this.labelPassword.Text = "Password :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(13, 108);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(76, 16);
            this.labelUsername.TabIndex = 24;
            this.labelUsername.Text = "Username :";
            // 
            // labelTglLahir
            // 
            this.labelTglLahir.AutoSize = true;
            this.labelTglLahir.Location = new System.Drawing.Point(10, 205);
            this.labelTglLahir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTglLahir.Name = "labelTglLahir";
            this.labelTglLahir.Size = new System.Drawing.Size(96, 16);
            this.labelTglLahir.TabIndex = 31;
            this.labelTglLahir.Text = "Tanggal Lahir :";
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.Location = new System.Drawing.Point(13, 301);
            this.labelFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(40, 16);
            this.labelFoto.TabIndex = 32;
            this.labelFoto.Text = "Foto :";
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Location = new System.Drawing.Point(13, 354);
            this.labelKota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(43, 16);
            this.labelKota.TabIndex = 33;
            this.labelKota.Text = "Kota  :";
            // 
            // textBoxFoto
            // 
            this.textBoxFoto.Location = new System.Drawing.Point(119, 298);
            this.textBoxFoto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFoto.Name = "textBoxFoto";
            this.textBoxFoto.Size = new System.Drawing.Size(485, 22);
            this.textBoxFoto.TabIndex = 35;
            // 
            // comboBoxKota
            // 
            this.comboBoxKota.FormattingEnabled = true;
            this.comboBoxKota.Location = new System.Drawing.Point(119, 351);
            this.comboBoxKota.Name = "comboBoxKota";
            this.comboBoxKota.Size = new System.Drawing.Size(292, 24);
            this.comboBoxKota.TabIndex = 36;
            // 
            // labelNoKtp
            // 
            this.labelNoKtp.AutoSize = true;
            this.labelNoKtp.Location = new System.Drawing.Point(10, 256);
            this.labelNoKtp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoKtp.Name = "labelNoKtp";
            this.labelNoKtp.Size = new System.Drawing.Size(60, 16);
            this.labelNoKtp.TabIndex = 37;
            this.labelNoKtp.Text = "No KTP :";
            // 
            // textBoxNoKTP
            // 
            this.textBoxNoKTP.Location = new System.Drawing.Point(119, 250);
            this.textBoxNoKTP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNoKTP.Name = "textBoxNoKTP";
            this.textBoxNoKTP.Size = new System.Drawing.Size(485, 22);
            this.textBoxNoKTP.TabIndex = 38;
            // 
            // dateTimePickerTanggalLahir
            // 
            this.dateTimePickerTanggalLahir.Location = new System.Drawing.Point(119, 198);
            this.dateTimePickerTanggalLahir.Name = "dateTimePickerTanggalLahir";
            this.dateTimePickerTanggalLahir.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTanggalLahir.TabIndex = 39;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 460);
            this.Controls.Add(this.dateTimePickerTanggalLahir);
            this.Controls.Add(this.textBoxNoKTP);
            this.Controls.Add(this.labelNoKtp);
            this.Controls.Add(this.comboBoxKota);
            this.Controls.Add(this.textBoxFoto);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.labelTglLahir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTglLahir;
        private System.Windows.Forms.Label labelFoto;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.TextBox textBoxFoto;
        private System.Windows.Forms.ComboBox comboBoxKota;
        private System.Windows.Forms.Label labelNoKtp;
        private System.Windows.Forms.TextBox textBoxNoKTP;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalLahir;
    }
}