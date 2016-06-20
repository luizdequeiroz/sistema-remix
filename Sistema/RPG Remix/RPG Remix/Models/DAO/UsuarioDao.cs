using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPG_Remix.Models.DAO
{
    public class UsuarioDao
    {
        public void Inserir(Usuario usuario)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    usuario.DataCadastro = DateTime.Now.ToString();
                    rrc.UsuarioSet.Add(usuario);
                    rrc.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("[UsuarioDao.Inserir]", ex);
                }
            }
        }

        public Usuario SelecionarPorEmail(string email)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    return rrc.UsuarioSet.ToList().Where(u => u.Email == email).Single();
                }
                catch (Exception ex)
                {
                    throw new Exception("[UsuarioDao.SelecionarPorEmail]", ex);
                }
            }
        }

        public List<Usuario> Listar()
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    return rrc.UsuarioSet.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("[UsuarioDao.Listar]", ex);
                }
            }
        }
    }
}