using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using System;

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