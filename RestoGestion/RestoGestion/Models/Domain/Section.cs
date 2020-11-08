namespace RestoGestion.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Section")]
    public partial class Section
    {
        [Key]
        public int id_section { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? id_table { get; set; }

        public int? sector { get; set; }

        public virtual Table Table { get; set; }

        public virtual Sector Sector1 { get; set; }
    }
}
