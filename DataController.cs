using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        [Route("CheckStatus")]        
        public string CheckAPIHealth()
        {
            return "API Working fine";

        }
    }
}
