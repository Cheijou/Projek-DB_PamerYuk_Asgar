using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
                //user.Pwd = hasil.GetValue(2).ToString();
                user.TglLahir = DateTime.Parse(hasil.GetValue(3).ToString());
                user.Kota = Kota.BacaData("id", hasil.GetValue(5).ToString())[0];
                // tambahkan ke list
                listPengguna.Add(user);
            }
            return listPengguna;
        }
        #endregion
    }
}
