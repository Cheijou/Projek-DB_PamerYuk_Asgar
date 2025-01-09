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
    public partial class FormDetailKonten : Form
    {
        public FormDetailKonten()
        {
            InitializeComponent();
        }


        FormKonten form;
        public User user;
        public string kontenId;
        Konten konten;

        private void FormDetailKonten_Load(object sender, EventArgs e)
        {
            try
            {
                form = (FormKonten)this.Owner;
                int total = Konten.HitungTotalLikes("konten_id", kontenId);
                bool isLiked = Konten.CekLike("user_username", user.Username, kontenId);
                if (isLiked == true)
                {
                    buttonLike.Text = "Dislike";
                }
                else
                {
                    buttonLike.Text = "Like";
                }    
                labelTotalLike.Text = total.ToString();
                konten = Konten.BacaData("id", kontenId)[0];
                axWindowsMediaPlayerVideo.URL = konten.Video;
                axWindowsMediaPlayerVideo.Ctlcontrols.play();
                axWindowsMediaPlayerVideo.stretchToFit = true;
                pictureBoxGambar.Image = Image.FromFile(konten.Foto);
                labelHasilCaption.Text = konten.Caption;
                List<Komen> listKomen = Komen.BacaData(kontenId);
                for (int i = 0; i < listKomen.Count; i++)
                {
                    listBoxKomentar.Items.Add("[" + listKomen[i].Tgl.ToString() + "] " + listKomen[i].User.Username + " : " + listKomen[i].Komentar + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTambahKomentar_Click(object sender, EventArgs e)
        {
            try
            {
                Komen komen = new Komen();
                komen.Komentar = textBoxKomen.Text;
                komen.Tgl = DateTime.Now;
                komen.User = user;
                komen.Konten = konten;
                Komen.TambahKomen(komen);
                listBoxKomentar.Items.Add("[" + komen.Tgl.ToString() + "] " + komen.User.Username + " : " + komen.Komentar + "\n");
            }
            catch (Exception)
            {
                MessageBox.Show("Chat Gagal Terkirim");
            }
            textBoxKomen.Clear();
            labelTextBox.Visible = true;
            labelTextBox.Enabled = true;
            listBoxKomentar.Refresh();
        }

        

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            labelTextBox.Visible= true;
            labelTextBox.Enabled = true;
            textBoxKomen.Clear();

        }

        private void textBoxKomen_Click(object sender, EventArgs e)
        {
            labelTextBox.Visible = false;
            labelTextBox.Enabled = false;
        }

        private void axWindowsMediaPlayerVideo_Enter(object sender, EventArgs e)
        {

        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonLike.Text == "Like")
                {
                    konten.TambahLike(user, kontenId);
                    MessageBox.Show("Berhasil Like");
                    buttonLike.Text = "Dislike";
                }
                else
                {
                    konten.HapusLike(kontenId, user);
                    MessageBox.Show("Sdh dislik");
                    buttonLike.Text = "Like";
                }
                int total = Konten.HitungTotalLikes("konten_id", kontenId);
                labelTotalLike.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
