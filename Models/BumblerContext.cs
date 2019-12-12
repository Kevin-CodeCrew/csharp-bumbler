using Microsoft.EntityFrameworkCore;

namespace BumblerApi.Models
{
    // The db context for interacting with Bumbler records
    public class BumblerContext : DbContext
    {
        public BumblerContext(DbContextOptions<BumblerContext> options)
            : base(options)
        {
        }

        public DbSet<BumblerItem> BumblerItems { get; set; }
    }
}