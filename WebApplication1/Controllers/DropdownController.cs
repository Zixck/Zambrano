using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DropdownController : Controller
    {
        public ActionResult Electrodomesticos()
        {
            return View();
        }

        public ActionResult RopayAccesorios()
        {
            return View();
        }

        public ActionResult HogaryMuebles()
        {
            return View();
        }

        public ActionResult Tecnologia()
        {
            return View();
        }

        public ActionResult Deporte()
        {
            return View();
        }
    }

}
