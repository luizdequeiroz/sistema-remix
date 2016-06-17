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
                    rrc.UsuarioSet.Add(usuario);
                    rrc.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("[Usuario.Inserir]", ex);
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
                    throw new Exception("[Usuario.SelecionarPorEmail]", ex);
                }
            }
        }
    }
}