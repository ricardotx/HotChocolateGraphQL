using HotChocolate;
using HotChocolate.Types;

using HotChocolateGraphQL.Api.Source.Extensions;
using HotChocolateGraphQL.Api.Source.GraphQL.Owner.Types;
using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Owner
{
	[ExtendObjectType(Name = "Mutation")]
	public class OwnerMutations
	{
		public async Task<OwnerApiModel> OwnerCreate(
			[Service] IOwnerService ownerService,
			OwnerInputType data
		)
		{
			var apiModel = data.ConvertFromGQL();
			return await ownerService.CreateOwnerAsync(apiModel);
		}

		public async Task<string> OwnerDelete(
			[Service] IOwnerService ownerService,
			Guid ownerId
		)
		{
			return await ownerService.DeleteOwnerAsync(ownerId);
		}

		public async Task<OwnerApiModel> OwnerUpdate(
			[Service] IOwnerService ownerService,
			OwnerInputType data,
			Guid ownerId
		)
		{
			var apiModel = data.ConvertFromGQL();
			return await ownerService.UpdateOwnerAsync(ownerId, apiModel);
		}
	}
}
