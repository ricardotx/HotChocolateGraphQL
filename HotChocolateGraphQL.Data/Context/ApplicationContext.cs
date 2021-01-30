using HotChocolateGraphQL.Data.Models;
using HotChocolateGraphQL.Data.Models.Configurations;

using Microsoft.EntityFrameworkCore;

using System;

namespace HotChocolateGraphQL.Data.Context
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Account> Accounts { get; set; }
		public DbSet<Owner> Owners { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid() };
			modelBuilder.ApplyConfiguration(new OwnerConfiguration(ids));
			modelBuilder.ApplyConfiguration(new AccountConfiguration(ids));
		}
	}
}
