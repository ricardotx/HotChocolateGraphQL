using HotChocolateGraphQL.Api.Source.GraphQL;

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
	}
}
