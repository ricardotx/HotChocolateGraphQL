using HotChocolateGraphQL.Core.Source.Dtos;
using HotChocolateGraphQL.Core.Source.Converters;

using System;
using System.Collections.Generic;

namespace HotChocolateGraphQL.Core.Source.Entities
{
	public class Role : IConvertModel<Role, RoleDto>
	{
		public string Code { get; set; }

		public Guid Id { get; set; }

		public string Name { get; set; }

		public ICollection<User> Users { get; set; }

		public RoleDto Convert()
		{
			return new RoleDto
			{
				Id = Id,
				Name = Name,
				Code = Code
			};
		}
	}
}
