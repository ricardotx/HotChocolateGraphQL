using HotChocolateGraphQL.Data.Models;

using System;
using System.ComponentModel.DataAnnotations;

namespace HotChocolateGraphQL.Api.GraphQL.Types
{
	public class AccountInput
	{
		public string Description { get; set; }

		public Guid OwnerId { get; set; }

		[Required]
		public TypeOfAccount Type { get; set; }
	}
}
