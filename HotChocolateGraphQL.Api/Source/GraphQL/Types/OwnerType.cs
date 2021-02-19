using HotChocolate.Types;

using HotChocolateGraphQL.Api.Source.GraphQL.Resolvers;
using HotChocolateGraphQL.Core.Source.Entities;
using HotChocolateGraphQL.Data.Source.Context;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Types
{
	public class OwnerType : ObjectType<Owner>
	{
		protected override void Configure(IObjectTypeDescriptor<Owner> descriptor)
		{
			descriptor.Field(x => x.Id).Type<NonNullType<UuidType>>();
			descriptor.Field(x => x.Name).Type<StringType>();
			descriptor.Field(x => x.Address).Type<StringType>();
			descriptor.Field(x => x.Accounts).Type<ListType<AccountType>>();

			descriptor.Field(x => x.Accounts)
				.ResolveWith<OwnerFieldResolver>(x => x.AccountsAsync(default, default, default, default))
				.UseDbContext<StorageContext>();
		}
	}
}
