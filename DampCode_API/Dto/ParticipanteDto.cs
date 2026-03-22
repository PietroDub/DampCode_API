using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DampCode_API.Dto
{
    public class ParticipanteDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

        // participante
        public int? Nivel { get; set; }
        public decimal? Xp { get; set; }
        public List<string>? Tecnologias { get; set; }
    }
}
