using GreenDonut;

using HotChocolate.DataLoader;

using HotChocolateGraphQL.Core.Source.Entities;
using HotChocolateGraphQL.Data.Source.Context;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL.DataLoaders
{
	public class AccountsByIdDataLoader : BatchDataLoader<Guid, Account>
	{
		private readonly IDbContextFactory<StorageContext> storageContext;

		public AccountsByIdDataLoader(
			IBatchScheduler batchScheduler,
			IDbContextFactory<StorageContext> storageContext
		) : base(batchScheduler)
		{
			this.storageContext = storageContext ?? throw new ArgumentNullException(nameof(storageContext));
		}

		protected override async Task<IReadOnlyDictionary<Guid, Account>> LoadBatchAsync(
		   IReadOnlyList<Guid> keys,
		   CancellationToken cancellationToken
		)
		{
			await using StorageContext dbContext = this.storageContext.CreateDbContext();

			return await dbContext.Accounts
				.Where(x => keys.Contains(x.Id))
				.ToDictionaryAsync(x => x.Id, cancellationToken);
		}
	}
}
