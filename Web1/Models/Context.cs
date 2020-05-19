using Microsoft.EntityFrameworkCore;

namespace Web1.Models
{
    public class Context : DbContext
    {
        public DbSet<State> States { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<StateClient> StateClients { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
    }
}