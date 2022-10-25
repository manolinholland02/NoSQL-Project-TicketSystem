using Model;
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
    public partial class CreateTicket : Form
    {
        public CreateTicket()
        {
            InitializeComponent();
            cbPriority.DataSource = Enum.GetValues(typeof(Priority));       

            cbDeadline.DataSource = Enum.GetValues(typeof(Deadline)).
                                    Cast<Deadline>()
                                    .Select(x => (int)x)
                                    .ToList();

        }

        private void btnSubmitIncident_Click(object sender, EventArgs e)
        {

        }
    
    }
}
