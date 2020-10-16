using RestoGestion.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoGestion.Models
{
    public class TimesInOrderData
    {
public DateTime dateFrom { get; set;}
        public DateTime dateTo { get; set;}
        public IList<State> states { get; set;}
        public IList<Floor> floors { get; set; }
        public IList<Sector> sectors { get; set; }
}
}