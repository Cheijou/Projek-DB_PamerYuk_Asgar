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
    public partial class FormEditProfil : Form
    {
        FormMenu form;
        public FormEditProfil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEditProfil_Load(object sender, EventArgs e)
        {
            form = (FormMenu)this.MdiParent;
        }

        private void FormEditProfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.LoadButton();
        }
    }
}
