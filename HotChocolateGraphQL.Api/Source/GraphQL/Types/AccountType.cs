using HotChocolate.Types;

using HotChocolateGraphQL.Api.Source.GraphQL.Resolvers;
using HotChocolateGraphQL.Core.Source.Entities;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Types
{
	public class AccountType : ObjectType<Account>
	{
		protected override void Configure(IObjectTypeDescriptor<Account> descriptor)
		{
			descriptor.Field(x => x.Id).Type<NonNullType<UuidType>>();
			descriptor.Field(x => x.Description).Type<StringType>();
			descriptor.Field(x => x.Type).Type<AccountTypeEnumType>();
			descriptor.Field(x => x.OwnerId).Type<UuidType>();

			descriptor.Field(x => x.Owner)
				.ResolveWith<AccountFieldResolver>(x => x.OwnerAsync(default, default, default));
		}
	}
}
