using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMDev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        
        [HttpGet]
        public Task<IActionResult> Get()
        {
            return NoContent();
        }

        
        [HttpGet("{id}")]
        public Task<IActionResult> Get(int id)
        {
            return NoContent();
        }
              
        [HttpPost]
        public Task<IActionResult> Post([FromBody] string value)
        {
            return Created();
        }
       
        [HttpPut("{id}")]
        public Task<IActionResult> Put(int id, [FromBody] string value)
        {
            return NoContent();

        }      
    }
}
