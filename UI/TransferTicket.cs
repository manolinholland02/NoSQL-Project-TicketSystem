using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;


namespace UI
{
    public partial class TransferTicket : Form
    {
        int ticketNr;
        string email;
        TicketService ticketService;    
        UserService userService;
        public TransferTicket(int ticketNr, string email)
        {
            InitializeComponent();
            this.ticketNr = ticketNr;
            this.email = email;
            ticketService = TicketService.GetInstance();
            userService = UserService.GetInstance();
            FillEmployees();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbEmployees.SelectedIndex == 0) { throw new Exception("Please select an employee!"); }
                string email = cbEmployees.SelectedItem.ToString().Split(' ')[3];
                ticketService.TransferTicket(email, ticketNr);
                MessageBox.Show("Ticket succesfully transferred!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"ERROR: {ex.Message}");
            }
            
        }
        private void FillEmployees()
        {
            cbEmployees.Items.Add("Select employee...");
            cbEmployees.SelectedIndex = 0;

            List<User_Model> employees = userService.GetAllEmployees();
            employees.Sort((x, y) => string.Compare(x.FirstName, y.FirstName));
            foreach (User_Model employee in employees)
            {
                if (email != employee.Email)
                {
                    cbEmployees.Items.Add($"{employee.FullName} @ {employee.Email}");
                }
            }
        }

        
    }
}
