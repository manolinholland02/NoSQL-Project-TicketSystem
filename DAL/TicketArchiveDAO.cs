using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using System;

namespace DAL
{
    public class TicketArchiveDAO : BaseDAO
    {
        //this DAO class is used to access the archive database and execute data operation
        //made for implementing archiving tickets functionality(Manol Draganov)
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

        //method for archiving tickets
        //tickets are selected based on date criteria
        public void AddArchive(DateTime date)
        {
            TicketDAO ticketDAO = TicketDAO.GetInstance();
            List<Ticket_Model> selectedTickets = ticketDAO.GetFilteredTicketByDate(date);
            collection.InsertMany(selectedTickets);
            ticketDAO.DeleteDocumentsLteDate(date);
        }
    }
}
