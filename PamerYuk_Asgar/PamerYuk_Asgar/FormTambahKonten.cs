using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYuk_Asgar
{
    public partial class FormTambahKonten : Form
    {
        public FormTambahKonten()
        {
            InitializeComponent();
        }
        FormKonten form;
        public User user;
        Konten konten = new Konten();
        string videoPath;
        string gambarPath;

        private void buttonTambahPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Choose Image(*.JPG;*.PNG)|*.jpg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxGambar.Image = Image.FromFile(open.FileName);
                gambarPath = open.FileName;
            }
        }

        private void buttonTambahVideo_Click(object sender, EventArgs e)
        {
            string video ="";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Choose Video(*.MP4;*.MOV;*.AVI)|*.mp4;*.mov;*.avi";
            if (open.ShowDialog() == DialogResult.OK)
            {
                video = open.FileName;
                videoPath = open.FileName;
            }
            axWindowsMediaPlayerVideo.URL = video;
            axWindowsMediaPlayerVideo.Ctlcontrols.play();
        }

        private void labelPicture_Click(object sender, EventArgs e)
        {

        }

        private void FormTambahKonten_Load(object sender, EventArgs e)
        {
            form = (FormKonten)this.Owner;
            List<Teman> listTeman = User.CariTeman(user);
            comboBoxTag.DataSource = listTeman;
            comboBoxTag.DisplayMember = "user2";
            

        }

        private void buttonTambahTag_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user= Konten.Teman("username", comboBoxTag.Text);
                konten.TambahTag(user);
                listBoxTag.Items.Add(comboBoxTag.Text);
                MessageBox.Show("Berhasil Menambahkan Tag");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonTambahKonten_Click(object sender, EventArgs e)
        {
            try
            {
                konten.Caption = textBoxCaption.Text;
                konten.Foto = gambarPath;
                konten.Video = videoPath;
                konten.TglUpload = DateTime.Now;
                konten.User = user;
                Konten.InsertKonten(konten);
                MessageBox.Show("Berhasil Menambahkan Konten");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
