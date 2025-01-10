using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class Tag
    {
        #region Data Member
        private User user;
        #endregion

        #region Constructor
        public Tag()
        {
            this.User = new User();
        }
        #endregion

        #region Properties
        public User User { get => user; set => user = value; }
        #endregion

        #region Method 
        #endregion
    }
}
