namespace RestoGestion.Models.Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel1")
        {
        }

        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<SectorsByFloor> SectorsByFloors { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StateHistoryDetailsOrder> StateHistoryDetailsOrders { get; set; }
        public virtual DbSet<StateHistoryOrder> StateHistoryOrders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Floor>()
                .HasMany(e => e.Sectors)
                .WithOptional(e => e.Floor1)
                .HasForeignKey(e => e.floor);

            modelBuilder.Entity<Section>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Sector>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.Sections)
                .WithOptional(e => e.Sector1)
                .HasForeignKey(e => e.sector);

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

            modelBuilder.Entity<Table>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Table)
                .HasForeignKey(e => e.mesa);

            modelBuilder.Entity<User>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.pasword)
                .IsUnicode(false);
        }
    }
}
