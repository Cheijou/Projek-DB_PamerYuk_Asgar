using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    internal class User
    {
        private string username;
        private string password;
        private DateTime tglLahir;
        private string noKtp;
        private string foto;
        private Kota kotaId;

        public User()
        {
            this.Username = "";
            this.Password = "";
            this.TglLahir = DateTime.Now;
            this.NoKtp = "";
            this.Foto = "";
            this.KotaId = new Kota();
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string NoKtp { get => noKtp; set => noKtp = value; }
        public string Foto { get => foto; set => foto = value; }
        internal Kota KotaId { get => kotaId; set => kotaId = value; }
    }
}
