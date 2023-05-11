using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp
{  
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        //test
        public DataController()
        {

        }

        [HttpPost]
        [Route("/api/Data/AlphaCoun")]
        public Task<IActionResult> AlphaCountController([FromBody] string data) {

            Dictionary<char, int> AlphaCounter = new Dictionary<char, int>();
            foreach (var item in data.ToCharArray())
            {
                if(!AlphaCounter.ContainsKey(item)) AlphaCounter.Add(item, 1);
                else AlphaCounter[item]++;
            }

            var alphaCounts = new List<AlphaCount>() {};
            foreach (var item in AlphaCounter) {
                alphaCounts.Add(new AlphaCount() { 
                    Key = item.Key.ToString(),
                    Value = item.Value.ToString(),
                });
            }
 
            return Ok();
        }

    }
}
