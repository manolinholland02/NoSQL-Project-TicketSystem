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
        private TicketService databases;
        public Login()
        {
            InitializeComponent();
            databases = new TicketService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NoDeskUI noDeskUI = new NoDeskUI();
            noDeskUI.Show();
        }
    }
}
