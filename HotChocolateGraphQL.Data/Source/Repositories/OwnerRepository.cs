using HotChocolateGraphQL.Core.Source.Entities;
using HotChocolateGraphQL.Core.Source.Repositories;
using HotChocolateGraphQL.Data.Source.Context;

using System;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Data.Source.Repositories
{
	public class OwnerRepository : BaseRepository<Owner>, IOwnerRepository
	{
		private readonly StorageContext db;

		public OwnerRepository(StorageContext context) : base(context)
		{
			this.db = context;
		}

		public override async Task AddAsync(Owner owner)
		{
			owner.Id = Guid.NewGuid();
			await this.db.Owners.AddAsync(owner);
		}
	}
}
