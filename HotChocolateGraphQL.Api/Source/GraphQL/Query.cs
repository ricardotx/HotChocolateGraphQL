using HotChocolate;

using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL
{
	public class Query
	{
		public async Task<AccountApiModel> Account([Service] IAccountService accountService, Guid accountId)
		{
			return await accountService.GetAccountAsync(accountId);
		}

		public async Task<IEnumerable<AccountApiModel>> Accounts([Service] IAccountService accountService)
		{
			return await accountService.GetAccountsAsync();
		}

		public async Task<OwnerApiModel> Owner([Service] IOwnerService ownerService, Guid ownerId)
		{
			return await ownerService.GetOwnerAsync(ownerId);
		}

		public async Task<IEnumerable<OwnerApiModel>> Owners([Service] IOwnerService ownerService)
		{
			return await ownerService.GetOwnersAsync();
		}
	}
}
