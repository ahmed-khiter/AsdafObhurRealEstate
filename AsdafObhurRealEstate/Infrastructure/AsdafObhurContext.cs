using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AsdafObhurRealEstate.Infrastructure
{
    public class AsdafObhurContext : IdentityDbContext<BaseUser>
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Multimedia> Multimedias { get; set; }


        private readonly ILoggerFactory _loggerFactory;
        public AsdafObhurContext(DbContextOptions<AsdafObhurContext> options, ILoggerFactory loggerFactory) : base(options)
        {
            _loggerFactory = loggerFactory;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            SeedData.SeedRoles(builder, _loggerFactory);
            SeedData.SeedDepartment(builder, _loggerFactory);
            SeedData.SeedUsers(builder, _loggerFactory);
            SeedData.SeedRoleToUsers(builder, _loggerFactory);

        }




        }
}
