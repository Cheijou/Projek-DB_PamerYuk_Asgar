using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Microsoft.SqlServer.Server;
using System.Net.Http.Headers;

namespace Class_PamerYuk
{
    public class User
    {
        #region Data Member
        private string username;
        private string password;
        private DateTime tglLahir;
        private string noKtp;
        private Image foto;
        private Kota kota;
        private List<KisahHidup> listKisahHidup;
        private List<Teman> listTeman;

        #endregion

        #region Constructor
        public User()
        {
            this.Username = "";
            this.Password = "";
            this.TglLahir = DateTime.Now;
            this.NoKtp = "";
            this.Foto = null;
            this.Kota = new Kota();
            this.ListKisahHidup = new List<KisahHidup>();
            this.listTeman = new List<Teman>();

        }

        public User(string username, string password, DateTime tglLahir, string noKtp, Image foto, Kota kota)
        {
            this.Username = username;
            this.Password = password;
            this.TglLahir = tglLahir;
            this.NoKtp = noKtp;
            this.Foto = foto;
            this.Kota = kota;
        }
        #endregion

        #region Properties
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string NoKtp { get => noKtp; set => noKtp = value; }
        public Image Foto { get => foto; set => foto = value; }
        public  Kota Kota { get => kota; set => kota = value; }
        public List<KisahHidup> ListKisahHidup { get => listKisahHidup; set => listKisahHidup = value; }
        public List<Teman> ListTeman { get => listTeman; set => listTeman = value; }

        #endregion

