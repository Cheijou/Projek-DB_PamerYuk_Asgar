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
    public partial class FormTambahTeman : Form
    {
        FormMenu form;
        public User user;

        public FormTambahTeman()
        {
            InitializeComponent();
        }

        private void FormTambahTeman_Load(object sender, EventArgs e)
        {
            
            form = (FormMenu)this.MdiParent;
            List<User> listUser = User.BacaData();
            dataGridViewTeman.DataSource = listUser;
                
            if (dataGridViewTeman.ColumnCount == 6)
            {
                DataGridViewButtonColumn btnTambah = new DataGridViewButtonColumn();
                btnTambah.Text = "Tambah";
                btnTambah.HeaderText = "";
                btnTambah.UseColumnTextForButtonValue = true;
                btnTambah.Name = "btnTambahGrid";
                dataGridViewTeman.Columns.Add(btnTambah);
            }
        }

        private void dataGridViewTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewTeman.CurrentRow.Cells["Username"].Value.ToString();

            if (e.ColumnIndex == dataGridViewTeman.Columns["btnTambahGrid"].Index)
            {
                DialogResult jawaban = MessageBox.Show("Kirim permintaan pertemanan?", "Information", MessageBoxButtons.YesNo);
                if (jawaban == DialogResult.Yes)
                {
                    User teman = User.BacaData("Username", kode)[0];
                    user.TambahTeman(teman,DateTime.Now);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string filter;
            if (comboBoxCari.SelectedIndex == 0)
            {
                filter = "ID";
            }
            else
            {
                filter = "kota_id";
            }
            string nilai = textBoxCari.Text;

            List<User> ListData = User.BacaData(filter, nilai);
            dataGridViewTeman.DataSource = ListData;
        }

        private void FormTambahTeman_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.LoadButton();
        }
    }
}
