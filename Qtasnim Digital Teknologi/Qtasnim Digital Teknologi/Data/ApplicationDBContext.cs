using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Qtasnim_Digital_Teknologi.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qtasnim_Digital_Teknologi.Data
{
	internal class ApplicationDBContext : DbContext
	{
		public DbSet<Inventory> inventories { get; set; }
		public ApplicationDBContext()
		{

		}
		// Configure the connection
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured) // Ensures that options are not configured more than once
			{
				// Retrieve the connection string from app.config
				string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
				optionsBuilder.UseSqlServer(connectionString);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Inventory>().HasData(
					new Inventory { ID = 1, Name = "Pencil", Quantity = 1, Description = "Test Object" },
					new Inventory { ID = 2, Name = "Pen", Quantity = 1, Description = "Test Object" },
					new Inventory { ID = 3, Name = "Marker", Quantity = 1, Description = "Test Object" },
					new Inventory { ID = 4, Name = "Book", Quantity = 1, Description = "Test Object" },
					new Inventory { ID = 5, Name = "Box", Quantity = 1, Description = "Test Object" }
				);

		}
	}
}
