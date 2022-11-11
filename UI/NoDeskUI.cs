using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace UI
{
    public partial class NoDeskUI : Form
    {
        private TicketService ticketService;
        private UserService userService;
        private const int IdColumn = 0;
        private List<Ticket_Model> getAllTickets;
        private List<User_Model> getAllUsers;
        private User_Model loggedUser;

        public NoDeskUI(User_Model loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            GridViewAutoColumnSize();
            DisplayAllEnumValues();
            dateTimePickerTicket.MaxDate = DateTime.Today;
            ticketService = TicketService.GetInstance();
            userService = UserService.GetInstance();
            DisableUpdateBoxes();
            InitDashboard();
            txtTicketNr.Visible = false;
            SetEmployeeAccess(loggedUser);

        }
        private void GridViewAutoColumnSize()
        {
            dataGVTicketOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetEmployeeAccess(User_Model user)
        {
            if (user.Role == Role.Employee)
            {
                btnDeleteTicket.Visible = false;
                btnUserManagement.Visible = false;
                btnUpdateTicket.Visible = false;
                txtTicketNr.Visible = false;
                cbDeadline.Visible = false;
                cbPriority.Visible = false;
                dateTimePickerTicket.Visible = false;
                txtSubject.Visible = false;
                btnTransferTicket.Visible = false;
                btnCloseTicket.Visible = false;
                btnArchiveTickets.Visible = false;
                btnIncidentManagement.Text = "Tickets";
            }
            
        }

        private void InitDashboard()
        {
            getAllTickets = ticketService.GetAllTickets();
            pnlIncidentManagemnt.Hide();
            pnlUserManagement.Hide();
            pnlDashboard.Show();

            progressBarUnresolvedIncidents.Minimum = 0;
            progressBarIncidentsPastDeadline.Minimum = 0;

            if (loggedUser.Role == Role.ServiceDeskEmployee)
            {
                ServiceEmployeeDashboard();
            }
            else if (loggedUser.Role == Role.Employee)
            {
                EmployeeDashboard();
            }
            progressBarUnresolvedIncidents.Text = $"{progressBarUnresolvedIncidents.Value}/{progressBarUnresolvedIncidents.Maximum}";
            progressBarIncidentsPastDeadline.Text = $"{progressBarIncidentsPastDeadline.Value}";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            InitDashboard();
        }
        
        private void ServiceEmployeeDashboard()
        {
            progressBarUnresolvedIncidents.Maximum = getAllTickets.Count;
            progressBarIncidentsPastDeadline.Maximum = getAllTickets.Count;
            progressBarUnresolvedIncidents.Value = 0;
            progressBarIncidentsPastDeadline.Value = 0;

            foreach (Ticket_Model ticket in getAllTickets)
            {
                if (ticket.Status == Status.Unfinished)
                {
                    progressBarUnresolvedIncidents.PerformStep();
                    //DateTime ticketMadeDate = DateTime.ParseExact(ticket.Date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    DateTime ticketMadeDate = ticket.Date;
                    int deadline = (int)ticket.Deadline;
                    int period = int.Parse(((DateTime.Now - ticketMadeDate.Date).Days).ToString());
                    if (period > deadline)
                    {
                        progressBarIncidentsPastDeadline.PerformStep();
                    }
                }
            }
        }
        private void EmployeeDashboard()
        {
            progressBarIncidentsPastDeadline.Maximum = 0;
            progressBarUnresolvedIncidents.Maximum = 0;

            foreach (Ticket_Model ticket in getAllTickets)
            {
                if (ticket.User.Split('(', ')')[1] == loggedUser.Email)
                {
                    progressBarUnresolvedIncidents.Maximum++;
                    progressBarIncidentsPastDeadline.Maximum++;

                    if (ticket.Status == Status.Unfinished)
                    {
                        progressBarUnresolvedIncidents.PerformStep();
                        //DateTime ticketMadeDate = DateTime.ParseExact(ticket.Date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                        DateTime ticketMadeDate = ticket.Date;
                        int deadline = (int)ticket.Deadline;
                        int period = int.Parse(((DateTime.Now - ticketMadeDate.Date).Days).ToString());
                        if (period > deadline)
                        {
                            progressBarIncidentsPastDeadline.PerformStep();
                        }
                    }
                }
            }
        }

        private void btnIncidentManagement_Click(object sender, EventArgs e)
        {
            pnlDashboard.Hide();
            pnlUserManagement.Hide();
            pnlIncidentManagemnt.Show();
            getAllTickets = ticketService.GetAllTickets();
            DisplayTickets(getAllTickets);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            pnlDashboard.Hide();
            pnlIncidentManagemnt.Hide();
            pnlUserManagement.Show();
            getAllUsers = userService.GetAllUsers();
            DisplayUsers(getAllUsers);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                Hide();
                login.ShowDialog();
                Close();
            }
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
            comboBoxPriorityAnd.DataSource = Enum.GetValues(typeof(Priority));
            comboBoxPriorityOr.DataSource = Enum.GetValues(typeof(Priority));
            comboBoxPrioritySorting.DataSource = Enum.GetValues(typeof(Priority));

            FillPromptTextComboBox(cbFilterByPriority, "priority");
            FillPromptTextComboBox(cbFilterByStatus, "ticket status");
            FillPromptTextComboBox(cbFilterByType, "incident type");
            FillPromptTextComboBox(cbFilterByDeadline, "deadline");

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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterTickets();
        }

        private async void FilterTickets()
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

        private void FillPromptTextComboBox(ComboBox cb,string text)
        {
            cb.Items.Add(text);
            cb.SelectedIndex = 0;
        }

        //diaplay all the tickets in the datagridview for the incident management

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

            if (indexOfRow != -1)
            {
                DataGridViewRow row = dataGVTicketOverview.Rows[indexOfRow];
                txtSubject.Text = row.Cells[2].Value.ToString();
                txtTicketNr.Text = row.Cells[5].Value.ToString();
                cbDeadline.Text = row.Cells[6].Value.ToString();
                cbPriority.Text = row.Cells[7].Value.ToString();

                CheckTicketStatus();
            }

        }

        //Disables the boxes and update buttons if the ticket is closed.
        private void CheckTicketStatus()
        {
            int indexOfRow = dataGVTicketOverview.SelectedCells[0].RowIndex; 
            DataGridViewRow row = dataGVTicketOverview.Rows[indexOfRow];

            if (row.Cells[4].Value.ToString() == "Finished") { DisableUpdateBoxes(); }
            else { EnableUpdateBoxes(); }
        }
        private void DisableUpdateBoxes()
        {
            txtSubject.Enabled = false;
            txtTicketNr.Enabled = false;
            cbDeadline.Enabled = false;
            cbPriority.Enabled = false;
            btnUpdateTicket.Enabled = false;
            dateTimePickerTicket.Enabled = false;
            btnTransferTicket.Enabled = false;
            btnCloseTicket.Enabled = false;
        }
        private void EnableUpdateBoxes()
        {
            txtSubject.Enabled = true;
            txtTicketNr.Enabled = true;
            cbDeadline.Enabled = true;
            cbPriority.Enabled = true;
            btnUpdateTicket.Enabled = true;
            dateTimePickerTicket.Enabled = true;
            btnTransferTicket.Enabled = true;
            btnCloseTicket.Enabled = true;
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket(loggedUser);
            addTicket.FormClosing += new FormClosingEventHandler(this.addTicket_FormClosing);
            addTicket.ShowDialog();
        }

        private void addTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshTickets();
            CheckTicketStatus();
        }

        // update ticket information when you click the update button
        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGVTicketOverview.SelectedRows.Count == 0)
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
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }

        }
        private List<Ticket_Model> GetUpdatedTickets()
        {
            var ticketFilter = Builders<Ticket_Model>.Filter.Eq(t => t.TicketNumber, int.Parse(txtTicketNr.Text));
            var updateTicket = Builders<Ticket_Model>.Update
                .Set(s => s.Subject, txtSubject.Text)
                .Set(z => z.Priority, (Priority)Enum.Parse(typeof(Priority), cbPriority.Text))
                .Set(v => v.Deadline, (Deadline)Enum.Parse(typeof(Deadline), cbDeadline.Text))
                .Set(d => d.Date, dateTimePickerTicket.Value.Date);
            var update = ticketService.GetTicketCollection().UpdateOne(ticketFilter, updateTicket);
            var listOfUpdateResult = ticketService.GetAllTickets();
            return listOfUpdateResult;

        }
        // search by subject
        private void btnSearchBySubject_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTxt = txtSearch.Text;
                DisplayTickets(ticketService.GetFilteredTicketBySubject(searchTxt));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }


        // search by status and priority when both match and display the tickets 
        private async void btnAndSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string status = comboBoxStatusAnd.Text;
                string priority = comboBoxPriorityAnd.Text;
                var listOfTickets = await ticketService.GetFilteredTicketByStatusAndPriority(status, priority);
                dataGVTicketOverview.DataSource = listOfTickets;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }

        // search by status or priority when any of these two match
        private void btnSearchOr_Click(object sender, EventArgs e)
        {
            try
            {
                string status=comboBoxStatusOr.Text;
                string priority=comboBoxPriorityOr.Text;
                DisplayTickets(ticketService.GetFilteredTicketByStatusOrPriority(status,priority));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }

        }

        // search by ticket
        private void buttonSearchByTicket_Click(object sender, EventArgs e)
        {
            try
            {
                int ticketNr = int.Parse(textBoxTicketSearch.Text);
                DisplayTickets(ticketService.GetFilteredTicketByTicketNr(ticketNr));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }
 
        // delete a ticket item
        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayTickets(GetTicketListAfterDelete());
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }
        private List<Ticket_Model> GetTicketListAfterDelete()
        {
            int ticketNr = int.Parse(txtTicketNr.Text);
            var filter = Builders<Ticket_Model>.Filter.Eq(t => t.TicketNumber, ticketNr);
            var result = ticketService.GetTicketCollection().DeleteOne(filter);
            var listOfTickets = ticketService.GetAllTickets();
            return listOfTickets;

        }
        private async Task GetRecentTicketsAsync()
        {
            var query = ticketService.GetTicketCollection().Aggregate()
                        .Sort(new BsonDocument { { "date", -1 } });
            var results = await query.ToListAsync();
            dataGVTicketOverview.DataSource = results;

        }


        private void btnRecentTicket_Click(object sender, EventArgs e)
        {
            try
            {
                GetRecentTicketsAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }

        //filter by incident type
        private void cbFilterByType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTicketByType(cbFilterByType.SelectedText);
        }

        private void GetTicketByType(string type)
        {
            var filter = Builders<Ticket_Model>.Filter.Regex(t => t.Type, BsonRegularExpression.Create(type));
            var result = ticketService.GetTicketCollection().Find(filter).ToList();
            dataGVTicketOverview.DataSource = result;
        }
        private void RefreshTickets()
        {
            var ticketList = ticketService.GetAllTickets();
            DisplayTickets(ticketList);
        }
        private void btnCloseTicket_Click(object sender, EventArgs e)
        {
            CloseTicket();
            MessageBox.Show("Ticket succesfully closed!");

        }
        private void btnTransferTicket_Click(object sender, EventArgs e)
        {
            TransferTicket transfer = new TransferTicket(GetTicketNumber(), GetTicketEmail());
            transfer.FormClosing += new FormClosingEventHandler(this.transfer_FormClosing);
            transfer.ShowDialog();
        }
        private void transfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshTickets();
            CheckTicketStatus();
        }

        private int GetTicketNumber()
        {
            try
            {
                if (dataGVTicketOverview.SelectedRows.Count == 0) { throw new Exception("No rows selected!"); }

                int rowIndex = dataGVTicketOverview.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGVTicketOverview.Rows[rowIndex];
                int ticketNr = int.Parse(selectedRow.Cells[5].Value.ToString());

                return ticketNr;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");

            }
            return 0;
        }
        private string GetTicketEmail()
        {
            try
            {
                if (dataGVTicketOverview.SelectedRows.Count == 0) { throw new Exception("No rows selected!"); }

                int rowIndex = dataGVTicketOverview.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGVTicketOverview.Rows[rowIndex];
                string email = selectedRow.Cells[1].Value.ToString();

                return email;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");

            }
            return null;
        }
        private void CloseTicket()
        {
            ticketService.UpdateTicketStatus(GetTicketNumber());
            RefreshTickets();
            CheckTicketStatus();
        }

        private void btnArchiveTickets_Click(object sender, EventArgs e)
        {
            ArchiveTicket archiveTicket = new ArchiveTicket(loggedUser);
            archiveTicket.FormClosing += new FormClosingEventHandler(this.archiveTicket_FormClosing);
            archiveTicket.ShowDialog();
        }

        private void archiveTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshTickets();
            CheckTicketStatus();
        }

        //------------------------//
        /*end incident management*/


        //------------------------//
        /*start user management*/

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.FormClosing += new FormClosingEventHandler(this.addUser_FormClosing);
            addUser.ShowDialog();
        }
        private void addUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshUsers();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            pnlDashboard.Hide();
            pnlIncidentManagemnt.Show();
        }

        // displaying all the user in the data gridview

        private void DisplayUsers(List<User_Model> users)
        {
            const int FirstName = 1;
            const int LastName = 2;
            const int PasswordColumn = 4;
            const int DigestColumn = 5;
            const int FullNamePair = 9;
            const int Fullname = 10;
            dataGVUser.DataSource = users;
            dataGVUser.Columns[IdColumn].Visible = false;
            dataGVUser.Columns[FirstName].Visible = false;
            dataGVUser.Columns[LastName].Visible = false;
            dataGVUser.Columns[PasswordColumn].Visible = false;
            dataGVUser.Columns[DigestColumn].Visible = false;
            dataGVUser.Columns[FullNamePair].Visible = false;
            dataGVUser.Columns[Fullname].DisplayIndex = 0;
        }

        private void btnRefreshUser_Click(object sender, EventArgs e)
        {
            RefreshUsers();
        }
        private void RefreshUsers()
        {
            var users = userService.GetAllUsers();
            DisplayUsers(users);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this user?", "User deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int rowIndex = dataGVUser.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGVUser.Rows[rowIndex];
                    string email = selectedRow.Cells[3].Value.ToString();
                    userService.DeleteUser(email);

                    MessageBox.Show("User successfully deleted!");

                    RefreshUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user \nERROR:{ex.Message}");
            }
        }



        //------------------------//
        /*end user management*/
    }
}