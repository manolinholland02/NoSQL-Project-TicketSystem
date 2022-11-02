using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    
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
        public Status Status { get; set; }

        [BsonElement("ticketNumber")]
        public int TicketNumber { get; set; }

        [BsonElement("deadline")]
        public Deadline Deadline { get; set; }

        [BsonElement("priority")]
        public Priority Priority { get; set; }

        public Ticket_Model(string user, string subject, string date, Status status, int ticketNumber, Deadline deadline, Priority priority)
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
