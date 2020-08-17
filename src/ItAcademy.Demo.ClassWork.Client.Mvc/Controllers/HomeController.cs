﻿using System.Web.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
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

            return View();
        }
    }
}