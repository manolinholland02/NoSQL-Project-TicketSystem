using DAL;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Logic
{
    public class TicketService
    {
        private TicketDAO dao;
        //Singleton for TicketService
        private static TicketService instance;
        private TicketService()
        {
            dao = TicketDAO.GetInstance();
        }

        public static TicketService GetInstance()
        {
            if (instance == null)
                instance = new TicketService();

            return instance;
        }

        public void AddTicket(Ticket_Model ticket)
        {
            dao.AddTicket(ticket);
        }
        public void UpdateTicketStatus(int ticketNr)
        {
            dao.UpdateTicketStatus(ticketNr);
        }
        public void TransferTicket(string email, int ticketNr)
        {
            dao.TransferTicket(email, ticketNr);
        }

        public int GetTicketCount()
        {
            return dao.GetTicketCount();
        }

        public List<Ticket_Model> GetAllTickets()
        {
            return dao.GetAllTickets();
        }
        public IMongoCollection<Ticket_Model> GetTicketCollection()
        {
            return dao.GetTicketCollection();
        }

    }
}
