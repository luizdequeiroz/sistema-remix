using RPG_Remix.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPG_Remix.Controllers
{
    public class UtilsController : Controller
    {
        public ActionResult Select_ListMesas()
        {
            var mesas = new MesaDao().Listar();
            return PartialView(mesas);
        }

        public ActionResult Select_ListMestres()
        {
            var mestres = new UsuarioDao().Listar();
            return PartialView(mestres);
        }

        [NonAction]
        public static string RenderAlert(string titulo, string mensagem, string tipo)
        {
            return "showAlert('" + titulo + "','" + mensagem + "','" + tipo + "');";
        }
    }
}
