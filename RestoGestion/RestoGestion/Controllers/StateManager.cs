using RestoGestion.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoGestion.Controllers
{
    public class StateManager
    {
        private EntityModel db = new EntityModel();
        public IList<State> FindAll()
        {
            return db.States.ToList();
        }
    }
}