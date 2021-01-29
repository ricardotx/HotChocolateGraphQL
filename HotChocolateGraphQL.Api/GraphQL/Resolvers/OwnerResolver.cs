using HotChocolateGraphQL.Api.GraphQL.Resolvers.Contracts;
using HotChocolateGraphQL.Api.GraphQL.Types;
using HotChocolateGraphQL.Data.Models;
using HotChocolateGraphQL.Services.Contracts;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.GraphQL.Resolvers
{
	public class OwnerResolver : IOwnerResolver
	{
		private readonly IOwnerService _ownerService;

		public OwnerResolver(IOwnerService ownerService)
		{
			_ownerService = ownerService;
		}

		public async Task<Owner> OwnerAsync(Guid ownerId) => await _ownerService.GetOwnerAsync(ownerId);

		public async Task<Owner> OwnerCreateAsync(OwnerInput data)
		{
			var owner = new Owner
			{
				Name = data.Name,
				Address = data.Address
			};

			return await _ownerService.CreateOwnerAsync(owner);
		}

		public async Task<string> OwnerDeleteAsync(Guid ownerId) => await _ownerService.DeleteOwnerAsync(ownerId);

		public async Task<IEnumerable<Owner>> OwnersAsync() => await _ownerService.GetOwnersAsync();

		public async Task<Owner> OwnerUpdateAsync(Guid ownerId, OwnerInput data)
		{
			var owner = new Owner
			{
				Name = data.Name,
				Address = data.Address
			};

			return await _ownerService.UpdateOwnerAsync(ownerId, owner);
		}
	}
}
