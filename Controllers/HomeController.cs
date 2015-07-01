using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Flot()
        {
            ViewBag.Message = "Flot Chart Page";
            return View();
        }

        public ActionResult Morris()
        {
            ViewBag.Message = "Morris.js Chart Page";
            return View();
        }

        public ActionResult Tables()
        {
            ViewBag.Message = "Tables Page";
            return View();
        }

        public ActionResult Forms()
        {
            ViewBag.Message = "Forms Page";
            return View();
        }

        public ActionResult Panels()
        {
            ViewBag.Message = "Panels Page";
            return View();
        }

        public ActionResult Buttons()
        {
            ViewBag.Message = "Buttons Page";
            return View();
        }

        public ActionResult Notifications()
        {
            ViewBag.Message = "Notifications Page";
            return View();
        }

        public ActionResult Typography()
        {
            ViewBag.Message = "Typography Page";
            return View();
        }

        public ActionResult Icons()
        {
            ViewBag.Message = "Icons Page";
            return View();
        }

        public ActionResult Grid()
        {
            ViewBag.Message = "Grid Page";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
