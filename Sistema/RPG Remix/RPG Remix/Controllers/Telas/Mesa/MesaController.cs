using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPG_Remix.Controllers
{
    public partial class DesktopController : Controller
    {
        public ActionResult Entrar(long id)
        {
            return PartialView("Entrar", id);
        }

        public ActionResult Ver(long id)
        {
            return PartialView("Ver", id);
        }
    }
}
