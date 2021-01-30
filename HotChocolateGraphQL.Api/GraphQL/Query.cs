using HotChocolate;

using HotChocolateGraphQL.Api.GraphQL.Resolvers.Contracts;
using HotChocolateGraphQL.Data.Models;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.GraphQL
{
	public class Query
	{
		public async Task<Account> Account(Guid accountId, [Service] IAccountResolver resolver) => await resolver.AccountAsync(accountId);

		public async Task<IEnumerable<Account>> Accounts([Service] IAccountResolver resolver) => await resolver.AccountsAsync();

		public async Task<Owner> Owner(Guid ownerId, [Service] IOwnerResolver resolver) => await resolver.OwnerAsync(ownerId);

		public async Task<IEnumerable<Owner>> Owners([Service] IOwnerResolver resolver) => await resolver.OwnersAsync();
	}
}
