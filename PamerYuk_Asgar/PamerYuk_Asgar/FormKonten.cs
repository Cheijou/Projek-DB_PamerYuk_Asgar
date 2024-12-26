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
    public partial class FormKonten : Form
    {
        public FormKonten()
        {
            InitializeComponent();
        }
        public User user;
        FormMenu form;
        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewKonten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Konten> listKonten = Konten.BacaData();
            dataGridViewKonten.DataSource = listKonten;

            if (dataGridViewKonten.ColumnCount == 6)
            {
                DataGridViewButtonColumn btnKomen = new DataGridViewButtonColumn();
                btnKomen.Text = "Komen";
                btnKomen.HeaderText = "";
                btnKomen.UseColumnTextForButtonValue = true;
                btnKomen.Name = "btnKomenGrid";
                dataGridViewKonten.Columns.Add(btnKomen);
            }
        }

        private void FormKonten_Load(object sender, EventArgs e)
        {
            form = (FormMenu)this.MdiParent;

            List<Konten> listKonten = Konten.Daftarkonten(user);
            dataGridViewKonten.DataSource = listKonten;

            if (dataGridViewKonten.ColumnCount == 6)
            {
                DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn();
                btnDetail.Text = "Detail";
                btnDetail.HeaderText = "";
                btnDetail.UseColumnTextForButtonValue = true;
                btnDetail.Name = "btnDetailData";
                dataGridViewKonten.Columns.Add(btnDetail);
            }
        }

        private void buttonTambahKonten_Click(object sender, EventArgs e)
        {
            FormTambahKonten form = new FormTambahKonten();
            form.user = user;
            form.Owner = this;
            form.ShowDialog();
        }

        private void FormKonten_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.LoadButton();
        }
    }
}
