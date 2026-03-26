using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DampCode_API.Models
{
    public class Hackaton
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        private string HackatonId { get; set; }
        [BsonElement("Titulo"), BsonRepresentation(BsonType.String)]
        public string? Titulo { get; set; }
        [BsonElement("Descricao"), BsonRepresentation(BsonType.String)]
        public string? Descricao { get; set; }
        [BsonElement("Empresa"), BsonRepresentation(BsonType.String)]
        public string? Empresa { get; set; }
        /* [BsonElement("Tecnologias"), BsonRepresentation(BsonType.String)]
        public list<> Tecnologias { get; set; }*/
        [BsonElement("Datas"), BsonRepresentation(BsonType.DateTime)]
        public DateTime Datas { get; set; }
        [BsonElement("Status"), BsonRepresentation(BsonType.Boolean)]
        public bool Status { get; set; }
        [BsonElement("Premio"), BsonRepresentation(BsonType.String)]
        public string? Premio { get; set; }

    }
}
