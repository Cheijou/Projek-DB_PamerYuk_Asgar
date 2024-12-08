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
    public partial class FormKonten : Form
    {
        public FormKonten()
        {
            InitializeComponent();
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewKonten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Konten> listKonten = Konten.BacaData();
            dataGridViewKonten.DataSource = listKonten;

            if (dataGridViewKonten.ColumnCount == 6)
            {
                DataGridViewButtonColumn btnKomen = new DataGridViewButtonColumn();
                btnKomen.Text = "Komen";
                btnKomen.HeaderText = "";
                btnKomen.UseColumnTextForButtonValue = true;
                btnKomen.Name = "btnKomenGrid";
                dataGridViewKonten.Columns.Add(btnKomen);
            }
        }

        private void FormKonten_Load(object sender, EventArgs e)
        {

        }
    }
}
