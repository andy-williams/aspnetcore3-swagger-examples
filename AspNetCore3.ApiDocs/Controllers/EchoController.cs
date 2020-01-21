using System.Net;
using AspNetCore3.ApiDocs.Requests;
using AspNetCore3.ApiDocs.Responses;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore3.ApiDocs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {
        /// <summary>
        /// Echo's the input back
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(EchoResponse), (int) HttpStatusCode.OK)]
        public IActionResult Echo([FromBody] EchoRequest request)
        {
            return Ok(new EchoResponse { Echo = request.Echo });
        }
    }
}