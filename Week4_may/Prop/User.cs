using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop
{
    class User
    {
        private int nr;
        private string email;
        private string fname;
        private string lname;
        private decimal money;
        private bool over;
        private bool inevent;
        private bool incamping;
        private string rfid;
        public int user_nr { get { return this.nr; } set { this.nr = value; } }

        public User(int nr, string email, string fname, string lname, decimal money, bool over, bool inevent, bool incamping, string rfid)
        {
            this.nr = nr;
            this.email = email;
            this.fname = fname;
            this.lname = lname;
            this.money = money;
            this.over = over;
            this.inevent = inevent;
            this.incamping = incamping;
            this.rfid = rfid;
        }


        public string FullName()
        {
            return this.fname + " " + this.lname;
        }
        public string RFID()
        {
            return this.rfid;
        }
        public decimal Money()
        {
            return this.money;
        }

        public String getInfo()
        {
            return this.nr + " - " + this.email + " - " + this.fname + " - " + this.lname 
                + " - " + this.money.ToString() + " - " + this.inevent.ToString() 
                + " - " + this.incamping.ToString() + " - " + this.rfid;
        }
    }
}
