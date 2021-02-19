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
	public class OwnerQueries
	{
		[UseDbContext]
		public async Task<Owner> Owner(
			[ScopedService] StorageContext storageContext,
			Guid ownerId
		)
		{
			return await storageContext.Owners
			   .Where(x => x.Id == ownerId)
			   .FirstOrDefaultAsync();
		}

		[UseDbContext]
		public async Task<List<Owner>> Owners(
		   [ScopedService] StorageContext storageContext
		)
		{
			return await storageContext.Owners.ToListAsync();
		}
	}
}
