using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class Like
    {
        private User user;

        public Like(User user)
        {
            this.User = user;
        }

        public Like()
        {
            this.User = user;
        }

        public User User { get => user; set => user = value; }
    }
}
