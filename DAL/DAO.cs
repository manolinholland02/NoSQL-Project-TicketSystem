using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://GG-Group4:a4oj6VRsNB1T1q3t@gardengroup.nxaaurt.mongodb.net/testa4oj6VRsNB1T1q3t");
        }

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> all_databases = new List<Databases_Model>();
            
            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return all_databases;
        }
    }


}
