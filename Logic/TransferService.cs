using DAL;
using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logic
{
    public class TransferService
    {
        private TicketDAO dao;
        //Singleton for TransferService
        private static TransferService instance;
        private TransferService()
        {
            dao = TicketDAO.GetInstance();
        }

        public static TransferService GetInstance()
        {
            if (instance == null)
                instance = new TransferService();

            return instance;
        }

        public void TransferTicket(string email, int ticketNr)
        {
            dao.TransferTicket(email, ticketNr);
        }
    }
}
