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
    public partial class EntradaController : Controller
    {
        //
        // GET: /Entrada/

        public ActionResult Entrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Entrar(UsuarioEntrar u)
        {
            return RedirectToAction("Desktop", "Desktop");
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(UsuarioCadastrar u)
        {
            try
            {
                new UsuarioDao().Inserir(u.Usuario);
                ViewBag.MsgCadastro = "Cadastrado com Sucesso!";
                return View("Entrar");
            }
            catch (Exception ex)
            {
                ViewBag.MsgCadastro = "Erro ao tentar cadastrar. Mas a culpa não é sua! Erro: " + ex.Message;
                return View();
            }
        }
    }
}
