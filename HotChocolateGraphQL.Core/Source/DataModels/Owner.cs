using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Converters;

using System;
using System.Collections.Generic;

namespace HotChocolateGraphQL.Core.Source.DataModels
{
	public class Owner : IConvertModel<Owner, OwnerApiModel>
	{
		public ICollection<Account> Accounts { get; set; }

		public string Address { get; set; }

		public Guid Id { get; set; }

		public string Name { get; set; }

		public OwnerApiModel Convert()
		{
			return new OwnerApiModel
			{
				Id = Id,
				Name = Name,
				Address = Address
			};
		}
	}
}
