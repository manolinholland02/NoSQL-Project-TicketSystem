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
        private Databases databases;
        public Login()
        {
            InitializeComponent();
            databases = new Databases();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var dbList = databases.Get_All_Databases();

            foreach (var db in dbList)
            {
                listBox1.Items.Add(db.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NoDeskUI().Show();
        }
    }
}
