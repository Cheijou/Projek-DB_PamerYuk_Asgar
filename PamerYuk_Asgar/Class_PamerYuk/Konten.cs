using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class Konten
    {
        #region Data Member
        private int id;
        private string caption;
        private string foto;
        private string video;
        private DateTime tglUpload;
        private User user;
        private List<Tag> listTag;


        #endregion

        #region Constructor
        public Konten(int id, string caption, string foto, string video, DateTime tglUpload, User user)
        {
            this.Id = id;
            this.Caption = caption;
            this.Foto = foto;
            this.Video = video;
            this.TglUpload = tglUpload;
            this.User = user;
        }

        public Konten()
        {
            this.Id = 0;
            this.Caption = "";
            this.Foto = "";
            this.Video = "";
            this.TglUpload = DateTime.Now;
            this.User = new User();
            this.ListTag = new List<Tag>();
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Caption { get => caption; set => caption = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Video { get => video; set => video = value; }
        public DateTime TglUpload { get => tglUpload; set => tglUpload = value; }
        public User User { get => user; set => user = value; }
        public List<Tag> ListTag { get => listTag; set => listTag = value; }

        #endregion

        #region Method 
        public static List<Konten> BacaData()
        {
            string perintah = "select k.*, u.* from konten k inner join user u on u.username = k.username";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Konten> ListData = new List<Konten>();
            while (hasil.Read() == true)
            {
                Konten tampung = new Konten();
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Caption = hasil.GetValue(1).ToString();
                tampung.Foto = hasil.GetValue(2).ToString();
                tampung.Video= hasil.GetValue(3).ToString();
                tampung.TglUpload = DateTime.Parse(hasil.GetValue(4).ToString());
                User user = new User(); 
                user.Username = hasil.GetValue(5).ToString();
                //dibawah ini jika perlu tambahan, boleh di hapus kalau ga perlu
                user.Password = "";//ga boleh terlihat
                user.TglLahir = DateTime.Parse(hasil.GetValue(8).ToString());
                user.NoKtp = hasil.GetValue(9).ToString();
                //user.Foto = hasil.GetValue(10).ToString();
                tampung.User = user;
                ListData.Add(tampung);
            }
            return ListData;

        }
        public void TambahTag(User user)
        {

            Tag t = new Tag();
            t.User = user;
            if (ListTag != null)
            {
                foreach (Tag tag in ListTag)
                {
                    if (tag.User.Username == user.Username)
                    {
                        throw new Exception("User ini sudah ada didalam Tag");
                    }
                }
            }
            ListTag.Add(t);
        }

        public static void InsertTag(Konten k)
        {
            string perintah;
            for (int i = 0; i < k.ListTag.Count; i++)
            {
                perintah = "INSERT INTO tag (Konten_id, username) "
                + "VALUES ('" + k.Id + "', '" + k.ListTag[i].User.Username + "');";
                Koneksi.JalankanPerintahNonQuery(perintah);
            }
        }

        public static User Teman(string filter = "", string nilai = "")
        {
            string perintah = "select * from User";
            if (filter != "")
            {
                perintah += " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            User user = new User();
            while (hasil.Read() == true)
            {

                user.Username = hasil.GetValue(0).ToString();
                user.Password = hasil.GetValue(1).ToString();
                user.TglLahir = DateTime.Parse(hasil.GetValue(2).ToString());
                user.NoKtp = hasil.GetValue(3).ToString();
                //user.Foto = hasil.GetValue(4).ToString();
                user.Kota = Kota.BacaData("id", hasil.GetValue(5).ToString())[0];

            }
            return user;
        }

        public static void InsertKonten(Konten k)
        {
            string perintah;
            
                perintah = "INSERT INTO konten (caption, foto, video, tglUpload, username) "
                + "VALUES ('" + k.Caption + "', '" + k.foto + "', '" + k.Video + "', '" + k.TglUpload.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + k.User.Username + "');";
                Koneksi.JalankanPerintahNonQuery(perintah);
            k.Id = k.BacaID("username", k.User.ToString(), "tglUpload", k.TglUpload.ToString("yyyy-MM-dd HH:mm:ss"));
            Konten.InsertTag(k);

        }

        public int BacaID(string filter1 = "", string nilai1= "", string filter2 = "", string nilai2 = "")
        {
            string perintah = "select k.*, u.* from konten k inner join user u on u.username = k.username";
            if (filter1 != "")
            {
                perintah += " where (k." + filter1 + " like '%" + nilai1 + "%') and (" + filter2 + " like '%" + nilai2 + "%')";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            int kontenId=0;
            while (hasil.Read()==true)
            {
                kontenId = int.Parse(hasil.GetValue(0).ToString());
            }
            return kontenId;

        }

        public static List<Konten> Daftarkonten(User userLogin)
        {
            string perintah = "select Distinct k.* from konten k " +
                "inner join user u on k.username = u.username  " + 
                "where (k.username = '" + userLogin.Username + "') " +
                "or " +
                "(k.username in (select k2.username from  konten k2 " +
                "inner join user u2 on k2.username = u2.username " +
                "inner join teman t on u2.username = t.username1 " +
                "inner join teman tm on u2.username = tm.username2 " +
                "where k2.username = '" + userLogin.Username +"')) order by k.tglUpload asc";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Konten> ListData = new List<Konten>();
            while (hasil.Read() == true)
            {
                Konten tampung = new Konten();
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Caption = hasil.GetValue(1).ToString();
                tampung.Foto = hasil.GetValue(2).ToString();
                tampung.Video = hasil.GetValue(3).ToString();
                tampung.TglUpload = DateTime.Parse(hasil.GetValue(4).ToString());
                User user = new User();
                user.Username = hasil.GetValue(5).ToString();
                
                tampung.User = user;
                ListData.Add(tampung);
            }
            return ListData;

        }

        #endregion
    }
}
