using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class Chat
    {
        #region Data Member 
        private int id;
        private User saya;
        private User temanku;
        private string isi;
        private DateTime tanggal;
        private bool notif;
        #endregion

        #region Constructor 
        public Chat()
        {
            this.Id = 0;
            this.Saya = new User();
            this.Temanku = new User();
            this.Isi = "";
            this.Tanggal = DateTime.Now;
            
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Isi { get => isi; set => isi = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public User Saya { get => saya; set => saya = value; }
        public User Temanku { get => temanku; set => temanku = value; }
        public bool Notif { get => notif; set => notif = value; }
        #endregion

        #region Method 
        public static void TambahChat(Chat objekTambah)
        {
            string perintah = "INSERT INTO Chat (saya, temanku, isi, tanggal) VALUES ('" + objekTambah.Saya.Username + "', '" + objekTambah.Temanku.Username + "', '" + objekTambah.Isi+ "', '" + objekTambah.Tanggal.ToString("yyyy-MM-dd HH:mm:ss") + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Chat> BacaData(string saya, string teman)
        {
            string perintah = "select * from Chat";
           
                perintah += " where (saya = '" + saya + "' and temanku = '" + teman  + "') or (saya = '" + teman + "' and temanku = '" + saya  + "') order by tanggal asc" ;

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Chat> listChat = new List<Chat>();
            while (hasil.Read() == true)
            {
                Chat tampung = new Chat();
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Saya = User.BacaData("username", hasil.GetValue(1).ToString())[0];
                tampung.Temanku = User.BacaData("username", hasil.GetValue(2).ToString())[0];
                tampung.Isi= hasil.GetValue(3).ToString();
                tampung.Tanggal= DateTime.Parse(hasil.GetValue(4).ToString());
                listChat.Add(tampung);
            }
            return listChat;
        }
        public static List<Chat> BacaDataChatTerbaru(User user)
        {
            string perintah = "SELECT DISTINCT c.id, u.username, c.temanku, c.isi, c.tanggal FROM user u INNER JOIN chat c ON u.username = c.saya " +
                "WHERE (c.temanku = '"+user.Username+"') AND c.tanggal = (SELECT MAX(c2.tanggal) FROM chat c2 WHERE c2.saya = c.saya AND c2.temanku = c.temanku" +
                " AND DATEDIFF(now(), c2.tanggal) < 1) ORDER BY c.tanggal DESC;";
            Koneksi.JalankanPerintahSelect(perintah);
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Chat> listChat = new List<Chat>();
            while (hasil.Read() == true)
            {
                Chat tampung = new Chat();
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Temanku.Username = hasil.GetValue(1).ToString();
                tampung.Saya.Username = hasil.GetValue(2).ToString();
                tampung.Isi = hasil.GetValue(3).ToString(); 
                tampung.Tanggal = DateTime.Parse(hasil.GetValue(4).ToString());
                listChat.Add(tampung);
            }
            return listChat;
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

        public static void UpdateNotif(User userLogin)
        {
            string perintah = "UPDATE Chat SET dibaca = '" + 1 + "' where saya = '" + userLogin.Username + "' ;";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }


        public static int TotalChat()
        {
            string perintah = "select count(dibaca) from Chat where dibaca = 0";
            Koneksi.JalankanPerintahNonQuery(perintah);
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            int total = 0;
            while (hasil.Read() == true)
            {
                total = int.Parse(hasil.GetValue(0).ToString());
            }
            return total;
        }
        #endregion
    }
}
