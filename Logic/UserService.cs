using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Logic
{
    public class UserService
    {
#pragma warning disable CS0122 // 'UserDAO' is inaccessible due to its protection level
        private UserDAO dao;
#pragma warning restore CS0122 // 'UserDAO' is inaccessible due to its protection level
        public UserService()
        {
            dao = new UserDAO();
        }

        public IMongoDatabase GetDatabase()
        {
            return dao.GetMongoDatabase();
        }

        public void GetMongoFields()
        {
            dao.GetMongoFields();
        }
    }
}
