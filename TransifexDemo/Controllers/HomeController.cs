using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace TransifexDemo.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
        }

        public ActionResult Index()
        {
            var resourceManager = new ResourceManager(typeof(Properties.Resources));
            var homePageString = resourceManager.GetString("HomePagex", Thread.CurrentThread.CurrentCulture);

            ViewBag.Title = homePageString;
            return View();
        }
    }
}
