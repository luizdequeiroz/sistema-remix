using RPG_Remix.Models.Fachada;
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

        public ActionResult Sessao(UsuarioEntrar usuario)
        {
            return View();
        }

    }
}
