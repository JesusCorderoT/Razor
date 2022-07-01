using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class HolaMundoController : Controller
    {
        // GET: HolaMundo
        public ActionResult Index()
        {
            ViewBag.bienv = "Bienvenido";

            ViewBag.day = "Hoy es " + DateTime.Now;

            return View();
        }
    }
}