using HotChocolate.Types;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotChocolateGraphQL.Api.Source.Extensions
{
	public static class UseDbContextObjectFieldDescriptorExtensions
	{
		public static IObjectFieldDescriptor UseDbContext<TDbContext>(
			this IObjectFieldDescriptor descriptor)
			where TDbContext : DbContext
		{
			return descriptor.UseScopedService<TDbContext>(
				create: s => s.GetRequiredService<IDbContextFactory<TDbContext>>().CreateDbContext(),
				disposeAsync: (s, c) => c.DisposeAsync());
		}
	}
}
