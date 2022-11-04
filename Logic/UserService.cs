using DAL;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Logic
{
    public class UserService
    {
        private UserDAO dao;
        //Singleton for UserService
        private static UserService instance;

        private UserService()
        {
            dao = UserDAO.GetInstance();
        }

        public static UserService GetInstance()
        {
            if (instance == null)
                instance = new UserService();

            return instance;
        }

        public void GetMongoFields()
        {
            dao.GetMongoFields();
        }

        public List<User_Model> GetAllUsers()
        {
            return dao.GetAllUsers();
        }



        public IMongoCollection<User_Model> GetUserCollection()
        {
            return dao.GetUserCollection();
        }
    }
}
