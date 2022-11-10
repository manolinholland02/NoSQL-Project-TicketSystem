using DAL;
using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public List<Ticket_Model> GetFilteredTicketBySubject(string serachText)
        {
            return dao.GetFilteredTicketBySubject(serachText);

        }

        public async Task<List<Ticket_Model>> GetFilteredTicketByStatusAndPriority(string status, string priority)
        {
            return  await dao.GetFilteredTicketByStatusAndPriorityAsync(status,priority);
        }

        public async Task<List<Ticket_Model>> GetFilteredTickets(string status, string priority, string deadline, string type)
        {
            return await dao.GetFilteredTickets(status, priority, deadline, type);
        }

        public List<Ticket_Model> GetFilteredTicketByStatusOrPriority(string status, string priority)
        {

            return dao.GetFilteredTicketByStatusOrPriority(status, priority);
        }
        public List<Ticket_Model> GetFilteredTicketByTicketNr(int ticketNr)
        {
            return dao.GetFilteredTicketByTicketNr(ticketNr);
        }
    }
}
