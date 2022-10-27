using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public enum Priority { normal,medium,high}
    public enum Deadline { five=5,ten=10,fifteen=15};
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
        public String Status { get; set; }
        [BsonElement("ticketNumber")]
        public int TicketNumber { get; set; }
        [BsonElement("deadline")]
        public Deadline Deadline { get; set; }
        [BsonElement("priority")]
        public Priority Priority { get; set; }

        public Ticket_Model(int fakeId, string user, string subject, string date, string status, int ticketNumber, Deadline deadline, Priority priority)
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
