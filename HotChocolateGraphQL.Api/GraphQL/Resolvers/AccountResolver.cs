using HotChocolateGraphQL.Api.GraphQL.Resolvers.Contracts;
using HotChocolateGraphQL.Api.GraphQL.Types;
using HotChocolateGraphQL.Data.Models;
using HotChocolateGraphQL.Services.Contracts;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.GraphQL.Resolvers
{
	public class AccountResolver : IAccountResolver
	{
		private readonly IAccountService _accountService;

		public AccountResolver(IAccountService accountService)
		{
			_accountService = accountService;
		}

		public async Task<Account> AccountAsync(Guid accountId) => await _accountService.GetAccountAsync(accountId);

		public async Task<Account> AccountCreateAsync(AccountInput data)
		{
			var account = new Account
			{
				Type = data.Type,
				Description = data.Description,
				OwnerId = data.OwnerId,
			};

			return await _accountService.CreateAccountAsync(account);
		}

		public async Task<string> AccountDeleteAsync(Guid accountId) => await _accountService.DeleteAccountAsync(accountId);

		public async Task<IEnumerable<Account>> AccountsAsync() => await _accountService.GetAccountsAsync();

		public async Task<Account> AccountUpdateAsync(Guid accountId, AccountInput data)
		{
			var account = new Account
			{
				Type = data.Type,
				Description = data.Description,
				OwnerId = data.OwnerId,
			};

			return await _accountService.UpdateAccountAsync(accountId, account);
		}
	}
}
