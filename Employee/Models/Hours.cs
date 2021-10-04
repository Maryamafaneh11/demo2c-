using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Employee.Models;
namespace Employee.Models
{
    public class Hours: time
    {
        int hours;
        int hoursprice;

        public int _hours
        {
            set { hours = value; }
            get { return hours; }
        }

        public int _hoursprice
        {
            set { hoursprice = value; }
            get { return hoursprice; }
        }

        public override bool check() { 
            if(Fname!=""&& Lname!="" && email!="" && phon!=0 && hours!=0 && hoursprice != 0)
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

            return ("Hello" + Fname +Lname+ "," + "This is" + hours + "," + "your salary is:450");
        }
    }
}
