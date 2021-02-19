using HotChocolate.Types;

using HotChocolateGraphQL.Api.Source.GraphQL.DataLoaders;
using HotChocolateGraphQL.Api.Source.GraphQL.Queries;
using HotChocolateGraphQL.Api.Source.GraphQL.Types;

using Microsoft.Extensions.DependencyInjection;

namespace HotChocolateGraphQL.Api.Source.Configurations
{
	public static class GraphQLConfiguration
	{
		public static void ConfigureGraphQL(this IServiceCollection services)
		{
			services
			   .AddGraphQLServer()
			   .AddType(new UuidType(defaultFormat: 'D')) // https://github.com/ChilliCream/hotchocolate/pull/1301
			   .AddQueryType(d => d.Name("Query"))
				   .AddTypeExtension<AccountQueries>()
				   .AddTypeExtension<OwnerQueries>()
			   //.AddMutationType(d => d.Name("Mutation"))
			   //.AddTypeExtension<AccountMutations>()
			   //.AddTypeExtension<OwnerMutations>()
			   .AddType<AccountType>()
			   .AddType<AccountTypeEnumType>()
			   .AddType<OwnerType>()
			   .AddDataLoader<OwnersByIdDataLoader>()
			   .AddDataLoader<AccountsByIdDataLoader>();
			//.AddType<AccountInputType>()
			//.AddType<OwnerInputType>()
		}
	}
}
