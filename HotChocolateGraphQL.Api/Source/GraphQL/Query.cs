using HotChocolate;

using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.GraphQL.Resolvers;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL
{
	public class Query
	{
		public async Task<AccountApiModel> Account(Guid accountId, [Service] IAccountResolver resolver)
			=> await resolver.AccountAsync(accountId);

		public async Task<IEnumerable<AccountApiModel>> Accounts([Service] IAccountResolver resolver)
			=> await resolver.AccountsAsync();

		public async Task<OwnerApiModel> Owner(Guid ownerId, [Service] IOwnerResolver resolver)
			=> await resolver.OwnerAsync(ownerId);

		public async Task<IEnumerable<OwnerApiModel>> Owners([Service] IOwnerResolver resolver)
			=> await resolver.OwnersAsync();
	}
}
