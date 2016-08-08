using RPG_Remix.Models;
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
            if (Session["usuario"] == null)
                return RedirectToAction("Entrar", "Entrada");
            else return View((Usuario)Session["usuario"]);
            //return View();
        }

        public ActionResult Sair()
        {
            Session.RemoveAll();
            return RedirectToAction("Entrar", "Entrada");
        }
    }
}
