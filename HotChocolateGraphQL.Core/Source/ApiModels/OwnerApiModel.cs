using HotChocolateGraphQL.Core.Source.Converters;
using HotChocolateGraphQL.Core.Source.DataModels;

using System;
using System.Collections.Generic;

namespace HotChocolateGraphQL.Core.Source.ApiModels
{
	public class OwnerApiModel : IConvertModel<OwnerApiModel, Owner>
	{
		public ICollection<AccountApiModel> Accounts { get; set; }

		public string Address { get; set; }

		public Guid Id { get; set; }

		public string Name { get; set; }

		public Owner Convert()
		{
			return new Owner
			{
				Id = Id,
				Name = Name,
				Address = Address
			};
		}
	}
}
