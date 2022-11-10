using DAL;
using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketArchiveService
    {
        private TicketArchiveDAO dao;
        //Singleton for TicketArchiveService
        private static TicketArchiveService instance;
        private TicketArchiveService()
        {
            dao = TicketArchiveDAO.GetInstance();
        }

        public static TicketArchiveService GetInstance()
        {
            if (instance == null)
                instance = new TicketArchiveService();

            return instance;
        }

        public void AddArchive()
        {
            dao.AddArchive();
        }
    }
}
