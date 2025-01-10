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
    public partial class FormChatTeman : Form
    {
        FormMenu form;
        public User user;
        public bool check = false;

        public FormChatTeman()
        {
            InitializeComponent();
        }

        private void FormChat_Load(object sender, EventArgs e)
        {
            form = (FormMenu)this.MdiParent;
            List<Teman> listTeman = User.CariTeman(user);
            comboBoxTeman.DataSource = listTeman;
            comboBoxTeman.DisplayMember = "user2";
            if (check == false)
            {
                comboBoxTeman.SelectedIndex = -1;
            }
        }

        private void buttonAddChat_Click(object sender, EventArgs e)
        {
            try
            {
                Chat chat = new Chat();
                chat.Saya = user;
                chat.Temanku = Chat.Teman("username", comboBoxTeman.Text);
                if (textBoxAdd.Text == "")
                {
                    throw new Exception("Isi Pesan Tidak Ada");
                }

                chat.Isi = textBoxAdd.Text;
                chat.Tanggal = DateTime.Now;
                Chat.TambahChat(chat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBoxTeman_SelectedIndexChanged(sender, e);
        }

        private void comboBoxTeman_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxChat.Items.Clear();
            List<Chat> listChat = Chat.BacaData(user.Username, comboBoxTeman.Text);
            for (int i = 0; i < listChat.Count; i++)
            {
                listBoxChat.Items.Add("[" + listChat[i].Tanggal.ToString() + "] " + listChat[i].Saya.Username + " : " + listChat[i].Isi + "\n");
            }
        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
