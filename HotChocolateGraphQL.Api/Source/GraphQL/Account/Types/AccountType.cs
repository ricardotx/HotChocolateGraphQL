using HotChocolate.Types;

using HotChocolateGraphQL.Api.Source.GraphQL.Owner.Types;
using HotChocolateGraphQL.Core.Source.ApiModels;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Account.Types
{
	public class AccountType : ObjectType<AccountApiModel>
	{
		protected override void Configure(IObjectTypeDescriptor<AccountApiModel> descriptor)
		{
			descriptor.Field(x => x.Id).Type<NonNullType<IdType>>();
			descriptor.Field(x => x.Description).Type<StringType>();
			descriptor.Field(x => x.OwnerId).Type<IdType>();
			descriptor.Field(x => x.Type).Type<AccountTypeEnumType>();
			descriptor.Field(x => x.Owner).Type<OwnerType>();
		}
	}
}
