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
    public partial class FormEditProfil : Form
    {
        FormMenu form;
        public User user;
        string gambarPath = "";
        Kota kotaPilih;
        public FormEditProfil()
        {
            InitializeComponent();
        }

       

        private void FormEditProfil_Load(object sender, EventArgs e)
        {
            user = User.BacaDataTerbaruUser(user.Username);
            form = (FormMenu)this.MdiParent;
            if (user.Foto != "")
            {
                pictureBox1.Image = Image.FromFile(user.Foto);
                gambarPath = user.Foto;
            }
            labelUsername.Text = user.Username;
            textBoxTanggalLahir.Text = user.TglLahir.ToString("yyyy-MM-dd");
            comboBoxKota.DataSource = Kota.BacaData();
            comboBoxKota.DisplayMember= "Name";
            comboBoxKota.Text = user.Kota.Nama;
        }

        private void FormEditProfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.panelBG.Visible = true;
            form.LoadButton();
            form.labelUser.Visible = true;
        }

        private void buttonEditKisahHidup_Click(object sender, EventArgs e)
        {
            FormKisahHidup formKisah = new FormKisahHidup();
            formKisah.user = user;
            formKisah.ShowDialog();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Choose Image(*.JPG;*.PNG)|*.jpg;*.png";
            open.Title = "Select a Image File";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                gambarPath = open.FileName;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            User update = new User();
            update.Username = labelUsername.Text;
            update.Kota = kotaPilih;
            update.TglLahir = DateTime.Parse(textBoxTanggalLahir.Text);
            update.Foto = gambarPath;
            User.UpdateData(update);
            MessageBox.Show("Data berhasil diperbarui");
        }

        private void comboBoxKota_SelectedIndexChanged(object sender, EventArgs e)
        {
            kotaPilih = (Kota)comboBoxKota.SelectedItem;
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
