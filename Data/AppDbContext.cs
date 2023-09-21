
using Backend.Netcore.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Netcore.Data
{
        public class AppDbContext: DbContext
        {

            public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
            {

            }

            public DbSet<Command> commands => Set<Command>();
        }    
}