using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class Ticket_Model
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public int id { get; set; }


        [BsonElement("user")]
        public string user { get; set; }


        [BsonElement("subject")]
        public string subject { get; set; }


        [BsonElement("date")]
        public BsonDateTime date { get; set; }


        [BsonElement("status")]
        public string status { get; set; }


        [BsonElement("ticket number")]
        public int ticketNumber { get; set; }


    }
}
