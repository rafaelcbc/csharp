using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Blog de Notícias - Rafael Cardoso.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em contato conosco.";

            return View();
        }
    }
}