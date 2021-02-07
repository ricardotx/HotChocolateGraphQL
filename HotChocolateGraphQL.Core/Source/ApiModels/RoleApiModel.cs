using HotChocolateGraphQL.Core.Source.Converters;
using HotChocolateGraphQL.Core.Source.DataModels;

using System;
using System.Collections.Generic;

namespace HotChocolateGraphQL.Core.Source.ApiModels
{
	public class RoleApiModel : IConvertModel<RoleApiModel, Role>
	{
		public string Code { get; set; }

		public Guid Id { get; set; }

		public string Name { get; set; }

		public ICollection<UserApiModel> Users { get; set; }

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
