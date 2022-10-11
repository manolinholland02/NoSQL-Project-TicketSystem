using DAL;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Logic
{
    public class Databases
    {
        private DAO dao;
        public Databases()
        {
            dao = new DAO();
        }

        public IMongoDatabase GetDatabase()
        {
            return dao.GetMongoDatabase();
        }
        public List<Ticket_Model> GetCollection()
        {
            return dao.GetMongoCollection();
        }

        //public List<Databases_Model> Get_All_Databases()
        //{
        //    return dao.GetDatabases();
        //}
    }
}
