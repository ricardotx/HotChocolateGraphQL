using HotChocolate.Types;

using HotChocolateGraphQL.Core.Source.Enums;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Account.Types
{
	public class AccountTypeEnumType : EnumType<AccountTypeEnum>
	{
		protected override void Configure(IEnumTypeDescriptor<AccountTypeEnum> descriptor)
		{
			descriptor.Name("AccountTypeEnum");
			descriptor.Description("Enumeration for the account type object.");
		}
	}
}
