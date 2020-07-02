using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insurance.Application.Banks.Queries.GetBankList;

namespace Insurance.InsuranceServices.Controllers
{

    [ApiController]
    [Route("/api/Bank")]
    public class BankController : Controller
    {
        private readonly IGetBanksListQuery _query;

        public BankController(IGetBanksListQuery query)
        {
            _query = query;
        }
        [HttpGet]
        public IEnumerable<BankModel> Get()
        {
            return _query.Execute();
        }
    }
}
