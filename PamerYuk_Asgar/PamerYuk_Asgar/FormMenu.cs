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
        User userLogin;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            try
            {
                FormLogin frm = new FormLogin();
                frm.Owner = this;
                this.Visible = false;
                frm.ShowDialog();
                if (userLogin != null)
                {
                    Koneksi koneksi = new Koneksi();
                    MessageBox.Show("Berhasil cuy", "Informasi");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("error"+ex.Message);    
            }
        }
    }
}
