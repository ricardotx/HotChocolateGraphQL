using HotChocolateGraphQL.Core.Source;
using HotChocolateGraphQL.Core.Source.Repositories;
using HotChocolateGraphQL.Data.Source;
using HotChocolateGraphQL.Data.Source.Repositories;

using Microsoft.Extensions.DependencyInjection;

namespace HotChocolateGraphQL.Api.Source.Configurations
{
	public static class RepositoryConfiguration
	{
		public static void ConfigureRepositories(this IServiceCollection services)
		{
			services.AddScoped<IRepository, Repository>();
			services.AddScoped<IAccountRepository, AccountRepository>();
			services.AddScoped<IOwnerRepository, OwnerRepository>();
			services.AddScoped<IRoleRepository, RoleRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
		}
	}
}
