using HotChocolate;

using HotChocolateGraphQL.Data.Context;
using HotChocolateGraphQL.Data.Models;

using System.Linq;

namespace HotChocolateGraphQL.Api.GraphQL.Queries
{
	public class RootQuery
	{
		public IQueryable<Account> GetAccounts([Service] ApplicationContext context) => context.Accounts;

		public IQueryable<Owner> GetOwners([Service] ApplicationContext context) => context.Owners;
	}
}
