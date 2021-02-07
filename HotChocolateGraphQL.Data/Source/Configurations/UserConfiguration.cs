using HotChocolateGraphQL.Core.Source.DataModels;
using HotChocolateGraphQL.Core.Source.Enums;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotChocolateGraphQL.Data.Source.Configurations
{
	class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder
			   .HasKey(x => x.Id);

			builder
				.Property(x => x.Status)
				.HasDefaultValue(UserStatusEnum.Active);

			builder
				.Property(x => x.Name)
				.IsRequired();

			builder
				.Property(x => x.Email)
				.IsRequired();

			builder
				.Property(x => x.Password)
				.IsRequired();

			builder
			   .Property(x => x.RoleId)
			   .IsRequired();

			// Contraints
			builder
				.HasIndex(x => x.Email)
				.IsUnique()
				.HasDatabaseName("UniqueUserEmail");
		}
	}
}
