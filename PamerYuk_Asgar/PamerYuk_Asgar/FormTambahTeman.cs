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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PamerYuk_Asgar
{
    public partial class FormTambahTeman : Form
    {
        FormMenu form;
        public User user;

        public FormTambahTeman()
        {
            InitializeComponent();
        }

        private void FormTambahTeman_Load(object sender, EventArgs e)
        {
            try
            {
                form = (FormMenu)this.MdiParent;

                List<User> listUser = User.PencariTeman("", "", user);
                for (int i = 0; i < listUser.Count; i++)
                {
                    dataGridViewTeman.Rows.Add(listUser[i].Username);
                }

                if (dataGridViewTeman.ColumnCount == 1)
                {
                    DataGridViewButtonColumn btnLihat = new DataGridViewButtonColumn();
                    btnLihat.Text = "Lihat Profil";
                    btnLihat.HeaderText = "";
                    btnLihat.UseColumnTextForButtonValue = true;
                    btnLihat.Name = "btnLihatGrid";
                    dataGridViewTeman.Columns.Add(btnLihat);

                    List<Teman> listTeman = User.BacaDataTeman("", "", user);

                    DataGridViewButtonColumn btnTambah = new DataGridViewButtonColumn();
                    btnTambah.Text = "Tambah Teman";
                    btnTambah.HeaderText = "";
                    btnTambah.UseColumnTextForButtonValue = true;
                    btnTambah.Name = "btnTambahGrid";
                    dataGridViewTeman.Columns.Add(btnTambah);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void dataGridViewTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string kode = dataGridViewTeman.CurrentRow.Cells["Username"].Value.ToString();

                if (e.ColumnIndex == dataGridViewTeman.Columns["btnTambahGrid"].Index)
                {
                    DialogResult jawaban = MessageBox.Show("Kirim permintaan pertemanan?", "Information", MessageBoxButtons.YesNo);
                    if (jawaban == DialogResult.Yes)
                    {
                        User teman = User.BacaData("Username", kode)[0];
                        bool cek = user.TambahTeman(teman);
                        if (cek == false)
                        {
                            MessageBox.Show("Permintaan berhasil dikirim");
                        }
                        else
                        {
                            MessageBox.Show("Anda telah berteman dengan user ini");
                        }
                    }
                }
                else
                {
                    FormLihatProfil form = new FormLihatProfil();
                    form.user = User.BacaData("username", kode)[0];
                    form.Owner = this;
                    form.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Anda sudah berteman dengan user ini");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string filter;
            if (comboBoxCari.SelectedIndex == 0)
            {
                filter = "username";
            }
            else if(comboBoxCari.SelectedIndex == 1)
            {
                filter = "ko.nama";
            }
            else
            {
                filter = "o.nama";
            }
            string nilai = textBoxCari.Text;
            dataGridViewTeman.Rows.Clear();
            List<User> listUser = User.PencariTeman(filter, nilai, user);
            for (int i = 0; i < listUser.Count; i++)
            {
                dataGridViewTeman.Rows.Add(listUser[i].Username);
            }
        }

        private void FormTambahTeman_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.panelBG.Visible = true;
            form.LoadButton();
            form.labelUser.Visible = true;
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonFriendRequest_Click(object sender, EventArgs e)
        { 
            FormFriendRequest form = new FormFriendRequest();
            form.userLogin = user;
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
