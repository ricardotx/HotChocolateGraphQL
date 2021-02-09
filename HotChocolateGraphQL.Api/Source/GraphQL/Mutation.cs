using HotChocolate;

using HotChocolateGraphQL.Api.Source.GraphQL.Types;
using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL
{
	public class Mutation
	{
		public async Task<AccountApiModel> AccountCreate([Service] IAccountService accountService, AccountInput data)
		{
			var apiModel = data.ConvertFromGQL();
			return await accountService.CreateAccountAsync(apiModel);
		}

		public async Task<string> AccountDelete([Service] IAccountService accountService, Guid accountId)
		{
			return await accountService.DeleteAccountAsync(accountId);
		}

		public async Task<AccountApiModel> AccountUpdate([Service] IAccountService accountService, AccountInput data, Guid accountId)
		{
			var apiModel = data.ConvertFromGQL();
			return await accountService.UpdateAccountAsync(accountId, apiModel);
		}

		public async Task<OwnerApiModel> OwnerCreate([Service] IOwnerService ownerService, OwnerInput data)
		{
			var apiModel = data.ConvertFromGQL();
			return await ownerService.CreateOwnerAsync(apiModel);
		}

		public async Task<string> OwnerDelete([Service] IOwnerService ownerService, Guid ownerId)
		{
			return await ownerService.DeleteOwnerAsync(ownerId);
		}

		public async Task<OwnerApiModel> OwnerUpdate([Service] IOwnerService ownerService, OwnerInput data, Guid ownerId)
		{
			var apiModel = data.ConvertFromGQL();
			return await ownerService.UpdateOwnerAsync(ownerId, apiModel);
		}
	}
}
