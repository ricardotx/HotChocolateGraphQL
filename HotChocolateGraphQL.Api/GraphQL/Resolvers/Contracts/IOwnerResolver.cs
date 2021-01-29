using HotChocolateGraphQL.Api.GraphQL.Types;
using HotChocolateGraphQL.Data.Models;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.GraphQL.Resolvers.Contracts
{
	public interface IOwnerResolver
	{
		//IDataLoaderResult<IEnumerable<Account>> DataLoaderAccounts(IResolveFieldContext<Owner> context, IDataLoaderContextAccessor dataLoader);

		//Owner QueryOwner(IResolveFieldContext context);

		Task<Owner> OwnerAsync(Guid ownerId);

		Task<Owner> OwnerCreateAsync(OwnerInput data);

		Task<string> OwnerDeleteAsync(Guid ownerId);

		Task<IEnumerable<Owner>> OwnersAsync();

		Task<Owner> OwnerUpdateAsync(Guid ownerId, OwnerInput data);
	}
}
