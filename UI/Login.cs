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
using MongoDB.Driver;
using MongoDB.Bson;

namespace UI
{
    public partial class Login : Form
    {
        private UserService userService;
        private User_Model user;

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

            user = GetUserByUsernameAndPassword();

            if (user != null)
            {
                NoDeskUI noDeskUI = new NoDeskUI(user);
                this.Hide();
                noDeskUI.Show();
            }     
        }

        private User_Model GetUserByUsernameAndPassword()
        {    
            var filter = Builders<User_Model>.Filter.Eq(s => s.Email, txtUsername.Text) & Builders<User_Model>.Filter.Eq(s => s.Password, txtPassword.Text);
            var user = userService.GetUserCollection().Find(filter).FirstOrDefault();

            if (user == null)
            {
                lblLoginError.Text = "incorrect login credentials";
            }
            return user;
        }
    }
}
