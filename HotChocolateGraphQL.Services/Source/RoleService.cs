using HotChocolateGraphQL.Core.Source;
using HotChocolateGraphQL.Core.Source.Dtos;
using HotChocolateGraphQL.Core.Source.Extensions;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Services.Source
{
	public class RoleService : IRoleService
	{
		private readonly IRepository repo;

		public RoleService(IRepository repo)
		{
			this.repo = repo;
		}

		public async Task<RoleDto> CreateAsync(RoleDto role)
		{
			var dataModel = role.Convert();
			await this.repo.Roles.AddAsync(dataModel);
			await this.repo.SaveChangesAsync();
			return dataModel.Convert();
		}

		public async Task<bool> DeleteAsync(Guid[] roleIds)
		{
			for (int i = 0; i < roleIds.Length; i++)
			{
				await DeleteAsync(roleIds[i]);
			}

			return true;
		}

		public async Task<string> DeleteAsync(Guid roleId)
		{
			var dataModel = await this.repo.Roles.GetByIdAsync(roleId);
			this.repo.Roles.Remove(dataModel);
			await this.repo.SaveChangesAsync();
			return $"The role with the id: '{roleId}' has been successfully deleted from db.";
		}

		public async Task<IEnumerable<RoleDto>> GetAllAsync()
		{
			var dataModels = await this.repo.Roles.GetAllAsync();
			return dataModels.ConvertAll();
		}

		public async Task<RoleDto> GetByIdAsync(Guid roleId)
		{
			var dataModel = await this.repo.Roles.GetByIdAsync(roleId);
			return dataModel.Convert();
		}

		public async Task<RoleDto> UpdateAsync(RoleDto role)
		{
			var dataModel = await this.repo.Roles.GetByIdAsync(role.Id);
			dataModel.Name = role.Name;
			dataModel.Code = role.Code;
			await this.repo.SaveChangesAsync();
			return dataModel.Convert();
		}
	}
}
