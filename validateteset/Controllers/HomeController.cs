using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace validateteset.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ValidateName(string name)
        {
            if (!String.Equals(name, "Ray"))
            {
                return Json(false);
            }
            else
            {
                return Json(true);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AboutInfo(string name, string nickname)
        {
            ViewBag.Name = name;
            ViewBag.NickName = nickname;

            return PartialView("_AboutInfo");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}