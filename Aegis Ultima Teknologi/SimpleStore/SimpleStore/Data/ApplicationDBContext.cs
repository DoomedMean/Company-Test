using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SimpleStore.Models;

namespace SimpleStore.Data
{
	public class ApplicationDBContext : IdentityDbContext<IdentityUser>
	{
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base((options))
        {
            
        }

		public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

            //var adminRoleId = Guid.NewGuid().ToString();
            //var cashierRoleId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
			builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Cashier", NormalizedName = "CASHIER" });

            var adminUserId = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<IdentityUser>();
            var adminUser = new IdentityUser
            {
                Id = adminUserId,
                UserName = "admin@example.com",
                Email = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "111");

            builder.Entity<IdentityUser>().HasData(adminUser);

            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = adminRoleId,
            //    UserId = adminUserId
            //});
        }
	}
}
