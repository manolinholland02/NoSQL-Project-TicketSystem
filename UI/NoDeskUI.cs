using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class NoDeskUI : Form
    {
        public NoDeskUI()
        {
            InitializeComponent();
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
    }
}
