using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Logic;
using Model;
using MongoDB.Driver;

namespace UI
{
    public partial class NoDeskUI : Form
    {
        TicketService ticketService;
        const int IdColumn = 0;
        List<Ticket_Model> getAllTickets;

        public NoDeskUI()
        {
            InitializeComponent();
            ticketService = TicketService.GetInstance();
            DisplayAllEnumValues();
            getAllTickets=ticketService.GetAllTickets();
            DisplayTickets(getAllTickets);
            HideAllPanel();
            txtTicketNr.Visible = false;
            CheckUser();
;        }
        private void HideAllPanel()
        {
            pnlDashboard.Hide();
            pnlIncidentManagemnt.Hide();
            pnlUserManagement.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlIncidentManagemnt.Hide();
            pnlUserManagement.Hide();
            pnlDashboard.Show();
        }

        private void btnIncidentManagement_Click(object sender, EventArgs e)
        {

            pnlDashboard.Hide();
            pnlUserManagement.Hide();
            pnlIncidentManagemnt.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            pnlDashboard.Hide();
            pnlIncidentManagemnt.Hide();
            pnlUserManagement.Show();
        }
        //showing all the enum values in the combobox
        private void DisplayAllEnumValues()
        {
            cbPriority.DataSource = Enum.GetValues(typeof(Priority));
            cbDeadline.DataSource = Enum.GetValues(typeof(Deadline))
                                    .Cast<Deadline>()
                                    .Select(x => (int)x)
                                    .ToList();
            comboBoxStatusAnd.DataSource = Enum.GetValues(typeof(Status));
            comboBoxStatusOr.DataSource = Enum.GetValues(typeof(Status));
            comboBoxPriorityAnd.DataSource= Enum.GetValues(typeof(Priority));
            comboBoxPriorityOr.DataSource= Enum.GetValues(typeof(Priority));

        }

        //list all the tickets in the datagridview for the incident management

        private void DisplayTickets(List<Ticket_Model> getAllTickets)
        {
            dataGVTicketOverview.DataSource = getAllTickets;
            dataGVTicketOverview.Columns[IdColumn].Visible = false;
        }

        private void pnlIncidentManagemnt_Paint(object sender, PaintEventArgs e)
        {

        }

        //show information in the text and combofields when u select a row
        private void dGVTicketOverview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfRow = e.RowIndex;
            DataGridViewRow row = dataGVTicketOverview.Rows[indexOfRow];       
            txtSubject.Text = row.Cells[2].Value.ToString();
            txtTicketNr.Text= row.Cells[5].Value.ToString();
            cbDeadline.Text = row.Cells[6].Value.ToString();
            cbPriority.Text = row.Cells[7].Value.ToString();

        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            CreateTicket createTicket=new CreateTicket();
            createTicket.Show();
        }

        // update ticket information when you click the update button
        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if(dataGVTicketOverview.SelectedRows.Count== 0)
            {
                MessageBox.Show("Please select a row to update");
            }
            else if (dataGVTicketOverview.SelectedRows.Count > 0)
            {
                DisplayTickets(GetUpdatedTickets());
                MessageBox.Show("Your information is updated");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
            
        }
        private List<Ticket_Model> GetUpdatedTickets()
        {
            var ticketFilter = Builders<Ticket_Model>.Filter.Eq(t => t.TicketNumber, int.Parse(txtTicketNr.Text)); 
            var updateTicket = Builders<Ticket_Model>.Update
                .Set(s => s.Subject, txtSubject.Text)
                .Set(z => z.Priority, (Priority)Enum.Parse(typeof(Priority), cbPriority.Text))
                .Set(v => v.Deadline, (Deadline)Enum.Parse(typeof(Deadline), cbDeadline.Text))
                .Set(d => d.Date, dateTimePickerTicket.Text.ToString());
            var update=ticketService.GetTicketCollection().UpdateOne(ticketFilter, updateTicket);
            var  listOfUpdateResult= ticketService.GetAllTickets();
            return listOfUpdateResult;

        }
        // search by subject
        private void btnSearchBySubject_Click(object sender, EventArgs e)
        {
            DisplayTickets(GetFilteredTicketBySubject());
        }
        private List<Ticket_Model> GetFilteredTicketBySubject()
        {
            string searchText = txtSearch.Text;
            var filter = Builders<Ticket_Model>.Filter.Eq(s => s.Subject, searchText);
            var result = ticketService.GetTicketCollection().Find(filter).ToList();
            return result;

        }

        // search by status and priority when both match display the tickets 
        private void btnAndSearch_Click(object sender, EventArgs e)
        {
            DisplayTickets(GetFilteredTicketByStatusAndPriority());
        }
        private List<Ticket_Model> GetFilteredTicketByStatusAndPriority()
        {
            string status = comboBoxStatusAnd.Text;
            string priority = comboBoxPriorityAnd.Text;
            var filter = Builders<Ticket_Model>.Filter.Eq(s => s.Status, (Status)Enum.Parse(typeof(Status), status)) &
                Builders<Ticket_Model>.Filter.Eq(p=>p.Priority, (Priority)Enum.Parse(typeof(Priority), priority));
            var result = ticketService.GetTicketCollection().Find(filter).ToList();
            return result;
        }


        // search by status or priority when any of these two match
        private void btnSearchOr_Click(object sender, EventArgs e)
        {
            DisplayTickets(GetFilteredTicketByStatusOrPriority());

        }
        private List<Ticket_Model> GetFilteredTicketByStatusOrPriority()
        {
            string status = comboBoxStatusOr.Text;
            string priority = comboBoxPriorityOr.Text;
            var filter = Builders<Ticket_Model>.Filter.Eq(s => s.Status, (Status)Enum.Parse(typeof(Status), status)) |
                Builders<Ticket_Model>.Filter.Eq(p => p.Priority, (Priority)Enum.Parse(typeof(Priority), priority));
            var result = ticketService.GetTicketCollection().Find(filter).ToList();
            return result;
        }

        // search by ticket
        private void buttonSearchByTicket_Click(object sender, EventArgs e)
        {
            DisplayTickets(GetFilteredTicketByTicketNr());
        }
        private List<Ticket_Model> GetFilteredTicketByTicketNr()
        {
            int ticketNr = int.Parse(textBoxTicketSearch.Text);
            var filter=Builders<Ticket_Model>.Filter.Eq(t=>t.TicketNumber,ticketNr);
            var listOfTickets = ticketService.GetTicketCollection().Find(filter).ToList();
            return listOfTickets;
        }

        // delete a ticket item
        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            DisplayTickets(GetTicketListAfterDelete());
        }
        private List<Ticket_Model> GetTicketListAfterDelete()
        {
            int ticketNr = int.Parse(txtTicketNr.Text);
            var filter = Builders<Ticket_Model>.Filter.Eq(t => t.TicketNumber, ticketNr);
            var result = ticketService.GetTicketCollection().DeleteOne(filter);
            var listOfTickets = ticketService.GetAllTickets();
            return listOfTickets;

        }

        //------------------------//
        /*end incident management*/


        //------------------------//
        /*start user management*/
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void CheckUser()
        {
            //Check if the logged in user is employee or servicedeskemployee, disabling
            //buttons if only employee. To-Do after login is finished
            
        }


        //------------------------//
        /*end user management*/
    }
}
