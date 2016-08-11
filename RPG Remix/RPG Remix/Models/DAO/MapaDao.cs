using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPG_Remix.Models.DAO
{
    public class MapaDao
    {
        public List<Mapa> Listar()
        {
            using (var rrc = new RemixRPGContainer())
            {
                try
                {
                    return rrc.MapaSet.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("[MapaDao.Listar] -> " + ex.Message);
                }
            }
        }
    }
}