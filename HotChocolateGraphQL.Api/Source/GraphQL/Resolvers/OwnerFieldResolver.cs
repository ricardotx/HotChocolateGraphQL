using HotChocolate;

using HotChocolateGraphQL.Api.Source.GraphQL.DataLoaders;
using HotChocolateGraphQL.Core.Source.Entities;
using HotChocolateGraphQL.Data.Source.Context;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Resolvers
{
	public class OwnerFieldResolver
	{
		public async Task<IEnumerable<Account>> AccountsAsync(
		   [Parent] Owner owner,
		   [ScopedService] StorageContext dbContext,
		   AccountsByIdDataLoader dataLoader,
		   CancellationToken cancellationToken
		)
		{
			Guid[] accountIds = await dbContext.Owners
				.Where(x => x.Id == owner.Id)
				.Include(x => x.Accounts)
				.SelectMany(x => x.Accounts.Select(a => a.Id))
				.ToArrayAsync();

			return await dataLoader.LoadAsync(accountIds, cancellationToken);
		}
	}
}
