using HotChocolateGraphQL.Api.Source.GraphQL.Account.Types;
using HotChocolateGraphQL.Api.Source.GraphQL.Owner.Types;
using HotChocolateGraphQL.Core.Source.ApiModels;

using System.Collections.Generic;
using System.Linq;

namespace HotChocolateGraphQL.Api.Source.Extensions
{
	public static class ConvertGQLTypeExtentions
	{
		public static IEnumerable<AccountApiModel> ConvertAllTFromGQL(this IEnumerable<AccountInputType> apiModels)
		{
			return apiModels.Select(model => model.ConvertFromGQL());
		}

		public static IEnumerable<AccountInputType> ConvertAllToGQL(this IEnumerable<AccountApiModel> apiModels)
		{
			return apiModels.Select(model => model.ConvertToGQL());
		}

		public static AccountApiModel ConvertFromGQL(this AccountInputType gqlType)
		{
			return new AccountApiModel
			{
				Type = gqlType.Type,
				Description = gqlType.Description,
				OwnerId = gqlType.OwnerId
			};
		}

		public static OwnerApiModel ConvertFromGQL(this OwnerInputType gqlType)
		{
			return new OwnerApiModel
			{
				Name = gqlType.Name,
				Address = gqlType.Address
			};
		}

		public static AccountInputType ConvertToGQL(this AccountApiModel apiModel)
		{
			return new AccountInputType
			{
				Type = apiModel.Type,
				Description = apiModel.Description,
				OwnerId = apiModel.OwnerId
			};
		}

		public static OwnerInputType ConvertToGQL(this OwnerApiModel apiModel)
		{
			return new OwnerInputType
			{
				Name = apiModel.Name,
				Address = apiModel.Address
			};
		}
	}
}
