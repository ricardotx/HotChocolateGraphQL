using HotChocolateGraphQL.Core.Source.Dtos;
using HotChocolateGraphQL.Core.Source.Converters;
using HotChocolateGraphQL.Core.Source.Enums;

using System;

namespace HotChocolateGraphQL.Core.Source.Entities
{
	public class Account : IConvertModel<Account, AccountDto>
	{
		public string Description { get; set; }

		public Guid Id { get; set; }

		public Owner Owner { get; set; }

		public Guid OwnerId { get; set; }

		public AccountTypeEnum Type { get; set; }

		public AccountDto Convert()
		{
			return new AccountDto
			{
				Id = Id,
				Type = Type,
				Description = Description,
				OwnerId = OwnerId,
				Owner = Owner?.Convert()
			};
		}
	}
}
