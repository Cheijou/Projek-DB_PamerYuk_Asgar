using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYuk_Asgar
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister();
            form.MdiParent = this;
            form.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormMenu formParent = (FormMenu)this.Owner;
            string uid = textBoxUsername.Text;
            string pwd = textBoxPassword.Text;
            formParent.userLogin = User.CekLogin(uid, pwd);
            if (formParent.userLogin is null)
            {
                MessageBox.Show("Your username/password is incorrect");
            }
            else
            {
                formParent.Visible = true;
                this.Close();
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
