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
    public partial class FormOrganisasi : Form
    {
        public FormOrganisasi()
        {
            InitializeComponent();
        }

        FormKisahHidup form; 
        private void FormOrganisasi_Load(object sender, EventArgs e)
        {
            form = (FormKisahHidup)this.Owner;
            List<Kota> listKota = Kota.BacaData();
            comboBoxKota.DataSource = listKota;
            comboBoxKota.DisplayMember = "Nama";
        }

        private void buttonTambahOrganisasi_Click(object sender, EventArgs e)
        {
            try
            {
                Organisasi u = new Organisasi();
                u.Nama = textBoxNama.Text;
                u.Kota = (Kota)comboBoxKota.SelectedItem;
                Organisasi.TambahData(u);
                MessageBox.Show("Organisasi Berhasil Disimpan");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Organisasi Gagal Disimpan");
            }
        }
    }
}