        #region Method 
        public static User CekLogin(string uid = "", string passwd = "")
        {
            string perintah = "select * from User " +
                "where username ='" + uid + "' and password = '" + passwd + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read() == true)
            {
                // ambil isi datareader
                User user = new User();
                user.Username = hasil.GetValue(0).ToString();
                user.Password = hasil.GetValue(1).ToString();
                user.TglLahir = DateTime.Parse(hasil.GetValue(2).ToString());
                user.NoKtp = hasil.GetValue(3).ToString();
                //user.Foto = hasil.GetValue(4).ToString();
                user.Kota = Kota.BacaData("id", hasil.GetValue(5).ToString())[0];
                // tambahkan ke list
                return user;
            }
            else
            {
                return null;
            }
            // kirim kembali list ke pemanggilnya
        }
        public static List<User> BacaData(string filter = "", string nilai = "")
        {
            string perintah = "select * from User";
            if (filter != "")
            {
                perintah += " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<User> listPengguna = new List<User>();
            while (hasil.Read() == true)
            {
                User user = new User();
                user.Username = hasil.GetValue(0).ToString();
                user.Password = hasil.GetValue(1).ToString();
                user.TglLahir = DateTime.Parse(hasil.GetValue(2).ToString());
                user.NoKtp = hasil.GetValue(3).ToString();
                //user.Foto = hasil.GetValue(4).ToString();
                user.Kota = Kota.BacaData("id", hasil.GetValue(5).ToString())[0];
                // tambahkan ke list
                listPengguna.Add(user);
            }
            return listPengguna;
        }

        public static void TambahData(User objekTambah)
        {
            //kurang foto
            string perintah = "INSERT INTO User (username, password, tglLahir, noKTP, Kota_id) VALUES ('"+ objekTambah.Username + "', '" +objekTambah.Password + "', '" + objekTambah.tglLahir.ToString("yyyy-MM-dd")
                + "', '" + objekTambah.noKtp + "', '" + objekTambah.Kota.Id + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void UpdateData(User objekUbah)
        {
            string perintah = "UPDATE User SET Username ='"+ objekUbah.Username + "' ,tglLahir='" + objekUbah.TglLahir + "' ,Kota_id ='" + objekUbah.Kota.Id 
               /* +"' ,foto='" + objekUbah.Foto*/ +"' WHERE username='" + objekUbah.username + "';";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void UpdatePasword(User objekUbah)
        {
            string perintah = "UPDATE User SET password='" + objekUbah.Password + "' WHERE username='" + objekUbah.username + "';";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public void TambahKisahHidup(Organisasi organisasi, string tahunAwal, string Akhir, string Deskripsi)
        {
            KisahHidup k = new KisahHidup();
            k.Organisasi = organisasi;
            k.Thawal = tahunAwal;
            k.Thakhir = Akhir;
            k.Deskripsi = Deskripsi;    
            ListKisahHidup.Add(k);
        }
        //public static List<KisahHidup> BacaDataKisahHidup(string filter = "", string nilai = "")
        //{
        //    string perintah = "select * from kisahhidup;";
        //    if (filter != "")
        //        perintah += " where " + filter + " like'%" + nilai + "%';";

        //    MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

        //    List<KisahHidup> ListData = new List<KisahHidup>();
        //    while (hasil.Read() == true)
        //    {
        //        KisahHidup tampung = new KisahHidup();
        //        tampung.Organisasi = Organisasi.BacaData("id", hasil.GetValue(0).ToString())[0];
        //        tampung.User = User.BacaData("username", hasil.GetValue(1).ToString())[0];
        //        tampung.Thawal = hasil.GetValue(2).ToString();
        //        tampung.Thakhir = hasil.GetValue(3).ToString();
        //        tampung.Deskripsi = hasil.GetValue(4).ToString();  
        //        ListData.Add(tampung);
        //    }
        //    return ListData;
        //}

        public static void InsertKisahHidup(User u)
        {
            string perintah;
            for (int i = 0; i < u.ListKisahHidup.Count; i++)
            {
                perintah = "INSERT INTO kisahhidup (organisasi_id, username, thawal, thakhir, deskripsi) "
                + "VALUES ('" + u.ListKisahHidup[i].Organisasi.Id + "', '" + u.Username + "', '" + u.ListKisahHidup[i].Thawal + "', '" + u.ListKisahHidup[i].Thakhir 
                + "', '" + u.ListKisahHidup[i].Deskripsi  + "');";
                Koneksi.JalankanPerintahNonQuery(perintah);
            }
        }

        public bool TambahTeman(User User2)
        {
            Teman t = new Teman();
            t.User2 = User2;
            ListTeman.Add(t);
            bool cek = InsertTeman(User2.Username);
            return cek;
        }

        public bool InsertTeman(string penerima)
        {
            bool cek = false;
            string perintah = "select * from teman where username2 = '" + Username + "' and username1 = '" + penerima +"';";

            Koneksi.JalankanPerintahSelect(perintah);
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read() == true)
            {
                TerimaTeman(penerima);
                cek = true;
            }
            else
            {
                perintah = "INSERT INTO teman (username1, username2) "
                + "VALUES ('" + Username + "', '" + penerima + "');";
                Koneksi.JalankanPerintahNonQuery(perintah);
            }
            return cek;
        }

        public void TerimaTeman(string pengirim)
        {
            string perintah = "update teman set tglberteman = " + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "' where username1 = '" + pengirim + "' " +
                "and username2 = '" + Username + "'";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public void TolakTeman(string username2)
        {
            string perintah = "delete from teman where username1 = '" + username2 + "' and username2 = '" + Username +"';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static List<Teman> Permintaan(User userLogin)
        {
            string perintah = "select * from teman where username2 = '" + userLogin.Username + "' and tglBerteman is null;";
            Koneksi.JalankanPerintahSelect(perintah);

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Teman> listPermintaan = new List<Teman>();

            while (hasil.Read() == true)
            {
                Teman t = new Teman();
                t.User2 = User.BacaData("username", hasil.GetValue(0).ToString())[0];
                t.TglBerteman = DateTime.MinValue;
                listPermintaan.Add(t);
            }
            return listPermintaan;
        }

        public static List<User> PencariTeman(string filter = "", string nilai = "",User userLogin = null)
        {
            string perintah = "select distinct u.* from user u inner join kisahhidup k on u.username = k.username inner join organisasi o on k.Organisasi_id = o.id inner join kota ko on u.kota_id = ko.id where u.username != '" + userLogin.Username + 
                "' and (o.Nama in (select o.nama from organisasi o inner join kisahhidup k on o.id = k.organisasi_id where k.username = '" + userLogin.Username + "'));";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<User> listPengguna = new List<User>();


            while (hasil.Read() == true)
            {
                User user = new User();
                user.Username = hasil.GetValue(0).ToString();
                user.Password = hasil.GetValue(1).ToString();
                user.TglLahir = DateTime.Parse(hasil.GetValue(2).ToString());
                user.NoKtp = hasil.GetValue(3).ToString();
                //user.Foto = hasil.GetValue(4).ToString();
                user.Kota = Kota.BacaData("id", hasil.GetValue(5).ToString())[0];
                // tambahkan ke list
                listPengguna.Add(user);
            }
            return listPengguna;
            
        }
        public override string ToString()
        {
            return Username;
        }
        #endregion

        #region Buangan
        //public static List<KisahHidup> BacaKisahHidup(User user)
        //{
        //    string perintah = "select * from kisahhidup k where k.username = '" + user.Username + "';";
        //    MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
        //    List<KisahHidup> listKisah = new List<KisahHidup>();
        //    while (hasil.Read() == true)
        //    {
        //        KisahHidup b = new KisahHidup();
        //        Organisasi o = new Organisasi();
        //        o = Organisasi.BacaData("k.id", hasil.GetValue(0).ToString())[0];
        //        b.Organisasi = o;
        //        b.Thawal = hasil.GetValue(2).ToString();
        //        b.Thakhir = hasil.GetValue(3).ToString();
        //        b.Deskripsi = hasil.GetValue(4).ToString();
        //        listKisah.Add(b);
        //    }
        //    return listKisah;
        //}
        #endregion
    }
}
