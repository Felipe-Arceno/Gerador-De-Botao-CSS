using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gerador_CSS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<Models.ButtonModel> list_buttons = Class.Button.GetAllButtons();

            return View(list_buttons);
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