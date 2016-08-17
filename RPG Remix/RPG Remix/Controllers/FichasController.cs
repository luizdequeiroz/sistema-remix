using RPG_Remix.Models;
using RPG_Remix.Models.Fachada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPG_Remix.Controllers
{
    public partial class FichasController : Controller
    {
        //
        // GET: /Fichas/

        public ActionResult Fichas()
        {
            return PartialView();
        }

        public ActionResult NovaFicha(string nome)
        {
            if (!string.IsNullOrEmpty(nome)) Session["nome"] = nome;
            return PartialView();
        }

        [HttpPost]
        public ActionResult NovaFicha(FichaCriar ficha, 
            ICollection<Peculiaridade> capacidades,
            ICollection<Peculiaridade> pericias,
            ICollection<Peculiaridade> desvantagens,
            ICollection<Propriedade> propriedades, 
            ICollection<Riqueza> riquezas, 
            ICollection<ItemArma> itensArmas, 
            ICollection<Vestimenta> vestimentas)
        {
            return PartialView();
        }
    }
}
