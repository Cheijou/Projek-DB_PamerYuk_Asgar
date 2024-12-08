using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class Kota
    {
        #region Data Member

        private int id;
        private string nama;
        #endregion

        #region Constructor
        public Kota()
        {
            this.Id = 0;
            this.Nama = "";
        }

        public Kota(int id, string nama)
        {
            this.Id = id;
            this.Nama = nama;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Method 
        public static List<Kota> BacaData(string filter = "", string nilai = "")
        {
            string perintah = "select k.* from kota k";
            if (filter != "")
            {
                perintah += " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Kota> ListData = new List<Kota>();
            while (hasil.Read() == true)
            {
                Kota tampung = new Kota();
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Nama = hasil.GetValue(1).ToString();
                ListData.Add(tampung);
            }
            return ListData;

        }
        #endregion
    }
}

