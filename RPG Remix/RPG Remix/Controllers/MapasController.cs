using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPG_Remix.Controllers
{
    public class MapasController : Controller
    {
        //
        // GET: /Mapas/

        public ActionResult Mapas()
        {
            return PartialView();
        }

        public ActionResult ZoldaMaps()
        {
            return PartialView();
        }

    }
}
