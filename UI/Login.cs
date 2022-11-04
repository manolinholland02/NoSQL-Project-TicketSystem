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

            if (GetUserByUsernameAndPassword())
            {
                this.Close();
                NoDeskUI noDeskUI = new NoDeskUI();
                //noDeskUI.Closed += (ss, ee) => this.Close();
                noDeskUI.Show();
            }
        }

        private bool GetUserByUsernameAndPassword()
        {    
            var filter = Builders<User_Model>.Filter.Eq(s => s.Email, txtUsername.Text) & Builders<User_Model>.Filter.Eq(s => s.Password, txtPassword.Text);
            var user = userService.GetUserCollection().Find(filter).FirstOrDefault();
            
            if(user == null)
            {
                lblLoginError.Text = "incorrect login credentials";
                return false;
            }
            return true;
        }
    }
}
