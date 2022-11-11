using System;
using System.Windows.Forms;
using Model;
using Logic;
using Type = Model.Type;
using System.Data;
using System.Collections.Generic;

namespace UI
{
    public partial class AddTicket : Form, ICreateEnity
    {
        TicketService ticketService;

        public AddTicket(User_Model loggedUser)
        {
            InitializeComponent();
            ticketService = TicketService.GetInstance();
            LoadData(loggedUser);
        }

        //loads the corresponding data in the user controls
        private void LoadData(User_Model loggedUser)
        {
            FormatComboBox(cbTypeOfIncident, "type", new Type());
            FormatComboBox(cbPriority, "priority", new Priority());
            FormatComboBox(cbDeadline, "deadline", new Deadline());
            dtPickerIncident.MaxDate = DateTime.Today;
            dtPickerIncident.Value = DateTime.Now.Date;
            FormatReportedUserComboBox(loggedUser);
        }

        //formats ReportedUserComboBox to match name of user with their email and display the pair
        //users can have the same names but they have unique emails
        //email is unique for every user but it's not UX friendly to select reporting user based only on their email
        //full name + email pair gives certainty for the employee that he is selecting the correct user
        private void FormatReportedUserComboBox(User_Model loggedUser)
        {
            if (loggedUser.Role == Role.ServiceDeskEmployee)
            {
                UserService userService = UserService.GetInstance();
                List<User_Model> users = userService.GetAllUsers();
                Dictionary<string, string> emailFullnamePairs = new Dictionary<string, string>();
                const string ComboBoxDefaultMessage = "Select user...";
                
                emailFullnamePairs.Add("0", ComboBoxDefaultMessage);
                foreach (User_Model user in users) emailFullnamePairs.Add(user.Email, user.FullNameEmailPair);

                cbReportedUser.DataSource = new BindingSource(emailFullnamePairs, null);
                cbReportedUser.DisplayMember = "Value";
                cbReportedUser.ValueMember = "Key";
            }
            else
            {
                cbReportedUser.Items.Add("Select user...");
                cbReportedUser.Items.Add(loggedUser.FullNameEmailPair);
                cbReportedUser.SelectedIndex = 0;
            }
        }

        //formats ComboBox controls to display "Select ..." message without messing with the enumeration values(selectable options)
        private void FormatComboBox(ComboBox cb, string message, Enum e)
        {
            var enumValues = Enum.GetValues(e.GetType());
            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(string));

            DataRow dr = dt.NewRow();
            dr["Value"] = $"Select {message}...";
            dt.Rows.InsertAt(dr, 0);

            foreach (var name in enumValues)
            {
                dt.Rows.Add(name);
            }

            cb.DataSource = dt;
            cb.DisplayMember = "Value";
        }

        public void ClearInputs()
        {
            txtSubOfIncident.Clear();
            txtDescription.Clear();
            cbTypeOfIncident.SelectedIndex = 0;
            cbPriority.SelectedIndex = 0;
            cbDeadline.SelectedIndex = 0;
        }

        //generate randomized 5-digit ticket number when creating a ticket
        private int GenerateTicketNumber()
        {
            bool isValidNumberCreated = true;
            Random rdn = new Random();
            int[] tickeNumber = new int[5];
            int combinedOutput = 0;
            do
            {
                for (int i = 0; i < tickeNumber.Length; i++)
                {
                    if (i == 0)
                    {
                        //first digit can be from 1-9 because the ticket number is stored as integer (integers cannot start with 0.....)
                        tickeNumber[i] = rdn.Next(1, 10);
                        combinedOutput = tickeNumber[i];
                    }
                    else
                    {
                        //any other digit after the first one can vary from 0-9
                        tickeNumber[i] = rdn.Next(0, 10);
                        combinedOutput = (combinedOutput * 10) + tickeNumber[i];
                    }
                }

                foreach (Ticket_Model ticket in ticketService.GetAllTickets())
                {
                    //checks if ticket with such a number already exists (if yes, method is repeated)
                    if (ticket.TicketNumber == combinedOutput) isValidNumberCreated = false;
                }
            }
            while (!isValidNumberCreated);
            
            return combinedOutput;
        }

        //validating for the right inputs
        public void ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtSubOfIncident.Text))
                throw new Exception("Subject field can't be blank!");
            else if (dtPickerIncident.Value > DateTime.Today)
                throw new Exception("Cannot enter a future date on incident");
            else if (cbTypeOfIncident.SelectedIndex == 0)
                throw new Exception("Please select a type for the incident.");
            else if (cbReportedUser.SelectedIndex == 0)
                throw new Exception("Please select a reporting user for the incident");
            else if (cbPriority.SelectedIndex == 0)
                throw new Exception("Please select a priority for the incident.");
            else if (cbDeadline.SelectedIndex == 0)
                throw new Exception("Please select a deadline for the incident.");
        }

        private string CastSelectedItemToDataRowView(ComboBox cb)
        {
            DataRowView dataRowView = cb.SelectedItem as DataRowView;
            string selectedValue = "";

            if (dataRowView != null)
                selectedValue = dataRowView.Row["Value"] as string;

            return selectedValue;
        }

        private void btnSubmitIncident_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();
                Ticket_Model ticket = new Ticket_Model(
                    cbReportedUser.Text,
                    txtSubOfIncident.Text,
                    dtPickerIncident.Value,
                    Status.Unfinished,
                    GenerateTicketNumber(),
                    (Deadline)Enum.Parse(typeof(Deadline), CastSelectedItemToDataRowView(cbDeadline)),
                    (Priority)Enum.Parse(typeof(Priority), CastSelectedItemToDataRowView(cbPriority)),
                    (Type)Enum.Parse(typeof(Type), CastSelectedItemToDataRowView(cbTypeOfIncident)),
                    txtDescription.Text);

                ticketService.AddTicket(ticket);
                ClearInputs();
                MessageBox.Show($"Ticket has been succesfully added!");
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"There was an error while trying to add the ticket, try again. \n error: {error.Message}");
            }
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
