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
    public partial class FormTagMasuk : Form
    {
        public User userlogin;
        FormMenu form;
        public FormTagMasuk()
        {
            InitializeComponent();
        }

        private void FormTagMasuk_Load(object sender, EventArgs e)
        {
            form = (FormMenu)this.MdiParent;
            List<Konten> listKonten = Konten.KontenTag(userlogin);
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
            Konten.UpdateTag(userlogin);
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
                    formDetailKonten.user = userlogin;
                    formDetailKonten.cekForm = "FormKonten";
                    formDetailKonten.kontenId = konten;
                    formDetailKonten.pictureBoxGambar.Image = (Image)dataGridViewKonten.CurrentRow.Cells["Foto"].Value;
                    formDetailKonten.cekForm = "FormTag";
                    formDetailKonten.Show();
                    formDetailKonten.BringToFront();
                }
                else
                {
                    formApp.Show();
                }
            }
        }

        private void FormTagMasuk_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.panelBG.Visible = true;
            form.LoadButton();
            form.labelUser.Visible = true;
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            form.panelBG.Visible = true;
            form.LoadButton();
            form.labelUser.Visible = true;
            this.Close();
        }
    }
}
