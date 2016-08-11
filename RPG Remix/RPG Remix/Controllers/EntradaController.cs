using RPG_Remix.Models;
using RPG_Remix.Models.DAO;
using RPG_Remix.Models.Fachada;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (Session["usuario"] != null)
                return RedirectToAction("Desktop", "Desktop");
            return View();
        }

        [HttpPost]
        public ActionResult Entrar(UsuarioEntrar u)
        {
            var usuario = new UsuarioDao().SelecionarPorEmail(u.Email);
            if (usuario != null)
                if (usuario.Senha != u.Senha)
                {
                    ViewBag.MsgEntrada = "Senha incorreta!";
                    return View();
                }
                else
                {
                    Session["usuario"] = usuario;
                    return RedirectToAction("Desktop", "Desktop");
                }
            ViewBag.MsgEntrada = "Não há cadastro com este e-mail!";
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(UsuarioCadastrar u)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (string.IsNullOrEmpty(u.Descricao))
                        u.Descricao = "Não me descrevi ainda!";

                    var usuario = new UsuarioDao().SelecionarPorEmail(u.Email);
                    if (usuario != null)
                    {
                        ModelState.AddModelError("Email", "Alguém já está usando este e-mail!");
                        return View();
                    }

                    var request = Request.Files[0];

                    var mime = request.ContentType;

                    if (request != null)
                        if (mime.Equals("image/jpg")
                            || mime.Equals("image/jpeg")
                            || mime.Equals("image/png")
                            || mime.Equals("image/gif"))
                            if (request.ContentLength > 0)
                            {
                                var uPath = Server.MapPath("~/Content/Fotos");
                                string caminho = Path.Combine(@uPath, Path.GetFileName(u.Email + ".png"));

                                request.SaveAs(caminho);
                            }

                    new UsuarioDao().Inserir(u.Usuario);
                    ViewBag.MsgEntrada = "Cadastrado com Sucesso!";
                    return View("Entrar");
                }
                catch (Exception ex)
                {
                    ViewBag.MsgCadastro = "Erro ao tentar cadastrar. Mas a culpa não é sua! Erro: " + ex.Message;
                    return View();
                }
            }

            ViewBag.MsgCadastro = "Preencha os campos corretamente e não deixe os obrigatórios em branco.";
            return View();
        }

        public ActionResult EmailUnico(string email)
        {
            var emails = new List<string>();
            var todos = new UsuarioDao().Listar();
            foreach (var u in todos)
                emails.Add(u.Email);

            return Json(emails.All(e => e.ToLower() != email.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}
