using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using System;

namespace DAL
{
    public class TicketArchiveDAO : BaseDAO
    {
        private const string DataBaseName = "archivegardengroupdb";
        private IMongoCollection<Ticket_Model> collection;
        private const string CollectionName = "archivedTickets";
        //Singleton for TicketArchiveDAO
        private static TicketArchiveDAO instance;

        public TicketArchiveDAO()
        : base(DataBaseName)
        {
            try
            {
                collection = db.GetCollection<Ticket_Model>(CollectionName);
            }
            catch (Exception)
            {
                throw new Exception(CollectionFailureMessage);
            }
        }

        public static TicketArchiveDAO GetInstance()
        {
            if (instance == null)
                instance = new TicketArchiveDAO();

            return instance;
        }

        public void AddArchive(DateTime date)
        {
            TicketDAO ticketDAO = TicketDAO.GetInstance();
            List<Ticket_Model> selectedTickets = ticketDAO.GetFilteredTicketByDate(date);
            collection.InsertMany(selectedTickets);
            ticketDAO.DeleteDocumentsLteDate(date);
        }
    }
}
