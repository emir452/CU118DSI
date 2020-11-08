namespace RestoGestion.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StateHistoryOrder")]
    public partial class StateHistoryOrder
    {
        [Key]
        public int id_history { get; set; }

        public int? state { get; set; }

        public DateTime date_from { get; set; }

        public DateTime date_to { get; set; }

        public int? id_order { get; set; }

        public virtual Order Order { get; set; }

        public virtual State State1 { get; set; }
public float CalcularDuraciónEnEstado()
        {
            return (float) (this.date_to - date_from).TotalMinutes;
        }
        public bool EsTuEstado(State state)
        {
            return state == State1;
        }
}
}
