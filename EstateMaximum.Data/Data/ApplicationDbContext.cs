using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EstateMaximum.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<HouseEntity> House {  get; set; }    
        public DbSet<ApartmentEntity> Apartment { get; set; }
        public DbSet<User> ApplicationUsers { get; set; }

    }
}
