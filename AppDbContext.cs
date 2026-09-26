using IfoodClone.Models;
using Microsoft.EntityFrameworkCore;

namespace IfoodClone.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Conta> Contas => Set<Conta>();
        public DbSet<Restaurante> Restaurantes => Set<Restaurante>();
        public DbSet<Refeicao> Refeicoes => Set<Refeicao>();

        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<Conta>().HasIndex(c => c.Email).IsUnique();
            b.Entity<Restaurante>().HasIndex(r => r.Cnpj).IsUnique();
            b.Entity<Refeicao>()
             .HasOne<Restaurante>().WithMany()
             .HasForeignKey(r => r.RestauranteId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
