using HotChocolateGraphQL.Data.Models;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Services.Contracts
{
	public interface IOwnerService
	{
		Task<Owner> CreateOwnerAsync(Owner owner);

		Task<string> DeleteOwnerAsync(Guid ownerId);

		Task<Owner> GetOwnerAsync(Guid ownerId);

		Task<IEnumerable<Owner>> GetOwnersAsync();

		Task<Owner> UpdateOwnerAsync(Guid ownerId, Owner owner);
	}
}
