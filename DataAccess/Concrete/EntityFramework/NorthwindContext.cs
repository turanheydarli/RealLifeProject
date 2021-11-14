using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class NorthwindContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-62OF0BB;Database=Northwind;Trusted_Connection=true");
		}
		DbSet<Product> Products { get; set; }
		DbSet<Category> Categories { get; set; }
		DbSet<Customer> Customers { get; set; }
	}
}
