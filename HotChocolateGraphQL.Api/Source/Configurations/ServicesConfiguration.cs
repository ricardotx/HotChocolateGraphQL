using HotChocolateGraphQL.Core.Source.Services;
using HotChocolateGraphQL.Services.Source;

using Microsoft.Extensions.DependencyInjection;

namespace HotChocolateGraphQL.Api.Source.Configurations
{
	public static class ServicesConfiguration
	{
		public static void ConfigureServices(this IServiceCollection services)
		{
			services
				.AddScoped<IOwnerService, OwnerService>()
				.AddScoped<IAccountService, AccountService>()
				.AddScoped<IDataLoaderService, DataLoaderService>()
				.AddScoped<IRoleService, RoleService>()
				.AddScoped<IUserService, UserService>();
		}
	}
}
