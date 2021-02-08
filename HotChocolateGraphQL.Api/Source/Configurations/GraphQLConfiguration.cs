using HotChocolateGraphQL.Api.Source.GraphQL;
using HotChocolateGraphQL.Api.Source.GraphQL.Resolvers;
using HotChocolateGraphQL.Core.Source.Resolvers;

using Microsoft.Extensions.DependencyInjection;

namespace HotChocolateGraphQL.Api.Source.Configurations
{
	public static class GraphQLConfiguration
	{
		public static void ConfigureGraphQL(this IServiceCollection services)
		{
			services
				.AddGraphQLServer()
				.AddQueryType<Query>()
				.AddMutationType<Mutation>();
			//.AddType<AccountInput>()
			//.AddType<OwnerInput>();

			//services
			//	.AddGraphQLServer()
			//		.AddQueryType(d => d.Name("Query"))
			//		.AddType<AccountQueries>()
			//		.AddType<OwnerQueries>()
			//	.AddMutationType(d => d.Name("Mutation"))
			//		.AddType<AccountMutations>()
			//		.AddType<OwnerMutations>()
			//	.AddType<AccountInput>()
			//	.AddType<OwnerInput>();
		}

		public static void ConfigureGraphQLResolvers(this IServiceCollection services)
		{
			services
				.AddScoped<IOwnerResolver, OwnerResolver>()
				.AddScoped<IAccountResolver, AccountResolver>();
		}
	}
}
