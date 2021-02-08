namespace HotChocolateGraphQL.Core.Source.Converters
{
	public interface IConvertGQLType<TSource, TTarget>
	{
		/// <summary>
		/// Convert a ApiModel into GrapQL type
		/// </summary>
		TSource ConvertFromApiModel(TTarget apiModel);

		/// <summary>
		/// Convert a GrapQL type into ApiModel and backwards
		/// </summary>
		TTarget ConvertFromGQL();
	}
}
