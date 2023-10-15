using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using River.Services.AuthAPI.Models;

namespace River.Services.AuthAPI.Data
{
    public class RiverDbContext : IdentityDbContext<ApplicationUser>
    {
        public RiverDbContext(DbContextOptions<RiverDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
