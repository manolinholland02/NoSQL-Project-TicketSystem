using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class Ticket_Model
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("user")]
        public string User { get; set; }

        [BsonElement("subject")]
        public string Subject { get; set; }

        [BsonElement("date")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }

        [BsonElement("status")]
        public Status Status { get; set; }

        [BsonElement("ticketNumber")]
        public int TicketNumber { get; set; }

        [BsonElement("deadline")]
        public Deadline Deadline { get; set; }

        [BsonElement("priority")]
        public Priority Priority { get; set; }

        [BsonElement("type")]
        public Type Type { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        public Ticket_Model(string user, string subject, DateTime date, Status status, int ticketNumber, Deadline deadline, Priority priority, Type type, string description)
        {
            User = user;
            Subject = subject;
            Date = date;
            Status = status;
            TicketNumber = ticketNumber;
            Deadline = deadline;
            Priority = priority;
            Type = type;
            Description = description;
        }
    }
}
