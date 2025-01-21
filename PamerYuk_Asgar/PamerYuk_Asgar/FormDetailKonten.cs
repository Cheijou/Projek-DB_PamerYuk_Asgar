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
        FormKontenSaya formKontenSaya;
        public User user;
        public string kontenId;
        Konten konten;
        public string cekForm;
        FormTagMasuk formTag;
        private void FormDetailKonten_Load(object sender, EventArgs e)
        {
            try
            {
                if (cekForm == "FormKonten")
                {
                    form = (FormKonten)this.Owner;
                }
                else if (cekForm == "FormTag")
                {
                    formTag = (FormTagMasuk)this.Owner;
                }
                else
                {
                    formKontenSaya=(FormKontenSaya)this.Owner;
                }
                int total = Konten.HitungTotalLikes("konten_id", kontenId);
                bool isLiked = Konten.CekLike("username", user.Username, kontenId);
                if (isLiked == true)
                {
                    buttonLike.Text = "Unlike";
                }
                else
                {
                    buttonLike.Text = "Like";
                }
                List<Tag> listTag = Konten.BacaTag("konten_id", kontenId);
                for (int i = 0; i < listTag.Count; i++)
                {
                    if (i < listTag.Count - 1)
                    {
                        labelTag.Text += listTag[i].User.Username + ", ";
                    }
                    else
                    {
                        labelTag.Text += listTag[i].User.Username;
                    }
                }
                labelTotalLike.Text = total.ToString();
                konten = Konten.BacaData("id", kontenId)[0];
                if (konten.Video != "")
                {
                    axWindowsMediaPlayerVideo.URL = konten.Video;
                    axWindowsMediaPlayerVideo.Ctlcontrols.play();
                    axWindowsMediaPlayerVideo.stretchToFit = true;
                }
                if (konten.Foto != "")
                {
                    pictureBoxGambar.Image = Image.FromFile(konten.Foto);
                    labelHasilCaption.Text = konten.Caption;
                }
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
                    buttonLike.Text = "Unlike";
                }
                else
                {
                    konten.HapusLike(kontenId, user);
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

        private void labelHasilCaption_Click(object sender, EventArgs e)
        {

        }
    }
}
