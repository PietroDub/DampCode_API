using DampCode_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WebApiMongoDbDemo.Data;

namespace DampCode_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HackatonsController : ControllerBase
    {
        private readonly IMongoCollection<Hackaton> _hackatons;

        public HackatonsController(MongoDbService mongoDbService)
        {
            _hackatons = mongoDbService.Database?.GetCollection<Hackaton>("hackaton");
        }
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Hackaton>>> GetAllHackatons()
        {
            var hackatons = await _hackatons.Find(hackaton => true).FirstOrDefaultAsync();
            return Ok(hackatons);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hackaton>> GetHackatonById(string id)
        {
            var hackaton = await _hackatons.Find(h => h.HackatonId == id).FirstOrDefaultAsync();
            if (hackaton == null)
            {
                return NotFound(new { message = "Hackaton não encontrado. " });
            }
            return Ok(hackaton);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHackaton(string id, [FromBody] Hackaton updateHackaton)
        {
            if(id != updateHackaton.HackatonId)
            {
                return BadRequest(new { message = "O ID da URL não corresponde ao ID do usuário." });
            }

            var result = await _hackatons.ReplaceOneAsync(h =>  h.HackatonId == id, updateHackaton);

            //matched count, ver
            if (result.MatchedCount = 0) 
            {
                return NotFound(new {message = "Usuário não encontrado para atualização." });
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHackaton(string id)
        {
            var result = await _hackatons.DeleteOneAsync(h => h.HackatonId == id);
            if(result.MathedCount == 0)
            {
                return NotFound(new { message = "Usuário não encontrado. " });
            }
            return NoContent();
        }
    }
}
