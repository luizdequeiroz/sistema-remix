using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPG_Remix.Controllers
{
    public class FichasController : Controller
    {
        //
        // GET: /Fichas/

        public ActionResult Fichas()
        {
            return PartialView();
        }

        public ActionResult NovaFicha()
        {
            return PartialView();
        }
    }
}
