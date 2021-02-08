using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Resolvers;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Resolvers
{
	public class AccountResolver : IAccountResolver
	{
		private readonly IAccountService accountService;

		public AccountResolver(IAccountService accountService)
		{
			this.accountService = accountService;
		}

		public async Task<AccountApiModel> AccountAsync(Guid accountId)
		{
			return await this.accountService.GetAccountAsync(accountId); ;
		}

		public async Task<AccountApiModel> AccountCreateAsync(AccountApiModel data)
		{
			return await this.accountService.CreateAccountAsync(data);
		}

		public async Task<string> AccountDeleteAsync(Guid accountId)
		{
			return await this.accountService.DeleteAccountAsync(accountId);
		}

		public async Task<IEnumerable<AccountApiModel>> AccountsAsync()
		{
			return await this.accountService.GetAccountsAsync();
		}

		public async Task<AccountApiModel> AccountUpdateAsync(Guid accountId, AccountApiModel data)
		{
			return await this.accountService.UpdateAccountAsync(accountId, data);
		}
	}
}
