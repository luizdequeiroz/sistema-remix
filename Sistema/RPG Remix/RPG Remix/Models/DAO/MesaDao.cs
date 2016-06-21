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
                    rrc.MesaSet.Add(mesa);
                    rrc.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("[MesaDao.Inserir]", ex);
                }
            }
        }

        public List<Mesa> ListarPorUsuario(Usuario u)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    var jogadores = rrc.JogadorSet.Where(j => j.Usuario == u);
                    var mestres = rrc.MestreSet.Where(m => m.Usuario == u);
                    if (jogadores == null)
                        foreach (var j in jogadores.ToList())
                            mesas.Add(j.Mesa);
                    if (mestres == null)
                        foreach (var m in mestres.ToList())
                            mesas.Add(m.Mesa);

                    return mesas;
                }
                catch (Exception ex)
                {
                    throw new Exception("[MesaDao.Listar]", ex);
                }
            }
        }
    }
}