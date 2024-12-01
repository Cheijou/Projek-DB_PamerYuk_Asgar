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
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Caption { get => caption; set => caption = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Video { get => video; set => video = value; }
        public DateTime TglUpload { get => tglUpload; set => tglUpload = value; }
        public User User { get => user; set => user = value; }
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
                user.Foto = hasil.GetValue(10).ToString();
                tampung.User = user;
                ListData.Add(tampung);
            }
            return ListData;

        }
        #endregion
    }
}
