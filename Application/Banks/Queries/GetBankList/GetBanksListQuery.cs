using Insurance.Application.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Insurance.Application.Banks.Queries.GetBankList
{
    public class GetBanksListQuery
        : IGetBanksListQuery
    {
        private readonly IDatabaseService _database;

        public GetBanksListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<BankModel> Execute()
        {
            var banks = _database.Bank
                .Select(p => new BankModel()
                {
                    Id = p.Id,
                    Bankname = p.Bankname
                });

            return banks.ToList();
        }
    }
}
