using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public List<Ticket_Model> GetAllTickets()
        {
            return dao.GetAllTickets();
        }

        public List<Ticket_Model> GetTicketByUser(string user)
        {
            return dao.GetTicketByUser(user);
        }

        public IMongoCollection<Ticket_Model> GetTicketCollection()
        {
            return dao.GetTicketCollection();
        }

        public List<Ticket_Model> GetFilteredTicketBySubject(string serachText)
        {
            return dao.GetFilteredTicketBySubject(serachText);

        }
        public List<Ticket_Model> GetFilteredTicketBySubject(string serachText, string user)
        {
            return dao.GetFilteredTicketBySubject(serachText, user);

        }

        public async Task<List<Ticket_Model>> GetFilteredTicketByStatusAndPriority(string status, string priority)
        {
            return  await dao.GetFilteredTicketByStatusAndPriorityAsync(status,priority);
        }

        public async Task<List<Ticket_Model>> GetFilteredTicketByStatusAndPriority(string status, string priority, string user)
        {
            return await dao.GetFilteredTicketByStatusAndPriorityAsync(status, priority, user);
        }

        public async Task<List<Ticket_Model>> GetFilteredTickets(string status, string priority, string deadline, string type, BsonDocument doc)
        {
            return await dao.GetFilteredTickets(status, priority, deadline, type, doc);
        }

        public List<Ticket_Model> GetFilteredTicketByStatusOrPriority(string status, string priority)
        {

            return dao.GetFilteredTicketByStatusOrPriority(status, priority);
        }

        public List<Ticket_Model> GetFilteredTicketByStatusOrPriority(string status, string priority, string user)
        {

            return dao.GetFilteredTicketByStatusOrPriority(status, priority, user);
        }

        public List<Ticket_Model> GetFilteredTicketByTicketNr(int ticketNr)
        {
            return dao.GetFilteredTicketByTicketNr(ticketNr);
        }

        public List<Ticket_Model> GetFilteredTicketByTicketNr(int ticketNr, string user)
        {
            return dao.GetFilteredTicketByTicketNr(ticketNr, user);
        }

        public List<Ticket_Model> GetFilteredTicketByDate(DateTime date)
        {
            return dao.GetFilteredTicketByDate(date);
        }

        public void DeleteDocumentsLteDate(DateTime date)
        {
            dao.DeleteDocumentsLteDate(date);
        }

        public async Task<List<Ticket_Model>> SortPriorityAscending()
        {

           return await dao.SortPriorityAscending();

        }

        public async Task<List<Ticket_Model>> SortPriorityAscending(string user)
        {

            return await dao.SortPriorityAscending(user);

        }

        // sorting by descending order by the hign priority value
        public async Task<List<Ticket_Model>> SortPriorityDescending()
        {
            return await dao.SortPriorityDescending();

        }

        public async Task<List<Ticket_Model>> SortPriorityDescending(string user)
        {
            return await dao.SortPriorityDescending(user);

        }
    }
}
