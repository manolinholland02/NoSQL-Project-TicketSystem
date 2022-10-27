using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;

namespace DAL
{
    public class TicketDAO
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Ticket_Model> collection;

        public TicketDAO()
        {
            client = new MongoClient("mongodb+srv://GG-Group4:a4oj6VRsNB1T1q3t@gardengroup.nxaaurt.mongodb.net/test");
            db = client.GetDatabase("gardengroupdb");
        }

        public IMongoDatabase GetMongoDatabase()
        {
            return db;
        }

        public List<Ticket_Model> GetAllTickets()
        {
            collection = db.GetCollection<Ticket_Model>("tickets");
            return collection.AsQueryable().ToList<Ticket_Model>();
        }

    }


}