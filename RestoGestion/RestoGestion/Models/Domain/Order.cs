namespace RestoGestion.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            StateHistoryOrders = new HashSet<StateHistoryOrder>();
        }

        [Key]
        public int id_order { get; set; }

        public int count_footers { get; set; }

        public DateTime date_order { get; set; }

        public int? mesa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual Table Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateHistoryOrder> StateHistoryOrders { get; set; }
        public double calculateResidentTime(State state)
        {
 foreach(StateHistoryOrder i in this.StateHistoryOrders)
{
if(i.State1== state)
                {
                    return i.CalcularDuraciónEnEstado();
}
}
            throw new StateNotFoundException(); 
}
        public bool EsDeSector( Sector s)
        {
            EntityModel db = new EntityModel();
 foreach(Sector i in             db.Sectors.ToList())
                {
                foreach(Section j in i.Sections)
                {
foreach(Order k in j.Table.Orders)
                    {
if(k== this)
                        {
                            return true;
}
}
}
}
            db.Dispose();
            return false;
}
        public bool PasoPorEstado(State state)
        {
foreach( StateHistoryOrder i in this.StateHistoryOrders)
            {
if(i.EsTuEstado(state))
                {
                    return true;
}
}
            return false;
        }

}
}
