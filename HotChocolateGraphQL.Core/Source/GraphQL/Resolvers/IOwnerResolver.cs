using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.GraphQL.Types;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Core.Source.GraphQL.Resolvers
{
	public interface IOwnerResolver
	{
		Task<OwnerApiModel> OwnerAsync(Guid ownerId);

		Task<OwnerApiModel> OwnerCreateAsync(OwnerInput data);

		Task<string> OwnerDeleteAsync(Guid ownerId);

		Task<IEnumerable<OwnerApiModel>> OwnersAsync();

		Task<OwnerApiModel> OwnerUpdateAsync(Guid ownerId, OwnerInput data);
	}
}
