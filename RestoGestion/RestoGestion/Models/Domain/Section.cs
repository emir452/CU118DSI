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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Section()
        {
            SeccionesBySectors = new HashSet<SeccionesBySector>();
        }

        [Key]
        public int id_section { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? id_table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeccionesBySector> SeccionesBySectors { get; set; }

        public virtual Table Table { get; set; }
    }
}
