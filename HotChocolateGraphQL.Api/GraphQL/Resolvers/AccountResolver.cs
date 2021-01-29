using HotChocolateGraphQL.Api.GraphQL.Resolvers.Contracts;
using HotChocolateGraphQL.Data.Models;
using HotChocolateGraphQL.Services.Contracts;

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

		public async Task<IEnumerable<Account>> AccountsAsync() => await _accountService.GetAccountsAsync();
	}
}
