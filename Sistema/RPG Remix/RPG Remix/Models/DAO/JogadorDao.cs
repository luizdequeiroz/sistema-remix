using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPG_Remix.Models.DAO
{
    public class JogadorDao
    {
        public void Inserir(Jogador jogador)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    rrc.JogadorSet.Add(jogador);
                    rrc.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("[JogadorDao.Inserir] -> " + ex.Message);
                }
            }
        }

        public List<Jogador> Listar()
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    return rrc.JogadorSet.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("[JogadorDao.Listar] -> " + ex.Message);
                }
            }
        }

        public List<Jogador> ListarDoUsuario(Usuario u)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    return rrc.JogadorSet.Where(j => j.UsuarioId == u.Id).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("[JogadorDao.Listar] -> " + ex.Message);
                }
            }
        }
    }
}