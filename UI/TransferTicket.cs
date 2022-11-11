using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Logic;


namespace UI
{
    public partial class TransferTicket : Form
    {
        int ticketNr;
        string email;
        TransferService transferService;    
        UserService userService;
        public TransferTicket(int ticketNr, string email)
        {
            InitializeComponent();
            this.ticketNr = ticketNr;
            this.email = email;
            transferService = TransferService.GetInstance();
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
                string email = cbEmployees.SelectedItem.ToString();  
                transferService.TransferTicket(email, ticketNr);
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
            //Add all users besides the one who the ticket is assigned to
            foreach (User_Model employee in employees)
            {
                if (email != employee.Email)
                {
                    cbEmployees.Items.Add(employee.FullNameEmailPair);
                }
            }
        }

        
    }
}
