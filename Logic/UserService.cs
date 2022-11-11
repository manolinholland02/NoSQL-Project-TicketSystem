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

        public User_Model GetUserByEmail(string email)
        {
            return dao.GetUserByEmail(email);
        }

        public void AddUser(User_Model user)
        {
            dao.AddUser(user);
        }

        //Method was used to generate 100 users
        //It stays here for explanation purposes (see AddUser.cs)
        public void AddMultipleUsers(List<User_Model> users)
        {
            dao.AddMultipleUsers(users);
        }

        public void DeleteUser(string email)
        {
            dao.DeleteUser(email);
        }

        public bool CheckUniqueEmail(string email)
        {
            return dao.CheckUniqueEmail(email); 
        }

        public IMongoCollection<User_Model> GetUserCollection()
        {
            return dao.GetUserCollection();
        }

        public List<User_Model> GetAllUsers()
        {
            return dao.GetAllUsers();
        }

        public List<User_Model> GetAllEmployees()
        {
            return dao.GetAllEmployees();
        }
    }
}
