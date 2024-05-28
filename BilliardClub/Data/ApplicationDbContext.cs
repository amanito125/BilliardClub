using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BilliardClub.Data;

namespace BilliardClub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BilliardClub.Data.Table>? Table { get; set; }
        public DbSet<BilliardClub.Data.User>? User { get; set; }
        public DbSet<BilliardClub.Data.Reservation>? Reservation { get; set; }
    }
}
