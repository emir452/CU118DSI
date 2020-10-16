namespace RestoGestion.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeccionesBySector")]
    public partial class SeccionesBySector
    {
        [Key]
        public int id_seccionBySector { get; set; }

        public int? id_section { get; set; }

        public int? id_sector { get; set; }

        public virtual Section Section { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
