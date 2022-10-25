namespace UI
{
    partial class NoDeskUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenuCOntainer = new System.Windows.Forms.Panel();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIncidentManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlUserManagement = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlIncidentManagemnt = new System.Windows.Forms.Panel();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.dGVTicketOverview = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlMenuCOntainer.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            this.pnlIncidentManagemnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTicketOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuCOntainer
            // 
            this.pnlMenuCOntainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMenuCOntainer.Controls.Add(this.btnUserManagement);
            this.pnlMenuCOntainer.Controls.Add(this.label2);
            this.pnlMenuCOntainer.Controls.Add(this.btnIncidentManagement);
            this.pnlMenuCOntainer.Controls.Add(this.label1);
            this.pnlMenuCOntainer.Controls.Add(this.btnDashboard);
            this.pnlMenuCOntainer.Location = new System.Drawing.Point(0, 1);
            this.pnlMenuCOntainer.Name = "pnlMenuCOntainer";
            this.pnlMenuCOntainer.Size = new System.Drawing.Size(1124, 99);
            this.pnlMenuCOntainer.TabIndex = 0;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Location = new System.Drawing.Point(417, 44);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(213, 54);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // btnIncidentManagement
            // 
            this.btnIncidentManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIncidentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidentManagement.Location = new System.Drawing.Point(194, 45);
            this.btnIncidentManagement.Name = "btnIncidentManagement";
            this.btnIncidentManagement.Size = new System.Drawing.Size(213, 54);
            this.btnIncidentManagement.TabIndex = 1;
            this.btnIncidentManagement.Text = "Incident Management";
            this.btnIncidentManagement.UseVisualStyleBackColor = false;
            this.btnIncidentManagement.Click += new System.EventHandler(this.btnIncidentManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(900, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "NoDesk";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(22, 45);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(147, 54);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.pnlUserManagement);
            this.pnlDashboard.Controls.Add(this.label3);
            this.pnlDashboard.Location = new System.Drawing.Point(22, 134);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1075, 493);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Controls.Add(this.label5);
            this.pnlUserManagement.Location = new System.Drawing.Point(0, 13);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(990, 392);
            this.pnlUserManagement.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "User Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "This is DashBoard. You can do your part here ";
            // 
            // pnlIncidentManagemnt
            // 
            this.pnlIncidentManagemnt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlIncidentManagemnt.Controls.Add(this.btnDeleteTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.btnUpdateTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.label4);
            this.pnlIncidentManagemnt.Controls.Add(this.txtSearch);
            this.pnlIncidentManagemnt.Controls.Add(this.btnCreateIncident);
            this.pnlIncidentManagemnt.Controls.Add(this.dGVTicketOverview);
            this.pnlIncidentManagemnt.Location = new System.Drawing.Point(59, 106);
            this.pnlIncidentManagemnt.Name = "pnlIncidentManagemnt";
            this.pnlIncidentManagemnt.Size = new System.Drawing.Size(963, 476);
            this.pnlIncidentManagemnt.TabIndex = 0;
            this.pnlIncidentManagemnt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIncidentManagemnt_Paint);
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Location = new System.Drawing.Point(148, 418);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(72, 34);
            this.btnDeleteTicket.TabIndex = 10;
            this.btnDeleteTicket.Text = "Delete";
            this.btnDeleteTicket.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.Location = new System.Drawing.Point(35, 417);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(88, 35);
            this.btnUpdateTicket.TabIndex = 10;
            this.btnUpdateTicket.Text = "Update";
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ticket overview";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(35, 59);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Text = "search by email";
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.Location = new System.Drawing.Point(721, 59);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(116, 28);
            this.btnCreateIncident.TabIndex = 7;
            this.btnCreateIncident.Text = "Create Incident";
            this.btnCreateIncident.UseVisualStyleBackColor = true;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // dGVTicketOverview
            // 
            this.dGVTicketOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTicketOverview.Location = new System.Drawing.Point(33, 112);
            this.dGVTicketOverview.Name = "dGVTicketOverview";
            this.dGVTicketOverview.RowHeadersWidth = 51;
            this.dGVTicketOverview.RowTemplate.Height = 24;
            this.dGVTicketOverview.Size = new System.Drawing.Size(804, 275);
            this.dGVTicketOverview.TabIndex = 6;
            this.dGVTicketOverview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVTicketOverview_CellContentClick);
            // 
            // NoDeskUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 653);
            this.Controls.Add(this.pnlIncidentManagemnt);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlMenuCOntainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoDeskUI";
            this.Text = "NoDeskUI";
            this.pnlMenuCOntainer.ResumeLayout(false);
            this.pnlMenuCOntainer.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlUserManagement.ResumeLayout(false);
            this.pnlUserManagement.PerformLayout();
            this.pnlIncidentManagemnt.ResumeLayout(false);
            this.pnlIncidentManagemnt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTicketOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuCOntainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnIncidentManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlIncidentManagemnt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.DataGridView dGVTicketOverview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Button btnUpdateTicket;
    }
}