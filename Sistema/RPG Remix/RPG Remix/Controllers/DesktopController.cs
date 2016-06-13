using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPG_Remix.Controllers
{
    public class DesktopController : Controller
    {
        //
        // GET: /Desktop/

        public ActionResult Desktop()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Desktop(string pagina)
        {
            return PartialView(pagina);
        }

        public ActionResult Mesas()
        {
            return View();
        }

        public ActionResult Jogadores()
        {
            return View();
        }

        public ActionResult Fichas()
        {
            return View();
        }

        public ActionResult Contatos()
        {
            return View();
        }

        public ActionResult Ajustes()
        {
            return View();
        }
    }
}
