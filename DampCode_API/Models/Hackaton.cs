using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DampCode_API.Models
{
    public class Hackathon
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? HackathonId { get; set; }

        [BsonElement("Titulo")]
        public string? Titulo { get; set; }

        [BsonElement("Descricao")]
        public string? Descricao { get; set; }

        [BsonElement("Empresa")]
        public string? Empresa { get; set; }

        [BsonElement("Area")]
        public string? Area { get; set; }

        [BsonElement("Tecnologias")]
        public List<string>? Tecnologias { get; set; }

        [BsonElement("Metodo")]
        public string? Metodo { get; set; }

        [BsonElement("Ranking")]
        public string? Ranking { get; set; }

        [BsonElement("Premiacao")]
        public decimal Premiacao { get; set; }

        [BsonElement("CorPrincipal")]
        public string? CorPrincipal { get; set; }

        [BsonElement("CorSecundaria")]
        public string? CorSecundaria { get; set; }

        [BsonElement("CorFundo")]
        public string? CorFundo { get; set; }

        [BsonElement("Logo")]
        public string? Logo { get; set; }

        [BsonElement("DataCriacao")]
        public DateTime DataCriacao { get; set; }

        [BsonElement("DataFinal")]
        public DateTime DataFinal { get; set; }

        [BsonElement("Status")]
        public bool Status { get; set; }
    }
}