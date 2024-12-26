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
        public Komen(int id, string komentar, DateTime tgl, User user, Konten konten)
        {
            this.Id = id;
            this.Komentar = komentar;
            this.Tgl = tgl;
            this.User = user;
            this.Konten = konten;
        }

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
        //public static List<Komen> BacaData()
        //{
        //    string perintah = "select km.*, u.*, k.* from komen km inner join user u on km.username = u.username " +
        //        "inner join konten k on km.Konten_id = k.id ";

        //    MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

        //    List<Komen> ListData = new List<Komen>();
        //    while (hasil.Read() == true)
        //    {
        //        Komen tampung = new Komen();
        //        tampung.Id = int.Parse(hasil.GetValue(0).ToString());
        //        tampung.Komentar = hasil.GetValue(1).ToString();
        //        tampung.Tgl = DateTime.Parse(hasil.GetValue(2).ToString());
        //        User user = new User();
        //        user.Password = ""; //ga boleh di show 
        //        user.TglLahir = DateTime.Parse(hasil.GetValue(7).ToString());
        //        user.NoKtp = hasil.GetValue(8).ToString();
        //        //user.Foto = hasil.GetValue(9).ToString();
        //        user.Kota.Id = int.Parse(hasil.GetValue(10).ToString());

        //        Konten konten = new Konten();
        //        konten.Id = int.Parse(hasil.GetValue(11).ToString());
        //        konten.Caption = hasil.GetValue(12).ToString();
        //        konten.Foto = hasil.GetValue(13).ToString();
        //        konten.Video = hasil.GetValue(14).ToString();
        //        konten.TglUpload = DateTime.Parse(hasil.GetValue(15).ToString());


        //        tampung.User = user;
        //        tampung.Konten = konten;
        //        ListData.Add(tampung);
        //    }
        //    return ListData;

        //}

        public static void TambahKomen(Komen objekTambah)
        {
            //kurang foto
            string perintah = "INSERT INTO Komen (komentar, tgl, username, konten_id) VALUES ('" + objekTambah.Komentar + "', '" + objekTambah.Tgl.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + objekTambah.User.Username
                + "', '" + objekTambah.Konten.Id + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        //public static void UpdateData(Komen objekUbah)
        //{
        //    string perintah = "UPDATE Komen SET Komentar ='" + objekUbah.Komentar + "' ,tgl='" + objekUbah.Tgl + "' ,username ='" + objekUbah.User.Username 
        //        + "' WHERE id='" + objekUbah.Id + "';";

        //    Koneksi.JalankanPerintahNonQuery(perintah);
        //}
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
