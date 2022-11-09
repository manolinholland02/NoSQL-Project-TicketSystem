using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using MongoDB.Bson;

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

        public void AddUser(User_Model user)
        {
            collection.InsertOne(user);
        }
        public void DeleteUser(string email)
        {
            var filter = Builders<User_Model>.Filter.Eq(e => e.Email, email);
            collection.DeleteOne(filter);
        }

        public List<User_Model> GetAllUsers()
        {
            return collection.AsQueryable().ToList<User_Model>();
        }

        public User_Model GetUserByEmail(string email)
        {
            var filter = Builders<User_Model>.Filter.Eq(u => u.Email, email);
            var user = collection.Find(filter).FirstOrDefault();
            return user;
        }

        public List<User_Model> GetAllEmployees()
        {
            var filter = Builders<User_Model>.Filter.Eq(r => r.Role, Role.Employee);
            return collection.Find(filter).ToList();
        }
        public bool CheckUniqueEmail(string email)
        {
            var filter = Builders<User_Model>.Filter.Eq(e => e.Email, email);
            if(collection.CountDocuments(filter) == 0) { return true; }
            else { return false; }
        }

        public IMongoCollection<User_Model> GetUserCollection()
        {
            return collection;
        }
    }
}
