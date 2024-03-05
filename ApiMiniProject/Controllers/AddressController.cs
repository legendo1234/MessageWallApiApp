using ApiMiniProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        
            private ILogger<AddressController> _logger;

            public AddressController(ILogger<AddressController> logger)
            {
                _logger = logger;
            }

            // POST api/Address
            [HttpPost]
            public void Post([FromBody] AddressModel data)
            {
                _logger.LogInformation("The person was logged as {Address}", data);
            }
        

    }
}
