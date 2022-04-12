using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MerchantsDisbursments.Controllers
{
    [Route("api/v1/DisbursmentsPerMerchantAWeek")]
    [ApiController]
    public class DisbursmentsPerMerchantAWeekController : ControllerBase
    {
  
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //Get all merchant disbursements
            return new string[] { "Merchant1", "Disbursement1" };
        }

        [HttpGet("{merchantId, weekDate}")]
        public string Get(int merchantId, long weekDate)
        {
            //Read file and get the value
            return "value";
        }

    }
}
