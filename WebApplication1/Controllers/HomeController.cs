using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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

        public ActionResult Categoría()
        {
            return View();
        }

        public ActionResult Ofertas()
        {
            return View();
        }

        public ActionResult Historial()
        {
            return View();
        }

        public ActionResult TiendasOficiales()
        {
            return View();
        }

        public ActionResult MercadoPlay()
        {
            return View();
        }

        public ActionResult Vender()
        {
            return View();
        }

        public ActionResult Ayuda()
        {
            return View();
        }
    }
}