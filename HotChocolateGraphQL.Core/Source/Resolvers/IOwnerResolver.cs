using HotChocolateGraphQL.Core.Source.ApiModels;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Core.Source.Resolvers
{
	public interface IOwnerResolver
	{
		Task<OwnerApiModel> OwnerAsync(Guid ownerId);

		Task<OwnerApiModel> OwnerCreateAsync(OwnerApiModel data);

		Task<string> OwnerDeleteAsync(Guid ownerId);

		Task<IEnumerable<OwnerApiModel>> OwnersAsync();

		Task<OwnerApiModel> OwnerUpdateAsync(Guid ownerId, OwnerApiModel data);
	}
}
