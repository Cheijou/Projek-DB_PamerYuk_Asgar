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
    public partial class FormLihatProfil : Form
    {
        FormMenu form;
        FormTambahTeman form2;
        public User user;
        public string cek;
        public FormLihatProfil()
        {
            InitializeComponent();
        }

        private void FormLihatProfil_Load(object sender, EventArgs e)
        {
            if (cek == "FormMenu")
            {
                form = (FormMenu)this.Owner;
            }
            else
            {
                form2 = (FormTambahTeman)this.Owner;
            }
            labelUsername.Text = user.Username;
            labelTglLahir.Text = user.TglLahir.ToString("MM-dd-yyyy");
            if (user.Foto != "")
            {
                pictureBox1.Image = Image.FromFile(user.Foto);
            }
            labelKota.Text = user.Kota.Nama;
            List<KisahHidup> listKisah = User.BacaDataKisahHidup("username", user.Username);
            for (int i = 0; i < listKisah.Count; i++) 
            {
                dataGridViewKisah.Rows.Add(listKisah[i].Organisasi.Nama, 
                    listKisah[i].Organisasi.Kota, listKisah[i].Thawal, listKisah[i].Thakhir,
                    listKisah[i].Deskripsi);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            DialogResult jawaban = MessageBox.Show("Kirim permintaan pertemanan?", "Information", MessageBoxButtons.YesNo);
            if (jawaban == DialogResult.Yes)
            {
                User teman = User.BacaData("Username", user.Username)[0];
                bool cek = user.TambahTeman(teman);
                if (cek == false)
                {
                    MessageBox.Show("Permintaan berhasil dikirim");
                }
                else
                {
                    MessageBox.Show("Anda sekarang telah berteman dengan " + teman);
                }
            }
        }

        private void FormLihatProfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cek == "FormMenu")
            {
                form.panelBG.Visible = true;
                form.LoadButton();
                form.labelUser.Visible = true;
                form.labelJumlahNotif.Visible = false;
            }
        }
    }
}
