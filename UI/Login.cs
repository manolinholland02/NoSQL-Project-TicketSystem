using System;
using System.Linq;
using System.Windows.Forms;
using Model;
using Logic;
using MongoDB.Driver;

namespace UI
{
    public partial class Login : Form
    {
        private UserService userService;
        private User_Model loggedUser;

        public Login()
        {
            InitializeComponent();
            userService = UserService.GetInstance();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblLoginError.Text = "Please fill in all fields";
                return;
            }

            if (GetUserByUsernameAndPassword() != null)
            {           
                NoDeskUI noDeskUI = new NoDeskUI(loggedUser);
                this.Hide();
                noDeskUI.Show();
            }
            else{
                lblLoginError.Text = "incorrect login credentials";
            }
        }

        private User_Model GetUserByUsernameAndPassword()
        {    
            var filter = Builders<User_Model>.Filter.Eq(s => s.Email, txtUsername.Text) & Builders<User_Model>.Filter.Eq(s => s.Password, txtPassword.Text);
            loggedUser = userService.GetUserCollection().Find(filter).FirstOrDefault();

            return loggedUser;
        }
    }
}
