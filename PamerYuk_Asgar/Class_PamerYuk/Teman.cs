using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class Teman
    {
        #region Data Member
        private User user2;
        private DateTime tglBerteman;


        #endregion

        #region Constructor
        public Teman( User user2, DateTime tglBerteman)
        {
            this.User2 = user2;
            this.TglBerteman = tglBerteman;
        }
        public Teman()
        {
            this.User2 = new User();
            this.TglBerteman = DateTime.Now;
        }

        #endregion

        #region Properties
        public User User2 { get => user2; set => user2 = value; }
        public DateTime TglBerteman { get => tglBerteman; set => tglBerteman = value; }
        #endregion

        #region Method 
        #endregion
    }
}
