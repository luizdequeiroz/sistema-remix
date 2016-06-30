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
    public partial class DesktopController : Controller
    {
        public ActionResult Entrar(long id)
        {
            return PartialView("Entrar", id);
        }

        public ActionResult Ver(long id)
        {
            var mesa = new MesaDao().Selecionar(id);
            return PartialView("Ver", mesa);
        }

        [HttpPost]
        public ActionResult CadastrarMesa(MesaCriar m)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    m.Mesa.Mestre.UsuarioId = ((Usuario)Session["usuario"]).Id;
                    new MesaDao().Inserir(m.Mesa);
                    return RedirectToAction("Mesas");
                }
                catch (Exception ex)
                {
                    ViewBag.MsgCadastro = "Erro ao tentar cadastrar. Mas a culpa não é sua! Erro: " + ex.Message;
                    return View();
                }
            }

            //ViewBag.MsgCadastro = "Preencha os campos corretamente e não deixe os obrigatórios em branco.";
            return View();
        }

        public ActionResult MesaUnica(string nome)
        {
            var nomes = new List<string>();
            var todas = new MesaDao().Listar();
            foreach (var m in todas)
                nomes.Add(m.Nome);

            return Json(nomes.All(n => n.ToLower() != nome.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}
