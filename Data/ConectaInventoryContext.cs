using Microsoft.EntityFrameworkCore;
using ConectaInventory.Models;

namespace ConectaInventory.Data
{
    public class ConectaInventoryContext : DbContext
    {
        public ConectaInventoryContext(DbContextOptions<ConectaInventoryContext> options) : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; }
    }
}