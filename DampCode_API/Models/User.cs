using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DampCode_API.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name"), BsonRepresentation(BsonType.String)]
        public  string? Name { get; set; }
        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public  string? Email { get; set; }
        [BsonElement("password"), BsonRepresentation(BsonType.String)]
        public  string? Password { get; set; }

        //DEFINIÇÃO DO TIPO
        [BsonElement("role"), BsonRepresentation(BsonType.String)]
        public  string? Role {  get; set; }

        // participante
        [BsonElement("nivel")]
        public int? Nivel { get; set; }
        [BsonElement("xp")]
        public decimal? Xp { get; set; }
        [BsonElement("tecnologias")]
        public List<string>? Tecnologias { get; set; }

        //Empresa
        [BsonElement("cnpj"), BsonRepresentation(BsonType.String)]
        public string? Cnpj { get; set; }

        [BsonElement("descricao"), BsonRepresentation(BsonType.String)]
        public string? Descricao { get; set; }

        [BsonElement("area"), BsonRepresentation(BsonType.String)]
        public string? Area { get; set; }

        [BsonElement("verificado"), BsonRepresentation(BsonType.Boolean)]
        public bool? Verificado { get; set; }

        [BsonElement("hackatonsIds")]
        public List<string>? HackatonsIds { get; set; }
    }
}
