using HotChocolateGraphQL.Core.Source.Enums;

using System;

namespace HotChocolateGraphQL.Core.Source.GraphQL.Types
{
	public class AccountInput
	{
		public string Description { get; set; }

		public Guid OwnerId { get; set; }

		public AccountTypeEnum Type { get; set; }
	}
}
