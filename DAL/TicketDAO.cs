using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;

namespace DAL
{
    public class TicketDAO
    {
        private MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Ticket_Model> collection;

        public TicketDAO()
        {
            client = new MongoClient("mongodb+srv://GG-Group4:a4oj6VRsNB1T1q3t@gardengroup.nxaaurt.mongodb.net/test");
            db = client.GetDatabase("gardengroupdb");
        }

        public IMongoDatabase GetMongoDatabase()
        {
            return db;
        }

        public void GetMongoFields()
        {
            collection = db.GetCollection<Ticket_Model>("tickets");
            var filter = Builders<Ticket_Model>.Filter.Empty;
            var projection = Builders<Ticket_Model>.Projection.Exclude("_id");
            var result = collection.Find<Ticket_Model>(filter).Project(projection).ToList();
        }

    }


}