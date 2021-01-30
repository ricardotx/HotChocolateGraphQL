using HotChocolate;

using HotChocolateGraphQL.Api.GraphQL.Resolvers.Contracts;
using HotChocolateGraphQL.Api.GraphQL.Types;
using HotChocolateGraphQL.Data.Models;

using System;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.GraphQL
{
	public class Mutation
	{
		public async Task<Account> AccountCreate(AccountInput data, [Service] IAccountResolver resolver)
			=> await resolver.AccountCreateAsync(data);

		public async Task<string> AccountDelete(Guid accountId, [Service] IAccountResolver resolver)
			=> await resolver.AccountDeleteAsync(accountId);

		public async Task<Account> AccountUpdate(AccountInput data, Guid accountId, [Service] IAccountResolver resolver)
			=> await resolver.AccountUpdateAsync(accountId, data);

		public async Task<Owner> OwnerCreate(OwnerInput data, [Service] IOwnerResolver resolver)
			=> await resolver.OwnerCreateAsync(data);

		public async Task<string> OwnerDelete(Guid ownerId, [Service] IOwnerResolver resolver)
			=> await resolver.OwnerDeleteAsync(ownerId);

		public async Task<Owner> OwnerUpdate(OwnerInput data, Guid ownerId, [Service] IOwnerResolver resolver)
			=> await resolver.OwnerUpdateAsync(ownerId, data);
	}
}
