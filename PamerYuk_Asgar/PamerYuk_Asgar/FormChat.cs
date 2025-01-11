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
    public partial class FormChat : Form
    {
        public User user;
        FormMenu form;
        public FormChat()
        {
            InitializeComponent();
        }

        private void FormChat_Load(object sender, EventArgs e)
        {
            form = (FormMenu)this.MdiParent;
            Chat.UpdateNotif(user);
            
            List<Chat> listChat = Chat.BacaDataChatTerbaru(user);
            for (int i = 0; i < listChat.Count; i++)
            {
                dataGridViewData.Rows.Add(listChat[i].Temanku.Username, "[" + listChat[i].Tanggal.ToString()+"] " + listChat[i].Isi);
                if (dataGridViewData.ColumnCount == 2)
                {
                    DataGridViewButtonColumn btnChat = new DataGridViewButtonColumn();
                    btnChat.Text = "Buka Chat";
                    btnChat.HeaderText = "";
                    btnChat.UseColumnTextForButtonValue = true;
                    btnChat.Name = "btnChatGrid";
                    dataGridViewData.Columns.Add(btnChat);
                }
            }
            
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string teman = dataGridViewData.CurrentRow.Cells["Username"].Value.ToString();

            if (e.ColumnIndex == dataGridViewData.Columns["btnChatGrid"].Index)
            {
                Form form = Application.OpenForms["FormChatTeman"];
                if (form == null)
                {
                    FormChatTeman formChatTeman = new FormChatTeman();
                    formChatTeman.user = user;
                    formChatTeman.selectedFriend = teman;
                    formChatTeman.check = true;
                    formChatTeman.Show();
                    formChatTeman.BringToFront();
                }
                else
                {
                    form.Show();
                }
            }
        }

        private void buttonChatTeman_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormChatTeman"];

            if (form == null)
            {
                FormChatTeman formChatTeman = new FormChatTeman();
                formChatTeman.user = user;
                formChatTeman.Show();
                formChatTeman.BringToFront();
            }
            else
            {
                form.Show();
            }
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.panelBG.Visible = true;
            form.LoadButton();
            form.labelUser.Visible = true;
            form.labelJumlahNotif.Visible = false;
        }
    }
}

