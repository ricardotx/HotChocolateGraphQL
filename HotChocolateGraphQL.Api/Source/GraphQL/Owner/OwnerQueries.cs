using HotChocolate;
using HotChocolate.Types;

using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Owner
{
	[ExtendObjectType(Name = "Query")]
	public class OwnerQueries
	{
		public async Task<OwnerApiModel> Owner(
			[Service] IOwnerService ownerService,
			Guid ownerId
		)
		{
			return await ownerService.GetOwnerAsync(ownerId);
		}

		public async Task<IEnumerable<OwnerApiModel>> Owners([Service] IOwnerService ownerService)
		{
			return await ownerService.GetOwnersAsync();
		}
	}
}
