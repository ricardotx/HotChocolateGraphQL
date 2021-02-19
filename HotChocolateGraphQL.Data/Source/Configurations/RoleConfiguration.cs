using HotChocolateGraphQL.Core.Source.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotChocolateGraphQL.Data.Source.Configurations
{
	class RoleConfiguration : IEntityTypeConfiguration<Role>
	{
		public void Configure(EntityTypeBuilder<Role> builder)
		{
			builder
				.HasKey(x => x.Id);

			builder
				.Property(x => x.Code)
				.IsRequired();

			// Constraints
			builder
				.HasIndex(x => x.Code)
				.IsUnique()
				.HasDatabaseName("UniqueCode");

			builder
				.HasMany(x => x.Users)
				.WithOne(x => x.Role)
				.HasForeignKey(x => x.RoleId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
