namespace FileUpload_demo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<SalesForce> SalesForces { get; set; }
        public virtual DbSet<SalesTerritory> SalesTerritories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesForce>()
                .Property(e => e.Pic)
                .IsUnicode(false);
        }
    }
}
