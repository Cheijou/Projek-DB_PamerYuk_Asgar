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
        string kontenId;
        public FormKonten()
        {
            InitializeComponent();
        }
        public User user;
        FormMenu form;
        
        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
            form.panelBG.Visible = true;
            form.LoadButton();
            form.labelUser.Visible = true;
        }

        private void dataGridViewKonten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string konten = dataGridViewKonten.CurrentRow.Cells["Id"].Value.ToString();

            if (e.ColumnIndex == dataGridViewKonten.Columns["btnDetailGrid"].Index)
            {
                Form formApp = Application.OpenForms["FormDetailKonten"];
                if (formApp == null)
                {
                    FormDetailKonten formDetailKonten = new FormDetailKonten();
                    formDetailKonten.Owner = this;
                    formDetailKonten.user = user;
                    formDetailKonten.cekForm = "FormKonten";
                    formDetailKonten.kontenId = konten;
                    formDetailKonten.pictureBoxGambar.Image = (Image)dataGridViewKonten.CurrentRow.Cells["Foto"].Value;
                    formDetailKonten.Show();
                    formDetailKonten.BringToFront();
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
            for (int i = 0; i < listKonten.Count; i++)
            {
                dataGridViewKonten.Rows.Add(listKonten[i].User.Username, listKonten[i].Caption, listKonten[i].TglUpload, listKonten[i].Id);
            }
            dataGridViewKonten.Columns["Foto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKonten.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                
            for (int i = 0; i < listKonten.Count; i++)
            {
                dataGridViewKonten.Rows[i].Cells[4].Value = listKonten[i].Gambar; 
            }

            if (dataGridViewKonten.ColumnCount == 5)
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
            form.panelBG.Visible = true;
            form.LoadButton();
            form.labelUser.Visible = true;
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
