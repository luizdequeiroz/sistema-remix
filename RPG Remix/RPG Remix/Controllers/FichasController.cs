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
        public FichaDao fichaDao = new FichaDao();
        public MesaDao mesaDao = new MesaDao();
        public PeculiaridadeDao peculiaridadeDao = new PeculiaridadeDao();
        public int usuarioId;

        public ActionResult Fichas()
        {
            usuarioId = ((Usuario)Session["usuario"]).Id;
            var fichas = fichaDao.ListarPorUsuarioId(usuarioId);
            fichas.AddRange(fichaDao.ListarDeConhecidos(usuarioId));
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
            try
            {
                if (ModelState.IsValid)
                {
                    var ptsTests = Nivel * 9;
                    var sumT = ficha.Adre + ficha.Ataq + ficha.Defe + ficha.Dest + ficha.Forc + ficha.Inte + ficha.Resi + ficha.Sabe + ficha.Velo;
                    if (sumT != ptsTests)
                    {
                        if (sumT > ptsTests) Session["alert"] = UtilsController.RenderAlert("Ops!", "Você não pode ultrapassar o número de pontos para testes atribuído pelo nível escolhido!", "warning");
                        else Session["alert"] = UtilsController.RenderAlert("Ops!", "Você deve distribuir todos os pontos para testes atribuídos pelo nível escolhido!", "warning");
                        return PartialView();
                    }

                    var ptsPecul = Nivel * 10;
                    var sumP = 0;

                    if (capacidades != null)
                        foreach (var c in capacidades) sumP += c.Teste;
                    if (pericias != null)
                        foreach (var p in pericias) sumP += p.Teste;
                    if (sumP > ptsPecul)
                    {
                        Session["alert"] = UtilsController.RenderAlert("Ops!", "Você não pode ultrapassar o número de pontos para peculiaridades atribuídos pelo nível escolhido!", "warning");
                        return PartialView();
                    }

                    int mesaId;
                    if (mesaDao.Selecionar(mesa.Id) == null)
                        mesaId = mesaDao.Inserir(mesa);
                    else mesaId = mesa.Id;

                    ficha.PtsPericias = ptsPecul - sumP;

                    usuarioId = ((Usuario)Session["usuario"]).Id;
                    ficha.Ficha.UsuarioId = usuarioId;
                    ficha.Ficha.MesaId = mesaId;

                    var fichaId = fichaDao.Inserir(ficha.Ficha);


                    if (capacidades.Count > 0)
                    {
                        var txt = "";
                        foreach (var c in capacidades)
                        {
                            if (c.Nome != "") c.FichaId = fichaId;
                            txt += c.Nome;
                        }
                        if (txt != "") peculiaridadeDao.InserirVarios(capacidades);
                    }

                    if (pericias.Count > 0)
                    {
                        var txt = "";
                        foreach (var p in pericias)
                        {
                            if (p.Nome != "") p.FichaId = fichaId;
                            txt += p.Nome;
                        }
                        if (txt != "") peculiaridadeDao.InserirVarios(pericias);
                    }

                    if (desvantagens.Count > 0)
                    {
                        var txt = "";
                        foreach (var d in desvantagens)
                        {
                            if (d.Nome != "") d.FichaId = fichaId;
                            txt += d.Nome;
                        }
                        if (txt != "") peculiaridadeDao.InserirVarios(desvantagens);
                    }

                    Session["alert"] = UtilsController.RenderAlert("Sucesso!", "A Ficha " + ficha.Nome + " foi criada com sucesso!", "success");
                    return RedirectToAction("Fichas");
                }

                Session["alert"] = UtilsController.RenderAlert("Ops!", "Alguns campos estão necessitando serem devidamente preenchidos!", "warning");
                return PartialView();
            }
            catch (Exception ex)
            {
                Session["alert"] = UtilsController.RenderAlert("Erro!", "Erro no servidor: " + ex.ToString(), "danger");
                return PartialView();
            }
        }
    }
}
