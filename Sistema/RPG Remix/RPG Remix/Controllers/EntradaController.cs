using RPG_Remix.Models;
using RPG_Remix.Models.DAO;
using RPG_Remix.Models.Fachada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPG_Remix.Controllers
{
    public class EntradaController : Controller
    {
        //
        // GET: /Entrada/

        public ActionResult Entrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Entrar(UsuarioFacade.UsuarioEntrar usuario)
        {
            return View();
        }

        public ActionResult Cadastrar(UsuarioFacade.UsuarioCadastrar usuario)
        {
            return View();
        }
    }
}
