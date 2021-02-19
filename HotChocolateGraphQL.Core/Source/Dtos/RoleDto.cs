using HotChocolateGraphQL.Core.Source.Converters;
using HotChocolateGraphQL.Core.Source.Entities;

using System;
using System.Collections.Generic;

namespace HotChocolateGraphQL.Core.Source.Dtos
{
	public class RoleDto : IConvertModel<RoleDto, Role>
	{
		public string Code { get; set; }

		public Guid Id { get; set; }

		public string Name { get; set; }

		public ICollection<UserDto> Users { get; set; }

		public Role Convert()
		{
			return new Role
			{
				Id = Id,
				Name = Name,
				Code = Code
			};
		}
	}
}
