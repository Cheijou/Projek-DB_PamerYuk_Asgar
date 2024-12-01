using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #endregion
        #region Constructor
        public User()
        {
           this.Username = "";
            this.Password = "";
            this.TglLahir = DateTime.Now;
            this.NoKtp = "";
            this.Foto = "";
            this.Kota = new Kota();
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
        #endregion

        #region Method 
        #endregion


    }
}
