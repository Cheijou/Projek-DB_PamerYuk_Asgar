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
            string konten = dataGridViewKonten.CurrentRow.Cells["id"].Value.ToString();

            if (e.ColumnIndex == dataGridViewKonten.Columns["btnDetailGrid"].Index)
            {
                Form formApp = Application.OpenForms["FormKomen"];
                if (formApp == null)
                {
                    FormDetailKonten formKomen = new FormDetailKonten();
                    formKomen.Owner = this;
                    formKomen.user = user;
                    formKomen.kontenId = konten;
                    formKomen.pictureBoxGambar.Image = (Image)dataGridViewKonten.CurrentRow.Cells["Gambar"].Value;
                    formKomen.Show();
                    formKomen.BringToFront();
                }
                else
                {
                    formApp.Show();
                }
            }
        }

        private void FormKonten_Load(object sender, EventArgs e)
        {
            form = (FormMenu)this.MdiParent;

            List<Konten> listKonten = Konten.DaftarkontenTeman(user);
            dataGridViewKonten.DataSource = listKonten;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                Name = "Gambar",
                HeaderText = "Foto",
            };
            dataGridViewKonten.Columns["Gambar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKonten.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                
            for (int i = 0; i < listKonten.Count; i++)
            {
                
                dataGridViewKonten.Rows[i].Cells[6].Value = listKonten[i].Gambar; 
            }

            if (dataGridViewKonten.ColumnCount == 7)
            {
                DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn();
                btnDetail.Text = "Detail";
                btnDetail.HeaderText = "";
                btnDetail.UseColumnTextForButtonValue = true;
                btnDetail.Name = "btnDetailGrid";
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

        private void buttonKontenSaya_Click(object sender, EventArgs e)
        {
            FormKontenSaya form = new FormKontenSaya();
            form.user = user;
            form.Owner = this;
            form.ShowDialog();  
        }

        private void labelKonten_Click(object sender, EventArgs e)
        {

        }

        private void panelKonten_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
