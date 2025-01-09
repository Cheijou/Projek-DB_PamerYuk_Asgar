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
        private string foto;
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
            this.ListTeman = new List<Teman>();

        }

        public User(string username, string password, DateTime tglLahir, string noKtp, string foto, Kota kota)
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
        public string Foto { get => foto; set => foto = value; }
        public  Kota Kota { get => kota; set => kota = value; }
        public List<KisahHidup> ListKisahHidup { get => listKisahHidup; set => listKisahHidup = value; }
        public List<Teman> ListTeman { get => listTeman; set => listTeman = value; }

        #endregion

        #region Method User
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
                user.Foto = hasil.GetValue(4).ToString();
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
            string perintah = "select u.*,k.nama from User u inner join kota k on u.kota_id = k.id";
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
                //user.Password = hasil.GetValue(1).ToString();
                user.TglLahir = DateTime.Parse(hasil.GetValue(2).ToString());
                user.NoKtp = hasil.GetValue(3).ToString();
                user.Foto = hasil.GetValue(4).ToString();
                user.Kota.Nama = hasil.GetValue(6).ToString();
                // tambahkan ke list
                listPengguna.Add(user);
            }
            return listPengguna;
        }

        public static void TambahData(User objekTambah)
        { 
            //kurang foto
            string perintah = "INSERT INTO User (username, password, tglLahir, noKTP, foto, Kota_id) VALUES ('"+ objekTambah.Username + "', '" +objekTambah.Password + "', '" + objekTambah.tglLahir.ToString("yyyy-MM-dd")
                + "', '" + objekTambah.noKtp + "', '" + objekTambah.Foto.Replace("\\", "\\\\") + "', '" + objekTambah.Kota.Id + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void UpdateData(User objekUbah)
        {
            string perintah = "UPDATE User SET tglLahir='" + objekUbah.TglLahir.ToString("yyyy-MM-dd") + "' ,Kota_id ='" + objekUbah.Kota.Id
                + "' ,foto='" + objekUbah.Foto.Replace("\\", "\\\\") + "' WHERE username='" + objekUbah.username + "';";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void UpdatePasword(User objekUbah)
        {
            string perintah = "UPDATE User SET password='" + objekUbah.Password + "' WHERE username='" + objekUbah.username + "';";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        #endregion

        #region Method Kisah Hidup
        public void TambahKisahHidup(Organisasi organisasi, string tahunAwal, string Akhir, string Deskripsi)
        {
            KisahHidup k = new KisahHidup();
            k.Organisasi = organisasi;
            k.Thawal = tahunAwal;
            k.Thakhir = Akhir;
            k.Deskripsi = Deskripsi;    
            ListKisahHidup.Add(k);
        }

        public static List<KisahHidup> BacaDataKisahHidup(string filter = "", string nilai = "")
        {
            string perintah = "select kh.username,o.nama,k.nama,kh.thawal,kh.thakhir,kh.deskripsi from kisahhidup kh " +
                "inner join organisasi o on kh.organisasi_id = o.id inner join kota k on o.kota_id = k.id";
            if (filter != "")
                perintah += " where kh." + filter + " like'%" + nilai + "%';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<KisahHidup> ListData = new List<KisahHidup>();
            while (hasil.Read() == true)
            {
                KisahHidup tampung = new KisahHidup();
                tampung.Organisasi.Nama = hasil.GetValue(1).ToString();
                tampung.Organisasi.Kota.Nama = hasil.GetValue(2).ToString();
                tampung.Thawal = hasil.GetValue(3).ToString();
                tampung.Thakhir = hasil.GetValue(4).ToString();
                tampung.Deskripsi = hasil.GetValue(5).ToString();
                ListData.Add(tampung);
            }
            return ListData;
        }

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
        #endregion

        #region Method Teman
        public bool TambahTeman(User User2)
        {
            Teman t = new Teman();
            t.User2 = User2;
            ListTeman.Add(t);
            bool cek = InsertTeman(User2.Username);
            return cek;
        }

        public static List<Teman> BacaDataTeman(string filter = "", string nilai = "", User userLogin = null)
        {
            string perintah = "SELECT username2, tglBerteman " +
                "FROM teman WHERE username1 = '" + userLogin.Username + "' and tglberteman is not null" +
                " UNION SELECT username1, tglBerteman FROM teman WHERE username2 = '" + userLogin.Username + "' and tglberteman is not null";

            Koneksi.JalankanPerintahSelect(perintah);
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Teman> listTeman = new List<Teman>();

            while (hasil.Read() == true)
            {
                Teman t = new Teman();
                t.User2.Username = hasil.GetValue(0).ToString();
                t.TglBerteman = DateTime.Parse(hasil.GetValue(1).ToString());
                listTeman.Add(t);
            }

            return listTeman;
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
            string perintah = "select distinct u.* from user u inner join kisahhidup k on u.username = k.username " +
                "inner join organisasi o on k.Organisasi_id = o.id inner join kota ko on u.kota_id = ko.id" +
                " where u.username != '" + userLogin.Username +
                "' and (o.Nama in (select o.nama from organisasi o inner join kisahhidup k on o.id = k.organisasi_id " +
                "where k.username = '" + userLogin.Username + "'))";
                //"and (u.username in (select u.username from user u " +
                //"inner join teman t on u.username = t.username1 where t.username1 = '"+userLogin.Username+"'))";

            if (filter == "username")
            {
                perintah +=  "and u." + filter + " like'%" + nilai + "%';";
            }
            else if (filter == "ko.nama")
            {
                perintah += "and " + filter + " like'%" + nilai + "%';";
            }
            else if (filter == "o.nama")
            {
                perintah += "and " + filter + " like'%" + nilai + "%';";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<User> listPengguna = new List<User>();


            while (hasil.Read() == true)
            {
                User user = new User();
                user.Username = hasil.GetValue(0).ToString();
                user.Password = "********";
                user.TglLahir = DateTime.Parse(hasil.GetValue(2).ToString());
                user.NoKtp = hasil.GetValue(3).ToString();
                //user.Foto = hasil.GetValue(4).ToString();
                user.Kota = Kota.BacaData("id", hasil.GetValue(5).ToString())[0];
                // tambahkan ke list
                listPengguna.Add(user);
            }
            return listPengguna;         
        }
        

        public static List<Teman> CariTeman(User userLogin)
        {
            string perintah = "select * from teman where (username1 = '" + userLogin.Username  + "' or username2 = '"+ userLogin.Username + "')  and tglBerteman is not null;";
            Koneksi.JalankanPerintahSelect(perintah);

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Teman> listPermintaan = new List<Teman>();

           

            while (hasil.Read() == true)
            {
                Teman t = new Teman();
                if (hasil.GetValue(0).ToString() == userLogin.Username)
                {
                    t.User2 = User.BacaData("username", hasil.GetValue(1).ToString())[0];
                }
                else
                {
                    t.User2 = User.BacaData("username", hasil.GetValue(0).ToString())[0];
                }
                t.TglBerteman = DateTime.Parse(hasil.GetValue(2).ToString()) ;
                listPermintaan.Add(t);
            }
            return listPermintaan;
        }
        #endregion

        public override string ToString()
        {
            return Username;
        }

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
