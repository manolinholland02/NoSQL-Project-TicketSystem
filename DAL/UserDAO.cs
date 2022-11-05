using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UserDAO : BaseDAO
    {
        private IMongoCollection<User_Model> collection;
        private const string CollectionName = "users";
        //Singleton for UserDAO
        private static UserDAO instance;

        private UserDAO()
        {
            try
            {
                collection = db.GetCollection<User_Model>(CollectionName);
            }
            catch(Exception)
            {
                throw new Exception(CollectionFailureMessage);
            }
        }

        public static UserDAO GetInstance()
        {
            if (instance == null)
                instance = new UserDAO();

            return instance;
        }

        //public void GetMongoFields()
        //{
        //    collection = db.GetCollection<User_Model>("users");
        //    var filter = Builders<User_Model>.Filter.Empty;
        //    var projection = Builders<User_Model>.Projection.Exclude("_id");
        //    var result = collection.Find<User_Model>(filter).Project(projection).ToList();
        //}

        public void AddUser(User_Model user)
        {
            collection.InsertOne(user);
        }

        public List<User_Model> GetAllUsers()
        {
            return collection.AsQueryable().ToList<User_Model>();
        }

        public IMongoCollection<User_Model> GetUserCollection()
        {
            return collection;
        }
    }
}
