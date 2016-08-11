using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPG_Remix.Models.DAO
{
    public class MesaDao
    {
        List<Mesa> mesas = new List<Mesa>();

        public void Inserir(Mesa mesa)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    mesa.DataCriacao = DateTime.Now.ToString();
                    rrc.MesaSet.Add(mesa);
                    rrc.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("[MesaDao.Inserir] -> " + ex.Message);
                }
            }
        }

        public List<Mesa> ListarPorUsuario(Usuario u)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    var mestres = rrc.MestreSet.Where(m => m.UsuarioId == u.Id).ToList();
                    var jogadores = new JogadorDao().ListarDoUsuario(u);

                    if (mestres.Count > 0)
                        foreach (var m in mestres)
                            mesas.Add(m.Mesa);
                    if (jogadores.Count > 0)
                        foreach (var j in jogadores)
                            mesas.Add(j.Mesa);

                    return mesas;
                }
                catch (Exception ex)
                {
                    throw new Exception("[MesaDao.Listar] -> " + ex.Message);
                }
            }
        }

        public List<Mesa> Listar()
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    return rrc.MesaSet.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("[MesaDao.Listar] -> " + ex.Message);
                }
            }
        }

        public Mesa Selecionar(long id)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    return rrc.MesaSet.Where(m => m.Id == id).SingleOrDefault();
                }
                catch (Exception ex)
                {
                    throw new Exception("[MesaDao.Selecionar] -> " + ex.Message);
                }
            }
        }
    }
}