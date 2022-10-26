﻿using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Logic
{
    public class TicketService
    {
        private TicketDAO dao;
        public TicketService()
        {
            dao = new TicketDAO();
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
