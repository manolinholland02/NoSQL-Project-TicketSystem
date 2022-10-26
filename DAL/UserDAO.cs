using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAO
    {
        private MongoClient client;
        IMongoDatabase db;
        IMongoCollection<User_Model> collection;

        public UserDAO()
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
            collection = db.GetCollection<User_Model>("users");
            var filter = Builders<User_Model>.Filter.Empty;
            var projection = Builders<User_Model>.Projection.Exclude("_id");
            var result = collection.Find<User_Model>(filter).Project(projection).ToList();
        }
    }
}
