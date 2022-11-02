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
    public partial class AddUser : Form
    {
        UserService userService;
        public AddUser()
        {
            InitializeComponent();
            userService = UserService.GetInstance();
            cbLocation.DataSource = Enum.GetValues(typeof(Location));
            cbUser.DataSource = Enum.GetValues(typeof(Role));
        }
        private string GeneratePassword()
        { 
            //Generates a number password to simulate randomly generated passwords being sent.
            string password = "";
            const int Length = 5;
            Random rnd = new Random();

            for (int i = 0; i < Length; i++)
            {
                password += rnd.Next(10).ToString();
            }

            return password;
        }
        private void ClearInputs()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtNumber.Text = "";
            cbLocation.SelectedIndex = 0;
            cbUser.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //To-do input sanitation
            string password = GeneratePassword();
            User_Model user = new User_Model(txtFirstName.Text, txtLastName.Text, txtEmail.Text, password, (Role)cbUser.SelectedValue, (Location)cbLocation.SelectedValue, txtNumber.Text);

            try
            {
                userService.AddUser(user);
            }
            catch (Exception)
            {
                MessageBox.Show("Error adding user, try again.");
                ClearInputs();
            }

            MessageBox.Show($"User succesfully added! Password = {password}");
            ClearInputs();
        }
    }
}
