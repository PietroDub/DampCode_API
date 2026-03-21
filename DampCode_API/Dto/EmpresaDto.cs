using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DampCode_API.Dto
{
    public class EmpresaDto
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

        //Empresa
        [BsonElement("cnpj"), BsonRepresentation(BsonType.String)]
        public string? Cnpj { get; set; }

        [BsonElement("verificado"), BsonRepresentation(BsonType.Boolean)]
        public bool? Verificado { get; set; }

        [BsonElement("hackatonsIds")]
        public List<string>? HackatonsIds { get; set; }
    }
}
