namespace RestoGestion.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SectorsByFloor
    {
        [Key]
        public int id_sectorsByFloors { get; set; }

        public int? id_floor { get; set; }

        public int? id_sector { get; set; }

        public virtual Floor Floor { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
