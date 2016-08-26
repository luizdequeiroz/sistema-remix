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
    public partial class FichasController : Controller
    {
        //
        // GET: /Fichas/

        public ActionResult Fichas()
        {
            var fichas = new FichaDao().ListarPorUsuarioId(((Usuario)Session["usuario"]).Id);
            fichas.AddRange(new FichaDao().ListarDeConhecidos(((Usuario)Session["usuario"]).Id));
            return PartialView(fichas);
        }

        public ActionResult NovaFicha(string nome)
        {
            if (!string.IsNullOrEmpty(nome)) Session["nome"] = nome;
            return PartialView();
        }

        [HttpPost]
        public ActionResult NovaFicha(int Nivel, FichaCriar ficha, 
            ICollection<Peculiaridade> capacidades,
            ICollection<Peculiaridade> pericias,
            ICollection<Peculiaridade> desvantagens,
            Mesa mesa)
        {
            return PartialView();
        }
    }
}
