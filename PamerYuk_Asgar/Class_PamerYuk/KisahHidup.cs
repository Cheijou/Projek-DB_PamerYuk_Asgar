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
        private User user;
        private string thawal;
        private string thakhir;
        private string deskripsi;

        #endregion

        #region Constructor
        public KisahHidup(Organisasi organisasi, User user, string thawal, string thakhir, string deskripsi)
        {
            this.Organisasi = organisasi;
            this.User = user;
            this.Thawal = thawal;
            this.Thakhir = thakhir;
            this.Deskripsi = deskripsi;
        }

        public KisahHidup()
        {
            this.Organisasi = new Organisasi();
            this.User = new User();
            this.Thawal = "";
            this.Thakhir = "";
            this.Deskripsi = "";
        }
        #endregion

        #region Properties
        public Organisasi Organisasi { get => organisasi; set => organisasi = value; }
        public User User { get => user; set => user = value; }
        public string Thawal { get => thawal; set => thawal = value; }
        public string Thakhir { get => thakhir; set => thakhir = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        #endregion

        #region Method 
        #endregion
    }
}
