using RestoGestion.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoGestion.Controllers
{
    public class FloorManager
    {
        private EntityModel db = new EntityModel();
        public IList<Floor> FindAll()
        {
            return db.Floors.ToList();
        }
    }
}