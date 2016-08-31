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
            try
            {
                var usuario = new UsuarioDao().SelecionarPorEmail(u.Email);
                if (usuario != null)
                    if (usuario.Senha != u.Senha)
                    {
                        Session["alert"] = UtilsController.RenderAlert("Ops!", "Senha incorreta!", "warning");
                        return View();
                    }
                    else
                    {
                        Session["usuario"] = usuario;
                        return RedirectToAction("Desktop", "Desktop");
                    }
                Session["alert"] = UtilsController.RenderAlert("Vish!", "Não há cadastro com este e-mail!", "warning");
                return View();
            }
            catch (Exception ex)
            {
                Session["alert"] = UtilsController.RenderAlert("Erro!", "Erro no servidor, por favor tente novamente (agora ou mais tarde). Relatório: <br>" + ex.Message, "danger");
                return View();
            }
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
                    Session["alert"] = UtilsController.RenderAlert("Parabéns!", "Você foi cadastrado com sucesso, pelo e-mail " + u.Email + "!", "success");
                    return View("Entrar");
                }
                catch (Exception ex)
                {
                    Session["alert"] = UtilsController.RenderAlert("Erro!", "Erro ao tentar cadastrar. Mas a culpa não é sua! Erro: " + ex.Message, "danger");
                    return View();
                }
            }

            Session["alert"] = UtilsController.RenderAlert("Ops!", "Preencha os campos corretamente e não deixe os obrigatórios em branco.", "warning");
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
