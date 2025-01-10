using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class Like
    {
        #region DataMember
        private User user;
        #endregion


        #region Constructor
        public Like()
        {
            this.User = user;
        }
        #endregion

        #region Properties
        public User User { get => user; set => user = value; }
        #endregion
    }
}
