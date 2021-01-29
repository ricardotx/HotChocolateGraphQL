using HotChocolateGraphQL.Data.Models;
using HotChocolateGraphQL.Data.Repository.Contracts;
using HotChocolateGraphQL.Services.Contracts;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Services
{
	public class AccountService : IAccountService
	{
		private readonly IAccountRepository _repo;

		public AccountService(IAccountRepository repo)
		{
			_repo = repo;
		}

		public async Task<IEnumerable<Account>> GetAccountsAsync() => await _repo.GetAllAsync();
	}
}
