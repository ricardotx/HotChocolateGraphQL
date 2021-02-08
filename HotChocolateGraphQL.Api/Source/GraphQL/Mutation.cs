using HotChocolate;

using HotChocolateGraphQL.Api.Source.GraphQL.Types;
using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Resolvers;

using System;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL
{
	public class Mutation
	{
		public async Task<AccountApiModel> AccountCreate(AccountInput data, [Service] IAccountResolver resolver)
		{
			var apiModel = data.ConvertFromGQL();
			return await resolver.AccountCreateAsync(apiModel);
		}

		public async Task<string> AccountDelete(Guid accountId, [Service] IAccountResolver resolver)
		{
			return await resolver.AccountDeleteAsync(accountId);
		}

		public async Task<AccountApiModel> AccountUpdate(AccountInput data, Guid accountId, [Service] IAccountResolver resolver)
		{
			var apiModel = data.ConvertFromGQL();
			return await resolver.AccountUpdateAsync(accountId, apiModel);
		}

		public async Task<OwnerApiModel> OwnerCreate(OwnerInput data, [Service] IOwnerResolver resolver)
		{
			var apiModel = data.ConvertFromGQL();
			return await resolver.OwnerCreateAsync(apiModel);
		}

		public async Task<string> OwnerDelete(Guid ownerId, [Service] IOwnerResolver resolver)
		{
			return await resolver.OwnerDeleteAsync(ownerId);
		}

		public async Task<OwnerApiModel> OwnerUpdate(OwnerInput data, Guid ownerId, [Service] IOwnerResolver resolver)
		{
			var apiModel = data.ConvertFromGQL();
			return await resolver.OwnerUpdateAsync(ownerId, apiModel);
		}
	}
}
