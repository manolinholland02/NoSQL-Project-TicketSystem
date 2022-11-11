using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using System;
using MongoDB.Bson;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAL
{
    public class TicketDAO : BaseDAO
    {
        private const string DataBaseName = "gardengroupdb";
        private IMongoCollection<Ticket_Model> collection;
        private const string CollectionName = "tickets";
        //Singleton for TicketDAO
        private static TicketDAO instance;

        private TicketDAO()
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

        public static TicketDAO GetInstance()
        {
            if (instance == null)
                instance = new TicketDAO();

            return instance;
        }

        public void AddTicket(Ticket_Model ticket)
        {
            collection.InsertOne(ticket);
        }

        public void UpdateTicketStatus(int ticketNr)
        {
            var filter = Builders<Ticket_Model>.Filter.Eq(t => t.TicketNumber, ticketNr);
            var update = Builders<Ticket_Model>.Update.Set(s => s.Status, Status.Finished);
            collection.UpdateOne(filter, update);
        }

        public void TransferTicket(string email, int ticketNr)
        {
            var filter = Builders<Ticket_Model>.Filter.Eq(t => t.TicketNumber, ticketNr);
            var update = Builders<Ticket_Model>.Update.Set(e => e.User, email);
            collection.UpdateOne(filter, update);
        }

        public  List<Ticket_Model> GetFilteredTicketBySubject(string serachText)
        {
            var filter = Builders<Ticket_Model>.Filter.Regex(s => s.Subject, new BsonRegularExpression(Regex.Escape(serachText), "i"));
            var result = collection.Find(filter).ToList();
            return result;

        }

        public List<Ticket_Model> GetFilteredTicketBySubject(string serachText, string user)
        {
            var filter = Builders<Ticket_Model>.Filter.Regex(s => s.Subject, new BsonRegularExpression(Regex.Escape(serachText), "i")) & Builders<Ticket_Model>.Filter.Eq(u => u.User, user);
            var result = collection.Find(filter).ToList();
            return result;

        }

        public async Task<List<Ticket_Model>> GetFilteredTicketByStatusAndPriorityAsync(string status,string priority)
        {
            var query = collection.Aggregate()
                        .Match(new BsonDocument
                                {
                                    { "status", (int)Enum.Parse(typeof(Status),status) },
                                    { "priority", (int)Enum.Parse(typeof(Priority),priority) }
                                }
                        );
            var results = await query.ToListAsync();
            return results;
        }

        public async Task<List<Ticket_Model>> GetFilteredTicketByStatusAndPriorityAsync(string status, string priority, string user)
        {
            var query = collection.Aggregate()
                        .Match(Builders<Ticket_Model>.Filter.Eq(u =>u.User, user))
                        .Match(new BsonDocument
                                {
                                    { "status", (int)Enum.Parse(typeof(Status),status) },
                                    { "priority", (int)Enum.Parse(typeof(Priority),priority) }
                                }
                        );
            var results = await query.ToListAsync();
            return results;
        }

        public async Task<List<Ticket_Model>> GetFilteredTickets(string status, string priority, string deadline, string type, BsonDocument doc)
        {
  
            if (status != "Ticket status")
            {
                doc.Add("status", (int)Enum.Parse(typeof(Status), status));
            }

            if (priority != "Priority")
            {
                doc.Add("priority", (int)Enum.Parse(typeof(Priority), priority));
            }

            if (deadline != "Deadline")
            {
                doc.Add("deadline", (int)Enum.Parse(typeof(Deadline), deadline));
            }

            if (type != "Incident type")
            {
                doc.Add("type", (int)Enum.Parse(typeof(Model.Type), type));
            }

            var query = collection.Aggregate()
                        .Match(doc);
            var results = await query.ToListAsync();
            return results;
        }

        //Finding ticket documents less than or equal to a date passed in the parameter
        public List<Ticket_Model> GetFilteredTicketByDate(DateTime date)
        {
            var filter = Builders<Ticket_Model>.Filter.Lte(t => t.Date, date);
            var result = collection.Find(filter).ToList();

            return result;
        }

        //Deleting ticket documents less than or equal to a date passed in the parameter
        public void DeleteDocumentsLteDate(DateTime date)
        {
            var filter = Builders<Ticket_Model>.Filter.Lte(t => t.Date, date);
            try
            {
                collection.DeleteMany(filter);
            }
            catch
            {
                throw new Exception("Ne");
            }
        }

        public List<Ticket_Model> GetFilteredTicketByStatusOrPriority(string status,string priority)
        {
            
            var filter = Builders<Ticket_Model>.Filter.Eq(s => s.Status, Enum.Parse(typeof(Status), status)) |
                         Builders<Ticket_Model>.Filter.Eq(p => p.Priority, Enum.Parse(typeof(Priority), priority));

            var result = collection.Find(filter).ToList();

            return result;
        }

        public List<Ticket_Model> GetFilteredTicketByStatusOrPriority(string status, string priority, string user)
        {

            var filter = (Builders<Ticket_Model>.Filter.Eq(s => s.Status, Enum.Parse(typeof(Status), status)) |
                         Builders<Ticket_Model>.Filter.Eq(p => p.Priority, Enum.Parse(typeof(Priority), priority))) &
                         Builders<Ticket_Model>.Filter.Eq(u => u.User, user);

            var result = collection.Find(filter).ToList();

            return result;
        }

        public  List<Ticket_Model> GetFilteredTicketByTicketNr(int ticketNr)
        {
            var filter = Builders<Ticket_Model>.Filter.Eq(t => t.TicketNumber, ticketNr);
            var listOfTickets = collection.Find(filter).ToList();
            return listOfTickets;
        }

        public List<Ticket_Model> GetFilteredTicketByTicketNr(int ticketNr, string user)
        {
            var filter = Builders<Ticket_Model>.Filter.Eq(t => t.TicketNumber, ticketNr) & Builders<Ticket_Model>.Filter.Eq(u => u.User, user);
            var listOfTickets = collection.Find(filter).ToList();
            return listOfTickets;
        }

        public List<Ticket_Model> GetAllTickets()
        {
            return collection.AsQueryable().ToList<Ticket_Model>();
        }

        public List<Ticket_Model> GetTicketByUser(string user)
        {
            var filter = Builders<Ticket_Model>.Filter.Eq(u => u.User, user);
            var listOfTickets = collection.Find(filter).ToList();
            return listOfTickets;
        }

        public IMongoCollection<Ticket_Model> GetTicketCollection()
        {
            return collection;
        }

        // sorting by ascending order by the low priority value
        public async Task<List<Ticket_Model>> SortPriorityAscending()
        {
            var query = collection.Aggregate()
                        .Sort(new BsonDocument { { "priority", 1 } });
            var results = await query.ToListAsync();
            return results;
          

        }

        public async Task<List<Ticket_Model>> SortPriorityAscending(string user)
        {
            var query = collection.Aggregate()
                        .Match(Builders<Ticket_Model>.Filter.Eq(u => u.User, user))
                        .Sort(new BsonDocument { { "priority", 1 } });
            var results = await query.ToListAsync();
            return results;


        }

        // sorting by descending order by the hign priority value
        public async Task<List<Ticket_Model>> SortPriorityDescending()
        {
            var query = collection.Aggregate()
                        .Sort(new BsonDocument { { "priority", -1 } });
            var results = await query.ToListAsync();
            return results;

        }

        public async Task<List<Ticket_Model>> SortPriorityDescending(string user)
        {
            var query = collection.Aggregate()
                        .Match(Builders<Ticket_Model>.Filter.Eq(u => u.User,user))
                        .Sort(new BsonDocument { { "priority", -1 } });
            var results = await query.ToListAsync();
            return results;

        }
    }
}