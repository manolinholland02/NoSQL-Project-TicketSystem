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
        private User_Model loggedUser;
        private HashTool tool;

        public Login()
        {
            InitializeComponent();
            userService = UserService.GetInstance();
            tool = new HashTool();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User_Model user = userService.GetUserByEmail(txtEmail.Text);
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                lblLoginError.Text = "Please fill in all fields";
                return;
            }

            if (GetUserByUsernameAndPassword(user) != null)
            {           
                NoDeskUI noDeskUI = new NoDeskUI(loggedUser);
                Hide();
                noDeskUI.ShowDialog();
                Close();
            }
            else{
                lblLoginError.Text = "incorrect login credentials";
            }
        }

        private User_Model GetUserByUsernameAndPassword(User_Model user)
        {    
            string result = tool.HashPassword(txtPassword.Text, user.Salt).Digest;
            var filter = Builders<User_Model>.Filter.Eq(s => s.Email, txtEmail.Text) & Builders<User_Model>.Filter.Eq(s => s.Digest, result);
            loggedUser = userService.GetUserCollection().Find(filter).FirstOrDefault();

            return loggedUser;
        }
    }
}
