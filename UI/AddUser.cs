using System;
using System.Windows.Forms;
using Model;
using Logic;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class AddUser : Form, ICreateEnity
    {
        UserService userService;
        public AddUser()
        {
            InitializeComponent();
            userService = UserService.GetInstance();
            cbLocation.DataSource = Enum.GetValues(typeof(Location));
            cbUser.DataSource = Enum.GetValues(typeof(Role));
            this.ShowDialog();
        }
        private string GeneratePassword()
        { 
            //Generates a number password to simulate randomly generated passwords being sent.
            string password = null;
            const int Length = 5;
            Random rnd = new Random();

            for (int i = 0; i < Length; i++)
            {
                password += rnd.Next(10).ToString();
            }

            return password;
        }
        public void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtNumber.Clear();
            cbLocation.SelectedIndex = 0;
            cbUser.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ValidateInputs()
        {
            //Check if all fields are filled
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtNumber.Text))
            {
                throw new Exception("Field can't be blank!");
            }

            //Check if name only contains letters
            const string patternA = @"^[a-zA-Z]+$";
            if (!Regex.IsMatch(txtFirstName.Text, patternA) || !Regex.IsMatch(txtLastName.Text, patternA))
            {
                throw new Exception("Name can't contain symbols or numbers!");
            }

            //Pattern to check valid phone number
            const string patternB = @"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$";
            if (!Regex.IsMatch(txtNumber.Text, patternB))
            {
                throw new Exception("Invalid phone number!");
            }

            //Pattern to check valid email (not perfect but works)
            const string patternC = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (!Regex.IsMatch(txtEmail.Text, patternC))
            {
                throw new Exception("Invalid email!");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string password = GeneratePassword();

            try
            {
                ValidateInputs();
                User_Model user = new User_Model(txtFirstName.Text, txtLastName.Text, txtEmail.Text, password, (Role)cbUser.SelectedValue, (Location)cbLocation.SelectedValue, txtNumber.Text);

                userService.AddUser(user);
                MessageBox.Show($"User succesfully added! \nPassword = {password}");
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user, try again. \nERROR: {ex.Message}");
            }

        }
    }
}
