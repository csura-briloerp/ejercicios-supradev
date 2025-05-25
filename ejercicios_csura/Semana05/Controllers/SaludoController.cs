using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semana05.Controllers
{
    public class SaludoController : Controller
    {
        // GET: Saludo
        public ActionResult Index()
        {
            ViewBag.MensajeDelControlador = "Este mensaje viene del controlador.";
            return View();
        }
    }
}