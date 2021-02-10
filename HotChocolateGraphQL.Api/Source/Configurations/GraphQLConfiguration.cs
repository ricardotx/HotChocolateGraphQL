using HotChocolateGraphQL.Api.Source.GraphQL.Account;
using HotChocolateGraphQL.Api.Source.GraphQL.Account.Types;
using HotChocolateGraphQL.Api.Source.GraphQL.Owner;
using HotChocolateGraphQL.Api.Source.GraphQL.Owner.Types;

using Microsoft.Extensions.DependencyInjection;

namespace HotChocolateGraphQL.Api.Source.Configurations
{
	public static class GraphQLConfiguration
	{
		public static void ConfigureGraphQL(this IServiceCollection services)
		{
			services
				.AddGraphQLServer()
				.AddQueryType(d => d.Name("Query"))
					.AddTypeExtension<AccountQueries>()
					.AddTypeExtension<OwnerQueries>()
				.AddMutationType(d => d.Name("Mutation"))
					.AddTypeExtension<AccountMutations>()
					.AddTypeExtension<OwnerMutations>()
				.AddType<AccountInputType>()
				.AddType<OwnerInputType>();
		}
	}
}
