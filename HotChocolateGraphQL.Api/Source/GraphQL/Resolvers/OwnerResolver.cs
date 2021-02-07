using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.GraphQL.Resolvers;
using HotChocolateGraphQL.Core.Source.GraphQL.Types;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Resolvers
{
	public class OwnerResolver : IOwnerResolver
	{
		private readonly IOwnerService ownerService;

		public OwnerResolver(IOwnerService ownerService)
		{
			this.ownerService = ownerService;
		}

		public async Task<OwnerApiModel> OwnerAsync(Guid ownerId) => await this.ownerService.GetOwnerAsync(ownerId);

		public async Task<OwnerApiModel> OwnerCreateAsync(OwnerInput data)
		{
			var owner = new OwnerApiModel
			{
				Name = data.Name,
				Address = data.Address
			};

			return await this.ownerService.CreateOwnerAsync(owner);
		}

		public async Task<string> OwnerDeleteAsync(Guid ownerId) => await this.ownerService.DeleteOwnerAsync(ownerId);

		public async Task<IEnumerable<OwnerApiModel>> OwnersAsync() => await this.ownerService.GetOwnersAsync();

		public async Task<OwnerApiModel> OwnerUpdateAsync(Guid ownerId, OwnerInput data)
		{
			var owner = new OwnerApiModel
			{
				Name = data.Name,
				Address = data.Address
			};

			return await this.ownerService.UpdateOwnerAsync(ownerId, owner);
		}
	}
}
