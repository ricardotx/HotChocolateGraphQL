using HotChocolateGraphQL.Data.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.GraphQL.Resolvers.Contracts
{
	public interface IAccountResolver
	{
		Task<IEnumerable<Account>> AccountsAsync();
	}
}
