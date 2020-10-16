using RestoGestion.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestoGestion.Controllers
{
    public class ReportController : Controller
{
        [HttpGet]
public ActionResult TimesInOrders()
        {
            ViewBag.states =new SelectList(new StateManager().FindAll(), "id_state", "name");
            ViewBag.floors = new SelectList(new FloorManager().FindAll(), "id_floor", "id_floor"); 
            return View();

}
}
}