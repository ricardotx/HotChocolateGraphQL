using HotChocolate;

using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.GraphQL.Resolvers;
using HotChocolateGraphQL.Core.Source.GraphQL.Types;

using System;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL
{
	public class Mutation
	{
		public async Task<AccountApiModel> AccountCreate(AccountInput data, [Service] IAccountResolver resolver)
			=> await resolver.AccountCreateAsync(data);

		public async Task<string> AccountDelete(Guid accountId, [Service] IAccountResolver resolver)
			=> await resolver.AccountDeleteAsync(accountId);

		public async Task<AccountApiModel> AccountUpdate(AccountInput data, Guid accountId, [Service] IAccountResolver resolver)
			=> await resolver.AccountUpdateAsync(accountId, data);

		public async Task<OwnerApiModel> OwnerCreate(OwnerInput data, [Service] IOwnerResolver resolver)
			=> await resolver.OwnerCreateAsync(data);

		public async Task<string> OwnerDelete(Guid ownerId, [Service] IOwnerResolver resolver)
			=> await resolver.OwnerDeleteAsync(ownerId);

		public async Task<OwnerApiModel> OwnerUpdate(OwnerInput data, Guid ownerId, [Service] IOwnerResolver resolver)
			=> await resolver.OwnerUpdateAsync(ownerId, data);
	}
}
