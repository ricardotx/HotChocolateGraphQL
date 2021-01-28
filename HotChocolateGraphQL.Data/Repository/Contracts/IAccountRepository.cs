﻿using HotChocolateGraphQL.Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotChocolateGraphQL.Data.Repository.Contracts
{
    public interface IAccountRepository
    {
        Account CreateAccount(Account account);

        Task<ILookup<Guid, Account>> DataLoaderAccountsByOwnerIdsAsync(IEnumerable<Guid> ownerIds);

        void DeleteAccount(Account account);

        IEnumerable<Account> GetAll();

        IEnumerable<Account> GetAllAccountsPerOwner(Guid ownerId);

        Account GetById(Guid id);

        Account UpdateAccount(Account dbAccount, Account account);
    }
}
