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
            Session["usuario"] = new Usuario { Nome = "Luiz de Queiroz", Email = "luizdequeiroz@outlook.com.br", Descricao = "Descrição de Luiz de Queiroz", DataNascimento = "28/11/1992" };
            if (Session["usuario"] == null)
                return RedirectToAction("Entrar", "Entrada");
            else return View((Usuario)Session["usuario"]);
        }

        [HttpPost]
        public ActionResult Desktop(string pagina)
        {
            return RedirectToAction(pagina);
        }

        public ActionResult Sair()
        {
            Session.RemoveAll();
            return RedirectToAction("Entrar", "Entrada");
        }
    }
}
