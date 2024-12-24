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

       

       
        #endregion

        #region Constructor 
        public Chat(int id, string chat, DateTime tanggal)
        {
            this.Id = id;
            this.Isi = chat;
            this.Tanggal = tanggal;
        }
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
        //public static List<Chat> BacaData(Chat objek)
        //{
        //    string perintah = "select * from Chat where saya = '" + objek.Saya.Username + "' and temanku = '" +objek.Temanku.Username + "' ;";
        //    Koneksi.JalankanPerintahSelect(perintah);

        //    MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
        //    List<Chat> listChat = new List<Chat>();
        //    while (hasil.Read() == true)
        //    {
        //        Chat tampung = new Chat();
        //        tampung.Id = int.Parse(hasil.GetValue(0).ToString());
        //        tampung.Saya = User.BacaData("username", hasil.GetValue(1).ToString())[0];
        //        tampung.Temanku = User.BacaData("username", hasil.GetValue(2).ToString())[0];
        //        tampung.Isi = hasil.GetValue(3).ToString();
        //        tampung.Tanggal = DateTime.Parse(hasil.GetValue(4).ToString());
        //        listChat.Add(tampung);
        //    }
        //    return listChat;
        //}

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

        #endregion
    }
}
