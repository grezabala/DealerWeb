using DealerWebApp.DealertWeb.Aplication.Dominio;
using Microsoft.EntityFrameworkCore;

namespace DealerWebApp.DealertWeb.Aplication.Data.DDBB
{
    public partial class DealerWebDbContext : DbContext
    {
        public DealerWebDbContext(DbContextOptions<DealerWebDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Contactos> Contactos { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder) 
        {
            base.OnConfiguring(contextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
          base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder builder);
    }
}
