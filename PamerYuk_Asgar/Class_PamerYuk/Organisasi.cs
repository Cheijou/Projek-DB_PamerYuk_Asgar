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
        public Organisasi(int id, string nama, Kota kota)
        {
            this.Id = id;
            this.Nama = nama;
            this.Kota = kota;
        }

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
        #endregion
    }
}
