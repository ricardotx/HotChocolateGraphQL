using HotChocolate.Types;

using HotChocolateGraphQL.Api.Source.GraphQL.Account.Types;
using HotChocolateGraphQL.Core.Source.ApiModels;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Owner.Types
{
	public class OwnerType : ObjectType<OwnerApiModel>
	{
		protected override void Configure(IObjectTypeDescriptor<OwnerApiModel> descriptor)
		{
			descriptor.Field(x => x.Id).Type<NonNullType<IdType>>();
			descriptor.Field(x => x.Name).Type<StringType>();
			descriptor.Field(x => x.Address).Type<StringType>();
			descriptor.Field(x => x.Accounts).Type<ListType<AccountType>>();
		}
	}
}
