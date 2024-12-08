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
    public partial class FormProfile : Form
    {
        public string username;
        public FormProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            comboBoxDetail.SelectedIndex = -1;
            User temp = User.BacaData("username", username)[0];
            labelNama.Text = temp.Username;
            labelTanggal.Text = temp.TglLahir.ToString("yyyy-MM-dd");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEditProfil frm = new FormEditProfil();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDetail.Items.Clear();
        }
    }
}
