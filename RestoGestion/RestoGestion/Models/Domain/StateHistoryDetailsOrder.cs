namespace RestoGestion.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StateHistoryDetailsOrder")]
    public partial class StateHistoryDetailsOrder
    {
        [Key]
        public int id_history { get; set; }

        public int? state { get; set; }

        public DateTime date_from { get; set; }

        public DateTime date_to { get; set; }

        public int? id_detail { get; set; }

        public virtual OrderDetail OrderDetail { get; set; }

        public virtual State State1 { get; set; }
    }
}
