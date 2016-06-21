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
                    /* Erro aqui, rever. */
                    var mesasMt = rrc.MesaSet.Where(ms => ms.Mestre.Usuario.Id == u.Id);
                    var mesasJo = rrc.MesaSet.Where(ms => ms.Jogadores == rrc.JogadorSet.Where(jo => jo.Usuario.Id == u.Id));
                    if (mesasMt.Count() > 0)
                        mesas.AddRange(mesasMt.ToList());
                    if (mesasJo.Count() > 0)
                        mesas.AddRange(mesasJo.ToList());

                    return mesas;
                }
                catch (Exception ex)
                {
                    throw new Exception("[MesaDao.Listar]", ex);
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
                    throw new Exception("[MesaDao.Listar]", ex);
                }
            }
        }
    }
}