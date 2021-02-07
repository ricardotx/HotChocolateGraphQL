using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Converters;
using HotChocolateGraphQL.Core.Source.Enums;

using System;

namespace HotChocolateGraphQL.Core.Source.DataModels
{
	public class Account : IConvertModel<Account, AccountApiModel>
	{
		public string Description { get; set; }

		public Guid Id { get; set; }

		public Owner Owner { get; set; }

		public Guid OwnerId { get; set; }

		public AccountTypeEnum Type { get; set; }

		public AccountApiModel Convert()
		{
			return new AccountApiModel
			{
				Id = Id,
				Description = Description,
				OwnerId = OwnerId,
				Type = Type
			};
		}
	}
}
