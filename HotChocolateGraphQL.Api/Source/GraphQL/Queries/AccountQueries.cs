using HotChocolate;
using HotChocolate.Types;

using HotChocolateGraphQL.Api.Source.Extensions;
using HotChocolateGraphQL.Core.Source.Entities;
using HotChocolateGraphQL.Data.Source.Context;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Queries
{
	[ExtendObjectType(Name = "Query")]
	public class AccountQueries
	{
		[UseDbContext]
		public async Task<Account> Account(
		   [ScopedService] StorageContext storageContext,
			//[ScopedService] IRepository repo,
			Guid accountId
		)
		{
			//return await repo.Accounts.GetByIdAsync(accountId);
			return await storageContext.Accounts
				.Where(x => x.Id == accountId)
				.FirstOrDefaultAsync();
		}

		[UseDbContext]
		public async Task<List<Account>> Accounts(
			[ScopedService] StorageContext storageContext
		)
		{
			return await storageContext.Accounts.ToListAsync();
		}
	}
}
