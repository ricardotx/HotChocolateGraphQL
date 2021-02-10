using HotChocolateGraphQL.Core.Source.Enums;

using System;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Account.Types
{
	public class AccountInputType
	{
		public string Description { get; set; }

		public Guid OwnerId { get; set; }

		public AccountTypeEnum Type { get; set; }
	}
}
