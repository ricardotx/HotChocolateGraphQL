using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Resolvers;
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

		public async Task<OwnerApiModel> OwnerAsync(Guid ownerId)
		{
			return await this.ownerService.GetOwnerAsync(ownerId);
		}

		public async Task<OwnerApiModel> OwnerCreateAsync(OwnerApiModel data)
		{
			return await this.ownerService.CreateOwnerAsync(data);
		}

		public async Task<string> OwnerDeleteAsync(Guid ownerId)
		{
			return await this.ownerService.DeleteOwnerAsync(ownerId);
		}

		public async Task<IEnumerable<OwnerApiModel>> OwnersAsync()
		{
			return await this.ownerService.GetOwnersAsync();
		}

		public async Task<OwnerApiModel> OwnerUpdateAsync(Guid ownerId, OwnerApiModel data)
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
