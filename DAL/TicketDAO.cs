using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using System;
using MongoDB.Bson;

namespace DAL
{
    public class TicketDAO : BaseDAO
    {
        private IMongoCollection<Ticket_Model> collection;
        private const string CollectionName = "tickets";
        //Singleton for TicketDAO
        private static TicketDAO instance;

        private TicketDAO()
        {
            try
            {
                collection = db.GetCollection<Ticket_Model>(CollectionName);
            }
            catch (Exception)
            {
                throw new Exception(CollectionFailureMessage);
            }
        }

        public static TicketDAO GetInstance()
        {
            if (instance == null)
                instance = new TicketDAO();

            return instance;
        }

        public void AddTicket(Ticket_Model ticket)
        {
            collection.InsertOne(ticket);
        }
        public void UpdateTicketStatus(int ticketNr)
        {
            var filter = Builders<Ticket_Model>.Filter.Eq(t => t.TicketNumber, ticketNr);
            var update = Builders<Ticket_Model>.Update.Set(s => s.Status, Status.finished);
            collection.UpdateOne(filter, update);
        }
        public void TransferTicket(string email, int ticketNr)
        {
            var filter = Builders<Ticket_Model>.Filter.Eq(t => t.TicketNumber, ticketNr);
            var update = Builders<Ticket_Model>.Update.Set(e => e.Email, email);
            collection.UpdateOne(filter, update);
            return;
        }

        public int GetTicketCount()
        {
            return (int)collection.CountDocuments(new BsonDocument());
        }

        public List<Ticket_Model> GetAllTickets()
        {
            return collection.AsQueryable().ToList<Ticket_Model>();
        }

        public IMongoCollection<Ticket_Model> GetTicketCollection()
        {
            return collection;
        }
    }
}