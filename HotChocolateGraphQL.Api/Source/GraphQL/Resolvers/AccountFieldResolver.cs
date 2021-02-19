using HotChocolate;

using HotChocolateGraphQL.Api.Source.GraphQL.DataLoaders;
using HotChocolateGraphQL.Core.Source.Entities;

using System.Threading;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Resolvers
{
	public class AccountFieldResolver
	{
		public async Task<Owner> OwnerAsync(
			[Parent] Account account,
			OwnersByIdDataLoader dataLoader,
			CancellationToken cancellationToken
		)
		{
			return await dataLoader.LoadAsync(account.OwnerId, cancellationToken);
		}
	}
}
