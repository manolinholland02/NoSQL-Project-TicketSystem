using Logic;
using Model;
using MongoDB.Bson;
using System;
using System.Windows.Forms;

namespace UI
{
    public class FilterTicket
    {
        TicketService ticketService;
        public FilterTicket() 
        { 
            ticketService = TicketService.GetInstance();
        }

        //fills in the comboboxes
        public void FillComboBox(ComboBox cbFilterByPriority, ComboBox cbFilterByStatus, ComboBox cbFilterByType, ComboBox cbFilterByDeadline)
        {
            FillPromptTextComboBox(cbFilterByPriority, "Priority");
            FillPromptTextComboBox(cbFilterByStatus, "Ticket status");
            FillPromptTextComboBox(cbFilterByType, "Incident type");
            FillPromptTextComboBox(cbFilterByDeadline, "Deadline");

            foreach (Enum e in Enum.GetValues(typeof(Status)))
            {
                cbFilterByStatus.Items.Add(e);
            }

            foreach (Enum e in Enum.GetValues(typeof(Priority)))
            {
                cbFilterByPriority.Items.Add(e);
            }

            foreach (Enum e in Enum.GetValues(typeof(Deadline)))
            {
                cbFilterByDeadline.Items.Add(e);
            }

            foreach (Enum e in Enum.GetValues(typeof(Model.Type)))
            {
                cbFilterByType.Items.Add(e);
            }
        }

        //filters the tickets
        public async void FilterTickets(User_Model loggedUser, ComboBox cbFilterByPriority, ComboBox cbFilterByStatus, ComboBox cbFilterByType, ComboBox cbFilterByDeadline, DataGridView dataGVTicketOverview)
        {
            BsonDocument doc = new BsonDocument();
            string status = cbFilterByStatus.Text;
            string priority = cbFilterByPriority.Text;
            string deadline = cbFilterByDeadline.Text;
            string type = cbFilterByType.Text;
            if (loggedUser.Role == Role.Employee)
            {
                doc.Add("user", loggedUser.FullNameEmailPair);
            }

            var tickets = await ticketService.GetFilteredTickets(status, priority, deadline, type, doc);
            dataGVTicketOverview.DataSource = tickets;
        }

        //adds the prompt text in the combobox and selects it
        public void FillPromptTextComboBox(ComboBox cb, string text)
        {
            cb.Items.Add(text);
            cb.SelectedIndex = 0;
        }
    }
}
