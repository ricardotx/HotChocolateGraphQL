using HotChocolate;
using HotChocolate.Types;

using HotChocolateGraphQL.Api.Source.Extensions;
using HotChocolateGraphQL.Api.Source.GraphQL.Account.Types;
using HotChocolateGraphQL.Core.Source.ApiModels;
using HotChocolateGraphQL.Core.Source.Services;

using System;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Api.Source.GraphQL.Account
{
	[ExtendObjectType(Name = "Mutation")]
	public class AccountMutations
	{
		public async Task<AccountApiModel> AccountCreate(
			[Service] IAccountService accountService,
			AccountInputType data
		)
		{
			var apiModel = data.ConvertFromGQL();
			return await accountService.CreateAccountAsync(apiModel);
		}

		public async Task<string> AccountDelete(
			[Service] IAccountService accountService,
			Guid accountId
		)
		{
			return await accountService.DeleteAccountAsync(accountId);
		}

		public async Task<AccountApiModel> AccountUpdate(
			[Service] IAccountService accountService,
			AccountInputType data, Guid accountId
		)
		{
			var apiModel = data.ConvertFromGQL();
			return await accountService.UpdateAccountAsync(accountId, apiModel);
		}
	}
}
