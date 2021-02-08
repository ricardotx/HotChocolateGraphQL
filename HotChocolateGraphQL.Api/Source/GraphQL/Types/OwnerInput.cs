using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Converters;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Types
{
	public class OwnerInput : IConvertGQLType<OwnerInput, OwnerApiModel>
	{
		public string Address { get; set; }

		public string Name { get; set; }

		public OwnerInput ConvertFromApiModel(OwnerApiModel apiModel)
		{
			return new OwnerInput
			{
				Name = apiModel.Name,
				Address = apiModel.Address
			};
		}

		public OwnerApiModel ConvertFromGQL()
		{
			return new OwnerApiModel
			{
				Name = Name,
				Address = Address
			};
		}
	}
}
