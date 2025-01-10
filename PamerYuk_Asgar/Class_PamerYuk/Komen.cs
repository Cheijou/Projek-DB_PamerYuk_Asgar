using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class Komen
    {
        #region Data Member
        private int id;
        private string komentar;
        private DateTime tgl;
        private User user;
        private Konten konten;
        #endregion

        #region Constructor
        public Komen()
        {
            this.Id = 0;
            this.Komentar = "";
            this.Tgl = DateTime.Now;
            this.User = new User();
            this.Konten = new Konten();
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Komentar { get => komentar; set => komentar = value; }
        public DateTime Tgl { get => tgl; set => tgl = value; }
        public User User { get => user; set => user = value; }
        public Konten Konten { get => konten; set => konten = value; }
        #endregion

        #region Method 
        public static void TambahKomen(Komen objekTambah)
        {
          
            string perintah = "INSERT INTO Komen (komentar, tgl, username, konten_id) VALUES ('" + objekTambah.Komentar + "', '" + objekTambah.Tgl.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + objekTambah.User.Username
                + "', '" + objekTambah.Konten.Id + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

      
        public static List<Komen> BacaData(string kontenId)
        {
            string perintah = "select * from komen";

            perintah += " where (konten_id = '" + kontenId + "') order by tgl desc";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Komen> listKomen = new List<Komen>();
            while (hasil.Read() == true)
            {
                Komen tampung = new Komen();
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Komentar = hasil.GetValue(1).ToString();
                tampung.Tgl = DateTime.Parse(hasil.GetValue(2).ToString());
                tampung.User.Username = hasil.GetValue(3).ToString();
                tampung.Konten.Id =int.Parse(hasil.GetValue(4).ToString());
                listKomen.Add(tampung);
            }
            return listKomen;
        }
        #endregion
    }
}
