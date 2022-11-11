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
        HashTool tool;
        
        public AddUser()
        {
            InitializeComponent();
            userService = UserService.GetInstance();
            FillData();
            tool = new HashTool();

        }

        private void FillData()
        {
            cbLocation.Items.Add("Select location...");
            cbLocation.SelectedIndex = 0;

            cbUser.Items.Add("Select role...");
            cbUser.SelectedIndex = 0;

            foreach (Location i in Enum.GetValues(typeof(Location)))
            {
                cbLocation.Items.Add(i);
            }

            foreach (Role i in Enum.GetValues(typeof(Role)))
            {
                cbUser.Items.Add(i);
            }
            //Changed from datasource to foreach loops due to wanting index 0 to be default text
        }


        public void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtNumber.Clear();
            txtPassword.Clear();
            txtVerifyPassword.Clear();
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
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtNumber.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtVerifyPassword.Text))
            { throw new Exception("Field can't be blank!"); }

            //Check if role is selected
            if(cbUser.SelectedIndex == 0)
            { throw new Exception("Select a user role!"); }

            //Check if location is selected
            if(cbLocation.SelectedIndex == 0)
            { throw new Exception("Select a user location!"); }

            //Check if name only contains letters
            const string PatternA = @"^[a-zA-Z]+$";
            if (!Regex.IsMatch(txtFirstName.Text, PatternA) || !Regex.IsMatch(txtLastName.Text, PatternA))
            { throw new Exception("Name can't contain symbols or numbers!"); }

            //Check if password matches 
            if(txtPassword.Text != txtVerifyPassword.Text)
            { throw new Exception("Passwords don't match!"); }

            //Pattern to check valid phone number
            const string PatternB = @"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$";
            if (!Regex.IsMatch(txtNumber.Text, PatternB)) 
            { throw new Exception("Invalid phone number!"); }

            //Pattern to check valid email (not perfect but works)
            const string PatternC = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (!Regex.IsMatch(txtEmail.Text, PatternC)) 
            { throw new Exception("Invalid email!"); }

            //Check if email is unique
            if (!userService.CheckUniqueEmail(txtEmail.Text))
            { throw new Exception("Email is already in use!");  }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();
                HashWithSaltResult hashResultSha256 = tool.HashPassword(txtPassword.Text);
                User_Model user = new User_Model(txtFirstName.Text, txtLastName.Text, txtEmail.Text, hashResultSha256.Salt, hashResultSha256.Digest, (Role)cbUser.SelectedItem, (Location)cbLocation.SelectedItem, txtNumber.Text);
                
                userService.AddUser(user);
                ClearInputs();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user, try again. \nERROR: {ex.Message}");
            }

        }

        //Explanation on generating users
        //This is the approach I used to randomly generate 100+ users for the database using random names and numbers.
        //
        //Random rnd = new Random();
        //
        //private void GenerateUsers()
        //{
        //    List<User_Model> users = new List<User_Model>();
        //    int numberOfUsers = 100;

        //    for (int i = 0; i < numberOfUsers; i++)
        //    {
        //        HashWithSaltResult hashResultSha256 = tool.HashPassword(GeneratePassword());
        //        string[] name = GenerateName();

        //        User_Model user = new User_Model(name[0], name[1], GenerateEmail(name), hashResultSha256.Salt, hashResultSha256.Digest, Role.Employee, RandomLocation(), GenerateNumber());
        //        users.Add(user);
        //    }

        //    userService.AddMultipleUsers(users);
        //    MessageBox.Show("It didn't break!");
        //}

        //private string[] GenerateName()
        //{
        //    //Generate random first and last name from list of names
        //    string[] name = new string[2];

        //    const string fileName = "first-names.txt";
        //    string[] names = File.ReadAllLines(fileName);

        //    name[0] = names[rnd.Next(names.Length)];
        //    name[1] = names[rnd.Next(names.Length)];

        //    while (name[0] == name[1])
        //    {
        //        name[1] = names[rnd.Next(names.Length)];
        //    }

        //    return name;
        //}
        //private string GenerateEmail(string[] name)
        //{
        //    return $"{name[0]}{name[1]}@gmail.com";
        //}
        //private Location RandomLocation()
        //{
        //    Location[] locations = new Location[] { Model.Location.Haarlem, Model.Location.Amsterdam, Model.Location.Knuppeldam, Model.Location.HeadQuarters };
        //    return locations[rnd.Next(locations.Length)];
        //}
        //private string GenerateNumber()
        //{
        //    string number = "+31";
        //    const int numberOfDigits = 10;

        //    for (int i = 0; i < numberOfDigits; i++)
        //    {
        //        number += rnd.Next(10);
        //    }

        //    return number;
        //}

        //private string GeneratePassword()
        //{
        //    //
        //    //Generates a number password to simulate randomly generated passwords being sent.
        //    //  
        //   string password = null;
        //    const int Length = 5;
        //    Random rnd = new Random();

        //    for (int i = 0; i < Length; i++)
        //    {
        //        password += rnd.Next(10).ToString();
        //    }

        //    return password;
        //}
    }
}
