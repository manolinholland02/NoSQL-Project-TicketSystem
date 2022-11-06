using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Model;
using Logic;
using Type = Model.Type;

namespace UI
{
    public partial class CreateTicket : Form
    {
        TicketService ticketService;

        public CreateTicket()
        {
            InitializeComponent();
            ticketService = TicketService.GetInstance();
            cbTypeOfIncident.DataSource = Enum.GetValues(typeof(Type));
            cbPriority.DataSource = Enum.GetValues(typeof(Priority));
            cbDeadline.DataSource = Enum.GetValues(typeof(Deadline));

        }

        private void ClearTextBoxes()
        {
            txtSubOfIncident.Clear();
            txtDescription.Clear();
            cbTypeOfIncident.SelectedIndex = 0;
            cbPriority.SelectedIndex = 0;
            cbDeadline.SelectedIndex = 0;
        }

        /*public void FillComboboxWithData(ComboBox comboBox, Enum e)
        {
            var values = Enum.GetNames(e.GetType());

            foreach (var value in values)
            {
                comboBox.Items.Add(value.ToString());
            }
        }*/

        private void btnSubmitIncident_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket_Model ticket = new Ticket_Model("Gosho", txtSubOfIncident.Text, dtPickerIncident.Text, Status.unfinished, 5, (Deadline)cbDeadline.SelectedValue, (Priority)cbPriority.SelectedValue, (Type)cbTypeOfIncident.SelectedValue, txtDescription.Text);

                ticketService.AddTicket(ticket);
                MessageBox.Show($"Ticket has been succesfully added!");
                ClearTextBoxes();
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
