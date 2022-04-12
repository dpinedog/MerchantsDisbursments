using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MerchantsDisbursments.Controllers
{
    [Route("api/v1/UpdateDisbursmentsPerMerchant")]
    [ApiController]
    public class UpdateDisbursmentsPerMerchantController : ControllerBase
    {
        //It should be a put request as is upgrading data on server
        [HttpGet]
        public string Get()
        {
            string result = "Upgrading data in server...";
           
            Thread thread1 = new Thread(UpgradeDisburmentsPerMerchant.UpgradeDisburments);
            thread1.Start();
            

            return result;
        }

    }
}
