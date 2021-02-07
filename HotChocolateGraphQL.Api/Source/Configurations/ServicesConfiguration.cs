using HotChocolateGraphQL.Api.GraphQL.Source.Resolvers;
using HotChocolateGraphQL.Api.Source.GraphQL;
using HotChocolateGraphQL.Api.Source.GraphQL.Resolvers;
using HotChocolateGraphQL.Core.Source;
using HotChocolateGraphQL.Core.Source.GraphQL.Resolvers;
using HotChocolateGraphQL.Core.Source.Repositories;
using HotChocolateGraphQL.Core.Source.Services;
using HotChocolateGraphQL.Data.Source;
using HotChocolateGraphQL.Data.Source.Context;
using HotChocolateGraphQL.Data.Source.Repositories;
using HotChocolateGraphQL.Services.Source;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotChocolateGraphQL.Api.Source.Configurations
{
	public static class ServicesConfiguration
	{
		// Database
		public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
		{
			string connectionStr = configuration.GetConnectionString("mysqlConString");
			services
				.AddDbContext<StorageContext>(opt => opt.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr)));
		}

		// Graphql
		public static void ConfigureGraphQL(this IServiceCollection services)
		{
			services
				.AddGraphQLServer()
				.AddQueryType<Query>()
				.AddMutationType<Mutation>();
		}

		// Grapqhl Resolvers
		public static void ConfigureGraphQLResolvers(this IServiceCollection services)
		{
			services
				.AddScoped<IOwnerResolver, OwnerResolver>()
				.AddScoped<IAccountResolver, AccountResolver>();
		}

		// Repository
		public static void ConfigureRepositories(this IServiceCollection services)
		{
			services
				.AddScoped<IRepository, Repository>()
				.AddScoped<IAccountRepository, AccountRepository>()
				.AddScoped<IOwnerRepository, OwnerRepository>()
				.AddScoped<IRoleRepository, RoleRepository>()
				.AddScoped<IUserRepository, UserRepository>();
		}

		// Services
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
