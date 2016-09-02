using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPG_Remix.Models.DAO
{
    public class PeculiaridadeDao
    {
        public int Inserir(Peculiaridade peculiaridade)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    peculiaridade = rrc.PeculiaridadeSet.Add(peculiaridade);
                    return peculiaridade.Id;
                }
                catch (Exception ex)
                {
                    throw new Exception("[PeculiaridadeDao.Inserir] -> " + ex.Message);
                }
            }
        }

        public void InserirVarios(ICollection<Peculiaridade> peculiaridades)
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    foreach (var p in peculiaridades) rrc.PeculiaridadeSet.Add(p);
                }
                catch (Exception ex)
                {
                    throw new Exception("[PeculiaridadeDao.InserirVarios] -> " + ex.Message);
                }
            }
        }
    }
}