using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public abstract class time
    {
       protected string Fname;
        protected string Lname;
        protected string email;
        protected int phon;

       public string _Fname
        {
            set { Fname = value; }
            get { return Fname; }
        }

        public string _Lname
        {
            set { Lname = value; }
            get { return Lname; }
        }

        public string _email
        {
            set { email = value; }
            get { return email; }
        }
        public int _phon
        {
            set { phon = value; }
            get { return phon; }
        }
        public abstract bool check();

        public abstract string print();


        }

}
