using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class KisahHidup
    {
        #region Data Member
        private Organisasi organisasi;
        private string thawal;
        private string thakhir;
        private string deskripsi;

        #endregion

        #region Constructor
       

        public KisahHidup()
        {
            this.Organisasi = new Organisasi();
            this.Thawal = "";
            this.Thakhir = "";
            this.Deskripsi = "";
        }
        #endregion

        #region Properties
        public Organisasi Organisasi { get => organisasi; set => organisasi = value; }
        public string Thawal { get => thawal; set => thawal = value; }
        public string Thakhir { get => thakhir; set => thakhir = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        #endregion

        #region Method 
        #endregion
    }
}
