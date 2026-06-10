using DampCode_API.Dto;
using DampCode_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WebApiMongoDbDemo.Data;

namespace DampCode_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HackathonsController : ControllerBase
    {
        private readonly IMongoCollection<Hackathon> _Hackathons;

        public HackathonsController(MongoDbService mongoDbService)
        {
            _Hackathons = mongoDbService.Database?.GetCollection<Hackathon>("Hackathon");
        }
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Hackathon>>> GetAllHackathons()
        {
            var Hackathons = await _Hackathons.Find(Hackathon => true).ToListAsync();
            return Ok(Hackathons);
        }

        [HttpPost("register/Hackathon")]
        public async Task<ActionResult<Hackathon>> CreateHackathon([FromBody] CreateHackathonDTO hackathonDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var Hackathon = new Hackathon
            {
                Titulo = hackathonDTO.Titulo,
                Descricao = hackathonDTO.Descricao,
                Empresa = hackathonDTO.Empresa,
                Area = hackathonDTO.Area,
                Tecnologias = hackathonDTO.Tecnologias,
                Metodo = hackathonDTO.Metodo,
                Ranking = hackathonDTO.Ranking,
                Premiacao = hackathonDTO.Premiacao,
                corPrincipal = hackathonDTO.corPrincipal,
                corSecundaria = hackathonDTO.corSecundaria,
                corFundo = hackathonDTO.corFundo,
                Logo = hackathonDTO.Logo,
                DataCriacao = hackathonDTO.DataCriacao,
                DataFinal = hackathonDTO.DataFinal,
                status = hackathonDTO.status
            };
            await _Hackathons.InsertOneAsync(Hackathon);
            return CreatedAtAction(nameof(GetHackathonById), new { id = Hackathon.HackathonId }, Hackathon);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hackathon>> GetHackathonById(string id)
        {
            var Hackathon = await _Hackathons.Find(h => h.HackathonId == id).FirstOrDefaultAsync();
            if (Hackathon == null)
            {
                return NotFound(new { message = "Hackathon não encontrado. " });
            }
            return Ok(Hackathon);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHackathon(string id, [FromBody] Hackathon updateHackathon)
        {
            if(id != updateHackathon.HackathonId)
            {
                return BadRequest(new { message = "O ID da URL não corresponde ao ID do usuário." });
            }

            var result = await _Hackathons.ReplaceOneAsync(h =>  h.HackathonId == id, updateHackathon);

            //matched count, ver
            if (result.MatchedCount == 0) 
            {
                return NotFound(new {message = "Usuário não encontrado para atualização." });
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHackathon(string id)
        {
            var result = await _Hackathons.DeleteOneAsync(h => h.HackathonId == id);
            if(result.DeletedCount == 0)
            {
                return NotFound(new { message = "Usuário não encontrado. " });
            }
            return NoContent();
        }
    }
}
