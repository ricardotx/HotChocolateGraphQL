using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Converters;
using HotChocolateGraphQL.Core.Source.Enums;

using System;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Types
{
	public class AccountInput : IConvertGQLType<AccountInput, AccountApiModel>
	{
		public string Description { get; set; }

		public Guid OwnerId { get; set; }

		public AccountTypeEnum Type { get; set; }

		public AccountInput ConvertFromApiModel(AccountApiModel apiModel)
		{
			return new AccountInput
			{
				Type = apiModel.Type,
				Description = apiModel.Description,
				OwnerId = apiModel.OwnerId
			};
		}

		public AccountApiModel ConvertFromGQL()
		{
			return new AccountApiModel
			{
				Type = Type,
				Description = Description,
				OwnerId = OwnerId
			};
		}
	}
}
