using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPG_Remix.Models.DAO
{
    public class FichaDao
    {
        public List<Ficha> ListarPorUsuarioId(int usuarioId)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    return rrc.FichaSet.Where(f => f.UsuarioId == usuarioId).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("[FichaDao.ListarPorUsuarioId] -> " + ex.Message);
                }
            }
        }

        public List<Ficha> Listar()
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    return rrc.FichaSet.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("[FichaDao.Listar] -> " + ex.Message);
                }
            }
        }

        public List<Ficha> ListarDeConhecidos(int usuarioId)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    var mesaIdsDasMinhasFichas = rrc.FichaSet.Where(f => f.UsuarioId == usuarioId).Select(f => f.MesaId).ToList();
                    var fichasDeConhecidos = rrc.FichaSet.Where(f => mesaIdsDasMinhasFichas.Contains(f.MesaId) && f.UsuarioId != usuarioId).ToList();

                    return fichasDeConhecidos;
                }
                catch (Exception ex)
                {
                    throw new Exception("[FichaDao.ListarDeConhecidos] -> " + ex.Message);
                }
            }
        }

        public int Inserir(Ficha ficha)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    ficha.DataNivel = DateTime.Now.ToString();
                    ficha = rrc.FichaSet.Add(ficha);
                    rrc.SaveChanges();
                    return ficha.Id;
                }
                catch (Exception ex)
                {
                    throw new Exception("[FichaDao.Inserir] -> " + ex.Message);
                }
            }
        }
    }
}