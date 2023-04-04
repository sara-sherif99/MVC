using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC.Identity.Database.Models;

namespace MVC.Identity.Database.Context
{
    public class EmployeesContext : IdentityDbContext<User>
    {
        public EmployeesContext(DbContextOptions<EmployeesContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UsersClaims");
        }
    }
}
