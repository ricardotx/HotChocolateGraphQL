using HotChocolateGraphQL.Data.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Services.Contracts
{
	public interface IAccountService
	{
		Task<IEnumerable<Account>> GetAccountsAsync();
	}
}
