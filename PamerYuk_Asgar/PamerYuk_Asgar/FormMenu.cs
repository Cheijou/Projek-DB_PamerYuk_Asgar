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
        public bool buka = false;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            labelJumlahNotif.Visible = false;
            this.IsMdiContainer = true;
            this.Visible = false;
            DisableButton();
            try
            {
                FormLogin frm = new FormLogin();
                frm.Owner = this;
                this.Visible = false;
                frm.ShowDialog();
                
                if (userLogin != null)
                {
                    Koneksi koneksi = new Koneksi();
                    pictureBoxMulai.Visible = true;
                    pictureBoxMulai.Enabled = true;
                    MessageBox.Show("Selamat datang " + userLogin.Username, "Welcome");
                    labelUser.Text = userLogin.Username;
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
            int total = 0;
            total += Chat.TotalChat(userLogin);
            if (total > 0)
            {
                labelJumlahNotif.Visible = true;
                labelJumlahNotif.Text = total.ToString();
            }
            pictureBoxCariTeman.Visible = true;
            pictureBoxCariTeman.Enabled = true;
            pictureBoxEditProfil.Visible = true;
            pictureBoxEditProfil.Enabled = true;
            pictureBoxChat.Visible = true;
            pictureBoxChat.Enabled = true;
            pictureBoxKonten.Visible = true;
            pictureBoxKonten.Enabled = true;
            pictureBoxProfil.Visible =true;
            pictureBoxProfil.Enabled = true;
            pictureBoxNotif.Visible = true;
            pictureBoxNotif.Enabled = true;
            pictureBoxCr.Visible = true;
            pictureBoxCr.Enabled = true;


        }
        public void DisableButton()
        {
            pictureBoxCariTeman.Visible = false;
            pictureBoxCariTeman.Enabled = false;
            pictureBoxEditProfil.Visible = false;
            pictureBoxEditProfil.Enabled = false;
            pictureBoxChat.Visible = false;
            pictureBoxChat.Enabled = false;
            pictureBoxKonten.Visible = false;
            pictureBoxKonten.Enabled = false;
            pictureBoxProfil.Visible = false;
            pictureBoxProfil.Enabled = false;
            pictureBoxNotif.Visible = false;
            pictureBoxNotif.Enabled = false;
            pictureBoxCr.Visible = false;
            pictureBoxCr.Enabled = false;
            pictureBoxTerbaru.Enabled = false;
            pictureBoxTerbaru.Visible = false;
            pictureBoxLihat.Visible = false;
            pictureBoxLihat.Enabled = false;
            pictureBoxLogOut.Visible = false;
            pictureBoxLogOut.Enabled = false;
        }
        private void pictureBoxCariTeman_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahTeman"];

            if (form == null)
            {
                panelBG.Visible = false;
                FormTambahTeman formTambahTeman = new FormTambahTeman();
                formTambahTeman.user = userLogin;
                formTambahTeman.MdiParent = this;
                formTambahTeman.Show();
                DisableButton();
                
                labelUser.Visible = false;
                BackgroundImage = Properties.Resources.bg_only;               
                formTambahTeman.BringToFront();

            }
            else
            {
                form.Show();
            }
        }

        private void pictureBoxChat_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormChat"];

            if (form == null)
            {
                panelBG.Visible = false;
                FormChatTeman formChat = new FormChatTeman();
                formChat.user = userLogin;
                formChat.MdiParent = this;
                formChat.menu = true;
                formChat.Show();
                DisableButton();
                labelUser.Visible = false;
                BackgroundImage = Properties.Resources.bg_only;
                formChat.BringToFront();

            }
            else
            {
                form.Show();
            }
        }

        private void pictureBoxKonten_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormKonten"];

            if (form == null)
            {
                panelBG.Visible = false;
                FormKonten formKonten = new FormKonten();
                formKonten.user = userLogin;
                formKonten.MdiParent = this;
                formKonten.Show();
                DisableButton();
                labelUser.Visible = false;
                BackgroundImage = Properties.Resources.bg_only;
                formKonten.BringToFront();

            }
            else
            {
                form.Show();
            }
        }

        private void pictureBoxEditProfil_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormEditProfil"];

            if (form == null)
            {
                panelBG.Visible = false;
                FormEditProfil formEditProfil = new FormEditProfil();
                formEditProfil.user = userLogin;
                formEditProfil.MdiParent = this;
                formEditProfil.Show();
                DisableButton();
                labelUser.Visible = false;
                BackgroundImage = Properties.Resources.bg_only;
                formEditProfil.BringToFront();
            }
            else
            {
                form.Show();
            }
        }

        private void pictureBoxMulai_Click(object sender, EventArgs e)
        {
            pictureBoxMulai.Visible = false;
            pictureBoxMulai.Enabled = false;
            LoadButton();
        }

        private void pictureBoxNotif_Click(object sender, EventArgs e)
        {
            if (buka == false)
            {
                pictureBoxTerbaru.Visible = true;
                pictureBoxTerbaru.Enabled = true;
                buka = true;    
            }
            else
            {
                pictureBoxTerbaru.Visible = false;
                pictureBoxTerbaru.Enabled = false;
                buka = false;
            }
            

        }

        private void pictureBoxProfil_Click(object sender, EventArgs e)
        {
            if (buka == false)
            {
                pictureBoxLihat.Visible = true;
                pictureBoxLihat.Enabled = true;
                pictureBoxLogOut.Visible = true;
                pictureBoxLogOut.Enabled = true;
                buka = true;
            }
            else
            {
                pictureBoxLihat.Visible = false;
                pictureBoxLihat.Enabled = false;
                pictureBoxLogOut.Visible = false;
                pictureBoxLogOut.Enabled = false;
                buka = false;
            }

        }

        private void pictureBoxCr_Click(object sender, EventArgs e)
        {
            DisableButton();
            labelUser.Visible = false;
            BackgroundImage = Properties.Resources.bg_only;
        }

        

        private void pictureBoxTerbaru_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormChat"];

            if (form == null)
            {
                panelBG.Visible = false;
                FormChat formChat = new FormChat();
                formChat.user = userLogin;
                formChat.MdiParent = this;
                FormChatTeman formChatTeman = new FormChatTeman();
                formChatTeman.MdiParent = this;
                formChat.Show();
                DisableButton();
                labelUser.Visible = false;
                BackgroundImage = Properties.Resources.bg_only;
                formChat.BringToFront();

            }
            else
            {
                form.Show();
            }
        }

        private void pictureBoxLihat_Click(object sender, EventArgs e)
        {
            DisableButton();
            labelUser.Visible = false;
            BackgroundImage = Properties.Resources.bg_only;
            FormLihatProfil form = new FormLihatProfil();
            form.cek = "FormMenu";
            form.user = User.BacaData("username", userLogin.Username)[0];
            form.Owner = this;
            form.ShowDialog();
        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            FormMenu_Load(sender, e);
            
        }
    }
}
