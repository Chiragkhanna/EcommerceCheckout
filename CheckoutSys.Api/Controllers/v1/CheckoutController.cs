using CheckoutSys.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CheckoutSys.Api.Controllers.v1
{
    public class CheckoutController : BaseApiController<CheckoutController>
    {

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(List<string> productNames)
        {
            return Ok();
        }

    }
}