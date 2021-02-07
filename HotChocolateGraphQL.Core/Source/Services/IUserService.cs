using HotChocolateGraphQL.Core.Source.ApiModels;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Core.Source.Services
{
	public interface IUserService
	{
		// <summary>
		/// Create new user async
		/// </summary>
		Task<UserApiModel> CreateAsync(UserApiModel user);

		/// <summary>
		/// Delete multiple users
		/// </summary>
		Task<bool> DeleteAsync(Guid[] userIds);

		/// <summary>
		/// Delete one user
		/// </summary>
		Task<string> DeleteAsync(Guid userId);

		/// <summary>
		/// Get all users
		/// </summary>
		Task<IEnumerable<UserApiModel>> GetAllAsync();

		/// <summary>
		/// Get user by email
		/// </summary>
		Task<UserApiModel> GetByEmailAsync(string email);

		/// <summary>
		/// Get user by id
		/// </summary>
		Task<UserApiModel> GetByIdAsync(Guid userId);

		/// <summary>
		/// Update user
		/// </summary>
		Task<UserApiModel> UpdateAsync(UserApiModel user);
	}
}
