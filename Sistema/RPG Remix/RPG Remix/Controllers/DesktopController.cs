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

        public ActionResult Sair()
        {
            return RedirectToAction("Entrar", "Entrada");
        }
    }
}
