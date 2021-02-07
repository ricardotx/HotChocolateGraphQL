using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.GraphQL.Resolvers;
using HotChocolateGraphQL.Core.Source.GraphQL.Types;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.GraphQL.Source.Resolvers
{
	public class AccountResolver : IAccountResolver
	{
		private readonly IAccountService accountService;

		public AccountResolver(IAccountService accountService)
		{
			this.accountService = accountService;
		}

		public async Task<AccountApiModel> AccountAsync(Guid accountId) => await this.accountService.GetAccountAsync(accountId);

		public async Task<AccountApiModel> AccountCreateAsync(AccountInput data)
		{
			var account = new AccountApiModel
			{
				Type = data.Type,
				Description = data.Description,
				OwnerId = data.OwnerId,
			};

			return await this.accountService.CreateAccountAsync(account);
		}

		public async Task<string> AccountDeleteAsync(Guid accountId) => await this.accountService.DeleteAccountAsync(accountId);

		public async Task<IEnumerable<AccountApiModel>> AccountsAsync() => await this.accountService.GetAccountsAsync();

		public async Task<AccountApiModel> AccountUpdateAsync(Guid accountId, AccountInput data)
		{
			var account = new AccountApiModel
			{
				Type = data.Type,
				Description = data.Description,
				OwnerId = data.OwnerId,
			};

			return await this.accountService.UpdateAccountAsync(accountId, account);
		}
	}
}
