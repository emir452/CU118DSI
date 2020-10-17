using RestoGestion.Models;
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
            ViewBag.sectors = new SelectList(new SectorManager().FindAll(), "id_sector", "name");
            List<string> options = new List<string>();
            options.Add("Piso");
            options.Add("Sector");
            ViewBag.optionsTotalization = new SelectList(options);
            return View();
}
[HttpPost]
public ActionResult TimesInOrders(TimesInOrderData requireData)
        {
            this.Session["report"] = requireData;
            return RedirectToAction("SelectVisualizationMode", "Report");
            }
[HttpGet]
        public ActionResult SelectVisualizationMode()
        {
List<string> optionsVisualization = new List<string>();
            optionsVisualization.Add("Por pantalla ");
            optionsVisualization.Add("PDF");
            optionsVisualization.Add("Excel");
            ViewBag.optionsVisualization = new SelectList(optionsVisualization);
            return View();
        }
    }
}