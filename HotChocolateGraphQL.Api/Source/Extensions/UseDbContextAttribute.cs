using HotChocolate.Types;
using HotChocolate.Types.Descriptors;

using HotChocolateGraphQL.Data.Source.Context;

using System.Reflection;

namespace HotChocolateGraphQL.Api.Source.Extensions
{
	public class UseDbContextAttribute : ObjectFieldDescriptorAttribute
	{
		public override void OnConfigure(
			IDescriptorContext context,
			IObjectFieldDescriptor descriptor,
			MemberInfo member
		)
		{
			descriptor.UseDbContext<StorageContext>();
		}
	}
}
