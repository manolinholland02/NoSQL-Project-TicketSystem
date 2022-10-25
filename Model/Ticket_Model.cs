using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public enum Priority { normal,medium,high}
    public enum Deadline { five=5,ten=10,fifteen=15};
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

        [BsonElement("deadline")]
        public Deadline deadline { get; set; }
        [BsonElement("priority")]
        public Priority priority { get; set; }



    }
}
