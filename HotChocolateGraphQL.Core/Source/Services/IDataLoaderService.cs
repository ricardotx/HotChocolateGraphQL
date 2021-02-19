using HotChocolateGraphQL.Core.Source.Dtos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Core.Source.Services
{
	public interface IDataLoaderService
	{
		Task<ILookup<Guid, AccountDto>> AccountsByOwnerIdsAsync(IEnumerable<Guid> ownerIds);

		Task<IDictionary<Guid, OwnerDto>> OwnersByIdAsync(IEnumerable<Guid> ownerIds);
	}
}
