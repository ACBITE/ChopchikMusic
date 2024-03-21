using System;
using Microsoft.EntityFrameworkCore;
using prototype.Domain.Entities;

namespace prototype.Persistence.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Album> Album { get; set; }
		public AppDbContext()
		{
		}
	}
}

