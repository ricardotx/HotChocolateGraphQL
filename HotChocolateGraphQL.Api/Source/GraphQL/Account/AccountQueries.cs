using HotChocolate;
using HotChocolate.Types;

using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Account
{
	[ExtendObjectType(Name = "Query")]
	public class AccountQueries
	{
		public async Task<AccountApiModel> Account(
			[Service] IAccountService accountService,
			Guid accountId
		)
		{
			return await accountService.GetAccountAsync(accountId);
		}

		public async Task<IEnumerable<AccountApiModel>> Accounts([Service] IAccountService accountService)
		{
			return await accountService.GetAccountsAsync();
		}
	}
}
