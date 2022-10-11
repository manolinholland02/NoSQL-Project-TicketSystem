﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using Model;
using MongoDB.Driver;

namespace UI
{
    public partial class NoDeskUI : Form
    {
        Databases databases;
        List<Ticket_Model> collection;

        public NoDeskUI()
        {
           
            InitializeComponent();
            databases=new Databases(); 
            collection = databases.GetCollection();
            DisplayTickets();
            HideAllPanel();
        }
        private void HideAllPanel()
        {
            pnlDashboard.Hide();
            pnlIncidentManagemnt.Hide();
            pnlUserManagement.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlIncidentManagemnt.Hide();
            pnlUserManagement.Hide();
            pnlDashboard.Show();
        }

        private void btnIncidentManagement_Click(object sender, EventArgs e)
        {

            pnlDashboard.Hide();
            pnlUserManagement.Hide();
            pnlIncidentManagemnt.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            pnlDashboard.Hide();
            pnlIncidentManagemnt.Hide();
            pnlUserManagement.Show();
        }

        //list all the tickets in the datagridview for the incident management

        private void DisplayTickets()
        {

            dGVTicketOverview.DataSource= collection;
         

        }

        private void pnlIncidentManagemnt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dGVTicketOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
