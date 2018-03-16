using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            bool a = false;
            if(a)
            {
                string s = "";
            }

            int i, j = 0;
            for (i = 0; i < 5; j++)
            {

            }
            return View();
        }
    }

    public class abcd
    {

    }
}