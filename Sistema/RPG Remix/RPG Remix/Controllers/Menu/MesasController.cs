using RPG_Remix.Models;
using RPG_Remix.Models.DAO;
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
        // GET: /Mesa/

        public ActionResult Mesas()
        {
            var usuario = (Usuario)Session["usuario"];
            var mesas = new MesaDao().ListarPorUsuario(usuario);
            return PartialView(mesas);
        }
    }
}
