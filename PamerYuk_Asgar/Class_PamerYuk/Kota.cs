using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    internal class Kota
    {
        private string nama;
        private int id;

        public Kota()
        {
            this.Nama = "";
            this.Id = 0;
        }

        public string Nama { get => nama; set => nama = value; }
        public int Id { get => id; set => id = value; }
    }
}
