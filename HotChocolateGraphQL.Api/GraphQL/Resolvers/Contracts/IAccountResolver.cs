using HotChocolateGraphQL.Api.GraphQL.Types;
using HotChocolateGraphQL.Data.Models;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.GraphQL.Resolvers.Contracts
{
	public interface IAccountResolver
	{
		Task<Account> AccountAsync(Guid accountId);

		Task<Account> AccountCreateAsync(AccountInput data);

		Task<string> AccountDeleteAsync(Guid accountId);

		Task<IEnumerable<Account>> AccountsAsync();

		Task<Account> AccountUpdateAsync(Guid accountId, AccountInput data);
	}
}
