using HotChocolateGraphQL.Core.Source.ApiModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Core.Source.Services
{
	public interface IDataLoaderService
	{
		Task<ILookup<Guid, AccountApiModel>> AccountsByOwnerIdsAsync(IEnumerable<Guid> ownerIds);

		Task<IDictionary<Guid, OwnerApiModel>> OwnersByIdAsync(IEnumerable<Guid> ownerIds);
	}
}
