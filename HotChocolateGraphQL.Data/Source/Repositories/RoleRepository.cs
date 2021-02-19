using HotChocolateGraphQL.Core.Source.Entities;
using HotChocolateGraphQL.Core.Source.Repositories;
using HotChocolateGraphQL.Data.Source.Context;

using System;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Data.Source.Repositories
{
	public class RoleRepository : BaseRepository<Role>, IRoleRepository
	{
		private readonly StorageContext db;

		public RoleRepository(StorageContext context) : base(context)
		{
			this.db = context;
		}

		public override async Task AddAsync(Role role)
		{
			role.Id = Guid.NewGuid();
			await this.db.Roles.AddAsync(role);
		}
	}
}
