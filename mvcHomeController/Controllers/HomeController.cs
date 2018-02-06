using mvcHomeController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcHomeController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NumInfo(double myDouble)
        {

            return View(new NumberIncome { myDouble = myDouble });
        }

        public ActionResult StringInfo(string mystring)
        {
            
            return View(new StringIncome { myString=mystring});
        }
    }
}