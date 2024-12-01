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
        private User user1;
        private User user2;
        private DateTime tglBerteman;


        #endregion

        #region Constructor
        public Teman(User user1, User user2, DateTime tglBerteman)
        {
            this.User1 = user1;
            this.User2 = user2;
            this.TglBerteman = tglBerteman;
        }

        #endregion

        #region Properties
        public User User1 { get => user1; set => user1 = value; }
        public User User2 { get => user2; set => user2 = value; }
        public DateTime TglBerteman { get => tglBerteman; set => tglBerteman = value; }
        #endregion

        #region Method 
        #endregion
    }
}
