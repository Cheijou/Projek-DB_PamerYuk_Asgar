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
    public partial class FormFriendRequest : Form
    {
        FormTambahTeman form;
        public User userLogin;
        public FormFriendRequest()
        {
            InitializeComponent();
        }

        private void FormFriendRequest_Load(object sender, EventArgs e)
        {
            form = (FormTambahTeman)this.Owner;

            List<Teman> listPermintaan = User.Permintaan(userLogin);
            dataGridViewPermintaan.DataSource = listPermintaan;

            if (dataGridViewPermintaan.ColumnCount == 2)
            {
                DataGridViewButtonColumn btnTerima = new DataGridViewButtonColumn();
                btnTerima.Text = "Terima";
                btnTerima.HeaderText = "";
                btnTerima.UseColumnTextForButtonValue = true;
                btnTerima.Name = "btnTerimaGrid";
                dataGridViewPermintaan.Columns.Add(btnTerima);
            }
            if (dataGridViewPermintaan.ColumnCount == 3)
            {
                DataGridViewButtonColumn btnTolak = new DataGridViewButtonColumn();
                btnTolak.Text = "Tolak";
                btnTolak.HeaderText = "";
                btnTolak.UseColumnTextForButtonValue = true;
                btnTolak.Name = "btnTolakGrid";
                dataGridViewPermintaan.Columns.Add(btnTolak);
            }
        }
        private void dataGridViewPermintaan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewPermintaan.CurrentRow.Cells["user2"].Value.ToString();

            if (e.ColumnIndex == dataGridViewPermintaan.Columns["btnTerimaGrid"].Index)
            {
                DialogResult jawaban = MessageBox.Show("Terima permintaan pertemanan?", "Information", MessageBoxButtons.YesNo);
                if (jawaban == DialogResult.Yes)
                {
                    userLogin.TerimaTeman(kode);
        
                }
            }
            if (e.ColumnIndex == dataGridViewPermintaan.Columns["btnTolakGrid"].Index)
            {
                DialogResult jawaban = MessageBox.Show("Tolak Permintaan Berteman?", "Information", MessageBoxButtons.YesNo);
                if (jawaban == DialogResult.Yes)
                {
                    userLogin.TolakTeman(kode);
                    MessageBox.Show("Berhasil Menolak Permintaan Pertemanan");
                }
            }
        }
    }
}
