using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Directory.Models
{
    public class Contact
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ContactId { get; set; }
        [ForeignKey("Person")]
        [BsonElement("Id")]
        public string Id { get; set; }
        [BsonElement("CallNumber")]
        public int CallNumber { get; set; }
        [BsonElement("eMail")]
        public string eMail { get; set; }
        [BsonElement("Konum")]
        public string Konum { get; set; }
        [BsonElement("Bilgiİcerigi")]
        public string Bilgiİcerigi { get; set; }
        //[BsonElement("person")]
        //public List<Person> person { get; set; }
    }
}
