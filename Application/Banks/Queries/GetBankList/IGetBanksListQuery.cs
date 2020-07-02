using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.Application.Banks.Queries.GetBankList
{
    public interface IGetBanksListQuery
    {
        List<BankModel> Execute();
    }
}
