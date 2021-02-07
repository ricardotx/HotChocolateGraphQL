using HotChocolateGraphQL.Core.Source.Repositories;

using System;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Core.Source
{
	public interface IRepository : IDisposable
	{
		IAccountRepository Accounts { get; }
		IOwnerRepository Owners { get; }
		IRoleRepository Roles { get; }
		IUserRepository Users { get; }

		/// <summary>
		/// Save all changes made to the database
		/// </summary>
		Task<int> SaveChangesAsync();
	}
}
