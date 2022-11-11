using Logic;
using Model;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class ArchiveTicket : Form
    {
        private User_Model loggedUser;

        public ArchiveTicket(User_Model loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            dtPickerArchive.MaxDate = DateTime.Today;
            SwitchPanel(pnlTicketSelection, pnlVerifyUser);
        }

        //swithing panels based on the stage in which the archiving process is 
        private void SwitchPanel(Panel panelFirst, Panel panelSecond)
        {
            panelFirst.Visible = true;
            panelSecond.Visible = false;
        }

        //return how many tickets are selected that are older/equal to the selected date
        private int GetTicketCount()
        {
            TicketService ticketService = TicketService.GetInstance();
            return ticketService.GetFilteredTicketByDate(dtPickerArchive.Value).Count;
        }

        //display number of selected tickets
        private void dtPickerArchive_ValueChanged(object sender, EventArgs e)
        {
            int tickets = GetTicketCount();
            lblCount.Text = tickets.ToString() + " tickets match your criteria";
        }

        private void btnAddArchive_Click(object sender, EventArgs e)
        {
            if (GetTicketCount() == 0)
            {
                MessageBox.Show("No tickets have been selected. Please enter a different date.");
            }
            else
            {
                DialogResult result = MessageBox.Show(
                $"You are about to archive {GetTicketCount()} incident tickets. All the tickets from {dtPickerArchive.Value.ToString("MM.dd.yyyy")} and older will be removed from the active system and put into an arhive. This action cannot be undone. Are you sure you want to do this?",
                "Archive tickets",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SwitchPanel(pnlVerifyUser, pnlTicketSelection);
                }
            }
        }

        //checks if the user has enter correctly his creditential(password) to proceed to archiving
        private bool IsUserValidated()
        {
            HashTool tool = new HashTool();
            UserService userService = UserService.GetInstance();
            string result = tool.HashPassword(txtPassword.Text, loggedUser.Salt).Digest;
            var filter = Builders<User_Model>.Filter.Eq(s => s.Email, loggedUser.Email) & Builders<User_Model>.Filter.Eq(s => s.Digest, result);
            var check = userService.GetUserCollection().Find(filter).FirstOrDefault();

            if (check == null) return false;

            return true;
        }

        private void btnVerifyUser_Click_1(object sender, EventArgs e)
        {
            if (!IsUserValidated())
            {
                MessageBox.Show("Password doesn't match. Please try again.");
                txtPassword.Clear();
            }
            else
            {
                try
                {
                    //conformation message comes before the archiving operation because count of selected tickets counts dynamically from the active database 
                    MessageBox.Show($"{GetTicketCount()} from {dtPickerArchive.Value.ToString("MM.dd.yyyy")} and before have been archived.");
                    TicketArchiveService service = TicketArchiveService.GetInstance();
                    //archiving the selected tickets
                    service.AddArchive(dtPickerArchive.Value);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured while trying to archive. Pleasy try again.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
