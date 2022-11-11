using DAL;
using System;

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

        public void AddArchive(DateTime date)
        {
            dao.AddArchive(date);
        }
    }
}
