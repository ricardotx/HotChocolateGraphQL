using System.ComponentModel.DataAnnotations;

namespace HotChocolateGraphQL.Api.GraphQL.Types
{
	public class OwnerInput
	{
		public string Address { get; set; }

		[Required]
		public string Name { get; set; }
	}
}
