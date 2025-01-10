using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PamerYuk_Asgar
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        FormLogin form;
        string gambarPath ="";

        private void FormRegister_Load(object sender, EventArgs e)
        {
            form = (FormLogin)this.Owner;
            List<Kota> listKota = Kota.BacaData();
            comboBoxKota.DataSource = listKota;
            comboBoxKota.DisplayMember = "Nama";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User();
                u.Username = textBoxUsername.Text;
                u.Password = textBoxPassword.Text;
                u.NoKtp = textBoxNoKTP.Text;
                u.TglLahir = dateTimePickerTanggalLahir.Value;
                u.Foto = gambarPath;
                u.Kota = (Kota)comboBoxKota.SelectedItem;
                User.TambahData(u);
                MessageBox.Show("Registrasi Berhasil Disimpan");
                this.Close();
                FormKisahHidup form = new FormKisahHidup();
                form.user = u;
                form.Owner = this;
                form.ShowDialog();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }

        }

        private void pictureBoxPFP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Choose Image(*.JPG;*.PNG)|*.jpg;*.png";
            open.Title = "Select a Image File";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPFP.Image = Image.FromFile(open.FileName);
                gambarPath = open.FileName;
            }
        }
    }
}
