using Microsoft.EntityFrameworkCore;
using ZeMERP.Data.Configuration;
using ZeMERP.Models;
using ZeMERP.Models.Shared;

namespace ZeMERP.Data
{
    public class ZeMERPDbContext : DbContext
    {
        public ZeMERPDbContext(DbContextOptions<ZeMERPDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmailConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new PhoneConfiguration());


        }
    }
}
