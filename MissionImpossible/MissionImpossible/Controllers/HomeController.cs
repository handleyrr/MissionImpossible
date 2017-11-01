using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionImpossible.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)// checks to see if user is logged in
            {
                if (User.IsInRole("Admin"))
                {
                    return RedirectToAction("Admin", "Home"); // if user is an admin, take them to the admin page
                }
                if (User.IsInRole("User")) // if user is standard user, go to the user page
                {
                    return RedirectToAction("UserAccount", "Home");
                }
            }
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult UserAccount()
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

            return View();
        }
    }
}