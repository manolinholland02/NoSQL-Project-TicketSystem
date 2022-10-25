using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Ticket_Model> collection;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://GG-Group4:a4oj6VRsNB1T1q3t@gardengroup.nxaaurt.mongodb.net/test"); 
            db = client.GetDatabase("gardengroupdb");
        }

        public IMongoDatabase GetMongoDatabase()
        {
            return db;
        }
        ////public List<Ticket_Model> GetMongoCollection()
        ////{
        ////    return collection.Find(new BsonDocument()).ToList();
        ////}
<<<<<<< Updated upstream
        public List<BsonDocument> GetMongoFields()
        {
            collection = db.GetCollection<Ticket_Model>("tickets");
            var filter = Builders<Ticket_Model>.Filter.Empty;
            var projection = Builders<Ticket_Model>.Projection.Include("subject").Include("user").Exclude("_id");     
            List<BsonDocument> result =collection.Find<Ticket_Model>(filter).Project(projection).ToList();
            return result;
=======
        public void GetMongoFields()
        {
            collection = db.GetCollection<Ticket_Model>("tickets");
            var filter = Builders<Ticket_Model>.Filter.Empty;
            var projection = Builders<Ticket_Model>.Projection.Exclude("_id");     
            var result =collection.Find<Ticket_Model>(filter).Project(projection).ToList();
>>>>>>> Stashed changes
        }

        //public List<Databases_Model> GetDatabases()
        //{
        //    List<Databases_Model> all_databases = new List<Databases_Model>();
            
        //    foreach (BsonDocument db in client.ListDatabases().ToList())
        //    {
        //        all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
        //    }
        //    return all_databases;
        //}
    }


}
