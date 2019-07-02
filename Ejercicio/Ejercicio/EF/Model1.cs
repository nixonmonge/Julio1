namespace Ejercicio.EF
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

        public virtual DbSet<actor> actor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<actor>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<actor>()
                .Property(e => e.last_name)
                .IsUnicode(false);
        }
    }
}
