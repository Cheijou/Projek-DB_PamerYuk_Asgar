using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class Organisasi
    {
        #region Data Member
        private int id;
        private string nama;
        private Kota kota;
        #endregion

        #region Constructor
        public Organisasi()
        {
            this.Id = 0;
            this.Nama = "";
            this.Kota = new Kota();
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public Kota Kota { get => kota; set => kota = value; }
        #endregion

        #region Method 
        public static List<Organisasi> BacaData(string filter = "", string nilai = "")
        {
            string perintah = "select o.*, k.nama from organisasi o inner join kota k on o.Kota_id = k.id";
            if (filter != "")
                perintah += " where " + filter + " like'%" + nilai + "%';";


            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Organisasi> ListData = new List<Organisasi>();
            while (hasil.Read() == true)
            {
                Organisasi tampung = new Organisasi();
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Nama = hasil.GetValue(1).ToString();
                Kota kota = new Kota();
                kota.Id = int.Parse(hasil.GetValue(2).ToString());
                kota.Nama = hasil.GetValue(3).ToString();
                tampung.Kota = kota;
                ListData.Add(tampung);
            }
            return ListData;
        }

        public static void TambahData(Organisasi objekTambah)
        {
            string perintah = "INSERT INTO organisasi (nama, Kota_id) VALUES ('" + objekTambah.Nama + "', '"  + objekTambah.Kota.Id + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void UpdateData(Organisasi objekUbah)
        {
            string perintah = "UPDATE Organisasi SET nama ='" + objekUbah.nama + "' ,Kota_id='" + objekUbah.Kota.Id + "' WHERE id='" + objekUbah.Id + "';";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        #endregion
    }
}
