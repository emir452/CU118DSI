using RestoGestion.Models;
using RestoGestion.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace RestoGestion.Controllers
{
    public class ReportController : Controller
{
        [HttpGet]
public ActionResult TimesInOrders()
        {
            
            ViewBag.states =new  MultiSelectList(new StateManager().FindAll(), "id_state", "name");
            ViewBag.floors = new  MultiSelectList(new FloorManager().FindAll(), "id_floor", "id_floor"); 
            ViewBag.sectors = new MultiSelectList(new SectorManager().FindAll(), "id_sector", "name");
            return View();
}
[HttpPost]
public ActionResult TimesInOrders(TimesInOrderData requireData)
        {
            if (this.CheckDates(requireData.dateFrom, requireData.dateTo))
            {
                this.Session["report"] = requireData;
               return RedirectToAction("SelectVisualizationMode", "Report");
            }
            return RedirectToAction("TimesInOrders", "Report");
}
        private  bool  CheckDates(DateTime dateFrom, DateTime dateTo)
        {
            return (dateFrom <= DateTime.Now && dateTo <= DateTime.Now); 
        }
        [HttpGet]
        public ActionResult SelectVisualizationMode()
{
return View();
        }
        [HttpPost]
        public ActionResult SelectVisualizationMode(ReportCustomization customization)
        {
            Session s = new Session();
            User u = new User();
            u.user_name = "rey";
            s.User = u;
             return (Rotativa.ActionAsPdf) new GestorGeneradorReporteDeTiemposEnPedidos().GenerarReporteDeTiemposEnPedidos((TimesInOrderData)this.Session["report"], this.selectReportBuilder(customization.optionVisualization),s);
}
        public ActionResult ViewReport(TimesInOrdersReport report)
        {
            return View(report);
        }
        private IConstructorReporte selectReportBuilder(OptionsVisualization option)
        {
if(option==OptionsVisualization.PDF)
            {
                return new ConstructorArchivoPDF(); 
            }
if(option==OptionsVisualization.Excel)
            {
                return new ConstructorArchivoExcel(); 
            }
if(option== OptionsVisualization.pantalla)
            {
                return new ConstructorPantallaReporte();
            }
else
            {
                throw new NotImplementedException();
            }
}
}
}