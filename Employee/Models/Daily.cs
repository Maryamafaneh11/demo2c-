using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Employee.Models;

namespace Employee.Models
{
    public  class Daily: time
    {
        string day;
        string dayprice;

        public string _day
        {
            set { day = value; }
            get { return day; }
        }
        public string _dayprice
        {
            set { dayprice = value; }
            get { return dayprice; }
        }
        public override bool check()
        {
            if (Fname != "" && Lname != "" && email != "" && phon != 0 && day != "" && dayprice != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string print()
        {

            return ("Hello" + Fname +Lname+ "," + "This is" + day + "," + "your salary is:450");
        }
    }
}
