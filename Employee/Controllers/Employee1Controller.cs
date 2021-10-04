using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Controllers
{
    public class Employee1Controller : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        
        public IActionResult Index1()
        {
            if(Request.Form["select"] == 1)
            {
               string fname= Request.Form["fname"];
                string lname = Request.Form["lname"];
                string email = Request.Form["email"];
                int phone = Convert.ToInt32(Request.Form["phone"]);
                int Hours_ = Convert.ToInt32(Request.Form["Hours"]);
                int texthoueprice = Convert.ToInt32(Request.Form["texthoueprice"]);
                Hours hor = new Hours();
                hor.check();
                var meeg = hor.print();
                ViewData["maseg"]=meeg;
                

            }
            else
            {
                string fname = Request.Form["fname"];
                string lname = Request.Form["lname"];
                string email = Request.Form["email"];
                int phone = Convert.ToInt32(Request.Form["phone"]);
                string Day_price = Request.Form["Day price"];
                string day = Request.Form["Days"];
                Daily dayy = new Daily();
                dayy.check();
              var meg=  dayy.print();
                ViewData["maseg"] = meg;


            }
            return View("Index");
        }
    }
}
