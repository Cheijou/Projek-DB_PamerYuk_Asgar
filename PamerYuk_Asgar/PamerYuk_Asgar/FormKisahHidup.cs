using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYuk_Asgar
{
    public partial class FormKisahHidup : Form
    {
        public FormKisahHidup()
        {
            InitializeComponent();
        }
        FormRegister form;
        public User user;
        Organisasi orgPilih;
        
        private void FormKisahHidup_Load(object sender, EventArgs e)
        {
            form = (FormRegister)this.Owner;
            List<Organisasi> listOrganisasi= Organisasi.BacaData();
            comboBoxOrganisasi.DataSource = listOrganisasi;
            comboBoxOrganisasi.DisplayMember = "Nama";
            labelUsername.Text = user.Username;
        }

        private void buttonTambahOrganisasi_Click(object sender, EventArgs e)
        {
            FormOrganisasi form = new FormOrganisasi();
            form.Owner = this;
            form.ShowDialog();
            FormKisahHidup_Load(sender, e);
        }

        

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            int cek = 0;
            if (dataGridViewData.Rows.Count != 1)
            {
                for (int i = 0; i < dataGridViewData.Rows.Count - 1; i++)
                {
                    if (dataGridViewData.Rows[i].Cells["Organisasi"].Value.ToString() == comboBoxOrganisasi.Text &&
                        dataGridViewData.Rows[i].Cells["Thawal"].Value.ToString() == textBoxTanggalAwal.Text &&
                         dataGridViewData.Rows[i].Cells["Thakhir"].Value.ToString() == textBoxTanggalAkhir.Text)
                    {
                        MessageBox.Show("Kisah Hidup Sudah Ditambahkan");
                        cek = 1;
                    }
                }
            }

            if (cek == 0)
            {
                dataGridViewData.Rows.Add(orgPilih.Id,orgPilih.Nama,orgPilih.Kota.Nama, user.Username , textBoxTanggalAwal.Text, textBoxTanggalAkhir.Text, textBoxDeskripsi.Text);
            }
        }

        private void comboBoxOrganisasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            orgPilih = (Organisasi)comboBoxOrganisasi.SelectedItem; 
            labelKota.Text = orgPilih.Kota.Nama.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSimpanKisahHidup_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewData.Rows.Count; i++)
                {
                    Organisasi o = new Organisasi();
                    DataGridViewRow row = dataGridViewData.Rows[i];
                    o.Id = int.Parse(row.Cells[0].Value.ToString());
                    o.Nama = row.Cells[1].Value.ToString();
                    Kota k = new Kota();
                    //k = Kota.BacaData("nama", row.Cells[2].Value.ToString());
                    k.Id = orgPilih.Kota.Id;
                    k.Nama = row.Cells[2].Value.ToString();
                    o.Kota = k;
                    string tahunAwal = row.Cells[3].Value.ToString();
                    string tahunAkhir = row.Cells[4].Value.ToString();
                    string deskripsi = row.Cells[5].Value.ToString();

                    user.TambahKisahHidup(o, tahunAwal, tahunAkhir, deskripsi);
                }
                User.InsertKisahHidup(user);
                Console.WriteLine(user.ListKisahHidup.Count);
                
                MessageBox.Show("Kisah Hidup Berhasil Disimpan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
