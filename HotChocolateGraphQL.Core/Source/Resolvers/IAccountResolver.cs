using HotChocolateGraphQL.Core.Source.ApiModels;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Core.Source.Resolvers
{
	public interface IAccountResolver
	{
		Task<AccountApiModel> AccountAsync(Guid accountId);

		Task<AccountApiModel> AccountCreateAsync(AccountApiModel data);

		Task<string> AccountDeleteAsync(Guid accountId);

		Task<IEnumerable<AccountApiModel>> AccountsAsync();

		Task<AccountApiModel> AccountUpdateAsync(Guid accountId, AccountApiModel data);
	}
}
