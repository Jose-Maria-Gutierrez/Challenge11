using ConcesionariaMVC1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcesionariaMVC1.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Vehiculo> Vehiculo { get; set; }
    }
}
