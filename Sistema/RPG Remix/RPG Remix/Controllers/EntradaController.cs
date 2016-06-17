﻿using RPG_Remix.Models;
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
        public ActionResult Entrar(UsuarioFacade usuario)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario.Email))
                {
                    ModelState.AddModelError("", "Informe o e-mail do seu cadastro!");
                    return View();
                }
                if (string.IsNullOrEmpty(usuario.Senha))
                {
                    ModelState.AddModelError("", "Informe a senha!");
                    return View();
                }
                var u = new UsuarioDao().SelecionarPorEmail(usuario.Email);
                if (u == null)
                {
                    ModelState.AddModelError("", "E-mail incorreto ou o usuário não existe!");
                    return View();
                }
                if (usuario.Senha != u.Senha)
                {
                    ModelState.AddModelError("", "Senha incorreta!");
                    return View();
                }

                Session["usuario"] = u;
                return RedirectToAction("Desktop", "Desktop");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Erro no sistema, a culpa não é sua. Erro: " + ex.Message);
                return View();
            }
        }

        public ActionResult Cadastrar(UsuarioFacade usuario)
        {
            /*if (ModelState.IsValid())
            {
                new UsuarioDao().Inserir(usuario.Usuario);
            }*/
            return View();
        }
    }
}
