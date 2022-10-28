using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public enum Priority { normal=1,medium=2,high=3}
    public enum Deadline { five=5,ten=10,fifteen=15};
    public enum Status { unfinished=1, finished=2}
    public class Ticket_Model
    {
        [BsonId]
        public ObjectId Id { get; }

        [BsonElement("user")]
        public String User { get; set; }

        [BsonElement("subject")]
        public string Subject { get; set; }

        [BsonElement("date")]
        public String Date { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        [BsonElement("ticketNumber")]
        public int TicketNumber { get; set; }

        [BsonElement("deadline")]
        public Deadline Deadline { get; set; }

        [BsonElement("priority")]
        public string Priority { get; set; }

        public Ticket_Model(int fakeId, string user, string subject, string date, string status, int ticketNumber, Deadline deadline, string priority)
        {
            User = user;
            Subject = subject;
            Date = date;
            Status = status;
            TicketNumber = ticketNumber;
            Deadline = deadline;
            Priority = priority;
        }
    }
}
