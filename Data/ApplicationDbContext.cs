using Microsoft.EntityFrameworkCore;
using Dinozavr.Models;

namespace Dinozavr.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<GameScore> GameScores { get; set; }
    }
}
