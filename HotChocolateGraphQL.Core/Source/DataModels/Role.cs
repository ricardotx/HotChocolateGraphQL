using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Converters;

using System;
using System.Collections.Generic;

namespace HotChocolateGraphQL.Core.Source.DataModels
{
	public class Role : IConvertModel<Role, RoleApiModel>
	{
		public string Code { get; set; }

		public Guid Id { get; set; }

		public string Name { get; set; }

		public ICollection<User> Users { get; set; }

		public RoleApiModel Convert()
		{
			return new RoleApiModel
			{
				Id = Id,
				Name = Name,
				Code = Code
			};
		}
	}
}
