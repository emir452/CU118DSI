using RestoGestion.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoGestion.Controllers
{
    public class SectorManager
    {
        private EntityModel db = new EntityModel();
        public IList<Sector> FindAll()
{
            return db.Sectors.ToList();
}
    }
}