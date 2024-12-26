using System;
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
                    label1.Visible = true;
                    buttonMulai.Visible = true;
                    buttonMulai.Enabled = true;
                    MessageBox.Show("Selamat datang " + userLogin.Username, "Welcome");
                    
                }
                else
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }
        public void LoadButton()
        {
            buttonEditProfil.Visible = true;
            buttonCariTeman.Visible = true;
            buttonChat.Visible = true;
            buttonKonten.Visible = true;
            buttonKeluar.Visible = true;
            buttonEditProfil.Enabled = true;
            buttonCariTeman.Enabled = true;
            buttonChat.Enabled = true;
            buttonKonten.Enabled = true;
            buttonKeluar.Enabled = true;

        }

        

        private void buttonMulai_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            buttonMulai.Enabled = false;
            buttonMulai.Visible = false;
            LoadButton();
        }

        private void buttonCariTeman_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahTeman"];

            if (form == null)
            {
                FormTambahTeman formTambahTeman = new FormTambahTeman();
                formTambahTeman.user = userLogin;
                formTambahTeman.MdiParent = this;
                formTambahTeman.Show();
                buttonEditProfil.Visible = false;
                buttonCariTeman.Visible = false;
                buttonChat.Visible = false;
                buttonKonten.Visible = false;
                buttonKeluar.Visible = false;
                buttonEditProfil.Enabled = false;
                buttonCariTeman.Enabled = false;
                buttonChat.Enabled = false;
                buttonKonten.Enabled = false;
                buttonKeluar.Enabled = false;
                formTambahTeman.BringToFront();
                
            }
            else
            {
                form.Show();
            }
        }

        private void buttonEditProfil_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormEditProfil"];

            if (form == null)
            {
                FormEditProfil formEditProfil = new FormEditProfil();
                formEditProfil.MdiParent = this;
                formEditProfil.Show();
                buttonEditProfil.Visible = false;
                buttonCariTeman.Visible = false;
                buttonChat.Visible = false;
                buttonKonten.Visible = false;
                buttonKeluar.Visible = false;
                buttonEditProfil.Enabled = false;
                buttonCariTeman.Enabled = false;
                buttonChat.Enabled = false;
                buttonKonten.Enabled = false;
                buttonKeluar.Enabled = false;
                formEditProfil.BringToFront();
            }
            else
            {
                form.Show();
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormMenu_Load(sender, e);
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormChat"];

            if (form == null)
            {
                FormChat formChat = new FormChat();
                formChat.user = userLogin;
                formChat.MdiParent = this;
                FormChatTeman formChatTeman = new FormChatTeman();
                formChatTeman.MdiParent = this;
                formChat.Show();
                buttonEditProfil.Visible = false;
                buttonCariTeman.Visible = false;
                buttonChat.Visible = false;
                buttonKonten.Visible = false;
                buttonKeluar.Visible = false;
                buttonEditProfil.Enabled = false;
                buttonCariTeman.Enabled = false;
                buttonChat.Enabled = false;
                buttonKonten.Enabled = false;
                buttonKeluar.Enabled = false;
                formChat.BringToFront();

            }
            else
            {
                form.Show();
            }
        }

        private void buttonKonten_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormKonten"];

            if (form == null)
            {
                FormKonten formKonten = new FormKonten();
                formKonten.user = userLogin;
                formKonten.MdiParent = this;
                formKonten.Show();
                buttonEditProfil.Visible = false;
                buttonCariTeman.Visible = false;
                buttonChat.Visible = false;
                buttonKonten.Visible = false;
                buttonKeluar.Visible = false;
                buttonEditProfil.Enabled = false;
                buttonCariTeman.Enabled = false;
                buttonChat.Enabled = false;
                buttonKonten.Enabled = false;
                buttonKeluar.Enabled = false;
                formKonten.BringToFront();

            }
            else
            {
                form.Show();
            }
        }
    }
}
