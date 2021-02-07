using HotChocolateGraphQL.Core.Source.Converters;
using HotChocolateGraphQL.Core.Source.DataModels;
using HotChocolateGraphQL.Core.Source.Enums;

using System;

namespace HotChocolateGraphQL.Core.Source.ApiModels
{
	public class AccountApiModel : IConvertModel<AccountApiModel, Account>
	{
		public string Description { get; set; }

		public Guid Id { get; set; }

		public OwnerApiModel Owner { get; set; }

		public Guid OwnerId { get; set; }

		public AccountTypeEnum Type { get; set; }

		public Account Convert()
		{
			return new Account
			{
				Id = Id,
				OwnerId = OwnerId,
				Type = Type
			};
		}
	}
}
