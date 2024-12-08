﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_PamerYuk;

namespace PamerYuk_Asgar
{
    public partial class FormMenu : Form
    {
        public User userLogin;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.Visible = false;
            buttonEditProfil.Visible = false;
            buttonCariTeman.Visible = false;
            buttonChat.Visible = false;
            buttonKonten.Visible = false;
            buttonEditProfil.Enabled = false;
            buttonCariTeman.Enabled = false;
            buttonChat.Enabled = false;
            buttonKonten.Enabled = false;
            try
            {
                FormLogin frm = new FormLogin();
                frm.Owner = this;
                this.Visible = false;
                frm.ShowDialog();
                if (userLogin != null)
                {
                    Koneksi koneksi = new Koneksi();
                    MessageBox.Show("Selamat datang "+ userLogin.Username,"Welcome");
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show("error"+ex.Message);    
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMulai_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            buttonMulai.Enabled = false;
            buttonMulai.Visible = false;
            buttonEditProfil.Visible = true;
            buttonCariTeman.Visible = true;
            buttonChat.Visible = true;
            buttonKonten.Visible = true;
            buttonEditProfil.Enabled = true;
            buttonCariTeman.Enabled = true;
            buttonChat.Enabled = true;
            buttonKonten.Enabled = true;
        }
    }
}
