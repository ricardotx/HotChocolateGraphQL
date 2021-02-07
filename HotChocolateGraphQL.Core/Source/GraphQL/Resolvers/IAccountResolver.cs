using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.GraphQL.Types;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Core.Source.GraphQL.Resolvers
{
	public interface IAccountResolver
	{
		Task<AccountApiModel> AccountAsync(Guid accountId);

		Task<AccountApiModel> AccountCreateAsync(AccountInput data);

		Task<string> AccountDeleteAsync(Guid accountId);

		Task<IEnumerable<AccountApiModel>> AccountsAsync();

		Task<AccountApiModel> AccountUpdateAsync(Guid accountId, AccountInput data);
	}
}
