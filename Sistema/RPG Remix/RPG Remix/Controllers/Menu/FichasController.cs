using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPG_Remix.Controllers
{
    public partial class DesktopController : Controller
    {
        //
        // GET: /Fichas/

        public ActionResult Fichas()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Fichas(string pagina, string prenome = "")
        {
            ViewBag.Nome = prenome;
            return RedirectToAction(pagina);
        }

        public ActionResult NovaFicha()
        {
            return PartialView();
        }
    }
}
