namespace RestoGestion.Models.Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<SeccionesBySector> SeccionesBySectors { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<SectorsByFloor> SectorsByFloors { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StateHistoryDetailsOrder> StateHistoryDetailsOrders { get; set; }
        public virtual DbSet<StateHistoryOrder> StateHistoryOrders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Section>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Sector>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.ambit)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.StateHistoryOrders)
                .WithOptional(e => e.State1)
                .HasForeignKey(e => e.state);

            modelBuilder.Entity<State>()
                .HasMany(e => e.StateHistoryDetailsOrders)
                .WithOptional(e => e.State1)
                .HasForeignKey(e => e.state);
        }
    }
}
