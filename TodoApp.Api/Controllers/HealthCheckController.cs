using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TodoApp.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            await Task.CompletedTask;
            return Ok("TodoApp");
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            await Task.CompletedTask;
            return Ok($"Added! {id}");
        }

        [HttpPost]
        public async Task<ActionResult> Post()
        {
            await Task.CompletedTask;
            return CreatedAtAction(nameof(Get), new { id = 1 }, null); // , null - dodanie url w nagłówku
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id) 
        {
            await Task.CompletedTask;
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await Task.CompletedTask;
            return NoContent();
        }
    }
}
