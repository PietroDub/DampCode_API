using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DampCode_API.Dto
{
    public class ParticipanteDto
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public required string Id { get; set; }
        [BsonElement("name"), BsonRepresentation(BsonType.String)]
        public required string Name { get; set; }
        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public required string Email { get; set; }
        [BsonElement("password"), BsonRepresentation(BsonType.String)]
        public required string Password { get; set; }

        //DEFINIÇÃO DO TIPO
        [BsonElement("role"), BsonRepresentation(BsonType.String)]
        public required string Role { get; set; }

        // participante
        [BsonElement("nivel")]
        public int? Nivel { get; set; }
        [BsonElement("xp")]
        public decimal? Xp { get; set; }
        [BsonElement("tecnologias")]
        public List<string>? Tecnologias { get; set; }
    }
}
