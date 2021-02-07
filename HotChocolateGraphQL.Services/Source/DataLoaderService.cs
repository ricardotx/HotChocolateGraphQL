using HotChocolateGraphQL.Core.Source;
using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Extensions;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Services.Source
{
	public class DataLoaderService : IDataLoaderService
	{
		private readonly IRepository repo;

		public DataLoaderService(IRepository repo)
		{
			this.repo = repo;
		}

		public async Task<ILookup<Guid, AccountApiModel>> AccountsByOwnerIdsAsync(IEnumerable<Guid> ownerIds)
		{
			var dataModels = await this.repo.Accounts.FindAllAsync(x => ownerIds.Contains(x.OwnerId));
			return dataModels.ConvertAll().ToLookup(x => x.OwnerId);
		}

		public async Task<IDictionary<Guid, OwnerApiModel>> OwnersByIdAsync(IEnumerable<Guid> ownerIds)
		{
			var dataModels = await this.repo.Owners.FindAllAsync(x => ownerIds.Contains(x.Id));
			return dataModels.ConvertAll().ToDictionary(x => x.Id);
		}
	}
}
