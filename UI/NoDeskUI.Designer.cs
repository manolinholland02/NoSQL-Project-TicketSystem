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
            this.components = new System.ComponentModel.Container();
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
            this.txtTicketNr = new System.Windows.Forms.TextBox();
            this.btnSearchOr = new System.Windows.Forms.Button();
            this.btnAndSearch = new System.Windows.Forms.Button();
            this.comboBoxPriorityOr = new System.Windows.Forms.ComboBox();
            this.comboBoxPriorityAnd = new System.Windows.Forms.ComboBox();
            this.comboBoxStatusOr = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStatusAnd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSearchByTicket = new System.Windows.Forms.Button();
            this.btnSearchBySubject = new System.Windows.Forms.Button();
            this.dateTimePickerTicket = new System.Windows.Forms.DateTimePicker();
            this.cbDeadline = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTicketSearch = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.dataGVTicketOverview = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlMenuCOntainer.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            this.pnlIncidentManagemnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTicketOverview)).BeginInit();
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
            this.pnlDashboard.Controls.Add(this.label3);
            this.pnlDashboard.Location = new System.Drawing.Point(22, 134);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1075, 493);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Controls.Add(this.label5);
            this.pnlUserManagement.Location = new System.Drawing.Point(63, 154);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(990, 470);
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
            this.pnlIncidentManagemnt.Controls.Add(this.txtTicketNr);
            this.pnlIncidentManagemnt.Controls.Add(this.btnSearchOr);
            this.pnlIncidentManagemnt.Controls.Add(this.btnAndSearch);
            this.pnlIncidentManagemnt.Controls.Add(this.comboBoxPriorityOr);
            this.pnlIncidentManagemnt.Controls.Add(this.comboBoxPriorityAnd);
            this.pnlIncidentManagemnt.Controls.Add(this.comboBoxStatusOr);
            this.pnlIncidentManagemnt.Controls.Add(this.label7);
            this.pnlIncidentManagemnt.Controls.Add(this.comboBoxStatusAnd);
            this.pnlIncidentManagemnt.Controls.Add(this.label6);
            this.pnlIncidentManagemnt.Controls.Add(this.buttonSearchByTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.btnSearchBySubject);
            this.pnlIncidentManagemnt.Controls.Add(this.dateTimePickerTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.cbDeadline);
            this.pnlIncidentManagemnt.Controls.Add(this.cbPriority);
            this.pnlIncidentManagemnt.Controls.Add(this.txtSubject);
            this.pnlIncidentManagemnt.Controls.Add(this.btnDeleteTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.btnUpdateTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.label4);
            this.pnlIncidentManagemnt.Controls.Add(this.textBoxTicketSearch);
            this.pnlIncidentManagemnt.Controls.Add(this.txtSearch);
            this.pnlIncidentManagemnt.Controls.Add(this.btnCreateIncident);
            this.pnlIncidentManagemnt.Controls.Add(this.dataGVTicketOverview);
            this.pnlIncidentManagemnt.Location = new System.Drawing.Point(46, 120);
            this.pnlIncidentManagemnt.Name = "pnlIncidentManagemnt";
            this.pnlIncidentManagemnt.Size = new System.Drawing.Size(1035, 521);
            this.pnlIncidentManagemnt.TabIndex = 0;
            this.pnlIncidentManagemnt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIncidentManagemnt_Paint);
            // 
            // txtTicketNr
            // 
            this.txtTicketNr.Location = new System.Drawing.Point(806, 178);
            this.txtTicketNr.Name = "txtTicketNr";
            this.txtTicketNr.Size = new System.Drawing.Size(148, 22);
            this.txtTicketNr.TabIndex = 19;
            // 
            // btnSearchOr
            // 
            this.btnSearchOr.Location = new System.Drawing.Point(656, 150);
            this.btnSearchOr.Name = "btnSearchOr";
            this.btnSearchOr.Size = new System.Drawing.Size(75, 23);
            this.btnSearchOr.TabIndex = 18;
            this.btnSearchOr.Text = "Search";
            this.btnSearchOr.UseVisualStyleBackColor = true;
            this.btnSearchOr.Click += new System.EventHandler(this.btnSearchOr_Click);
            // 
            // btnAndSearch
            // 
            this.btnAndSearch.Location = new System.Drawing.Point(441, 150);
            this.btnAndSearch.Name = "btnAndSearch";
            this.btnAndSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAndSearch.TabIndex = 18;
            this.btnAndSearch.Text = "Search";
            this.btnAndSearch.UseVisualStyleBackColor = true;
            this.btnAndSearch.Click += new System.EventHandler(this.btnAndSearch_Click);
            // 
            // comboBoxPriorityOr
            // 
            this.comboBoxPriorityOr.FormattingEnabled = true;
            this.comboBoxPriorityOr.Location = new System.Drawing.Point(656, 109);
            this.comboBoxPriorityOr.Name = "comboBoxPriorityOr";
            this.comboBoxPriorityOr.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPriorityOr.TabIndex = 17;
            // 
            // comboBoxPriorityAnd
            // 
            this.comboBoxPriorityAnd.FormattingEnabled = true;
            this.comboBoxPriorityAnd.Location = new System.Drawing.Point(441, 109);
            this.comboBoxPriorityAnd.Name = "comboBoxPriorityAnd";
            this.comboBoxPriorityAnd.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPriorityAnd.TabIndex = 17;
            // 
            // comboBoxStatusOr
            // 
            this.comboBoxStatusOr.FormattingEnabled = true;
            this.comboBoxStatusOr.Location = new System.Drawing.Point(656, 66);
            this.comboBoxStatusOr.Name = "comboBoxStatusOr";
            this.comboBoxStatusOr.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatusOr.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search by status or priority:";
            // 
            // comboBoxStatusAnd
            // 
            this.comboBoxStatusAnd.FormattingEnabled = true;
            this.comboBoxStatusAnd.Location = new System.Drawing.Point(441, 66);
            this.comboBoxStatusAnd.Name = "comboBoxStatusAnd";
            this.comboBoxStatusAnd.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatusAnd.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search by status and priority:";
            // 
            // buttonSearchByTicket
            // 
            this.buttonSearchByTicket.Location = new System.Drawing.Point(200, 99);
            this.buttonSearchByTicket.Name = "buttonSearchByTicket";
            this.buttonSearchByTicket.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchByTicket.TabIndex = 14;
            this.buttonSearchByTicket.Text = "Search";
            this.buttonSearchByTicket.UseVisualStyleBackColor = true;
            this.buttonSearchByTicket.Click += new System.EventHandler(this.buttonSearchByTicket_Click);
            // 
            // btnSearchBySubject
            // 
            this.btnSearchBySubject.Location = new System.Drawing.Point(39, 99);
            this.btnSearchBySubject.Name = "btnSearchBySubject";
            this.btnSearchBySubject.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBySubject.TabIndex = 14;
            this.btnSearchBySubject.Text = "Search";
            this.btnSearchBySubject.UseVisualStyleBackColor = true;
            this.btnSearchBySubject.Click += new System.EventHandler(this.btnSearchBySubject_Click);
            // 
            // dateTimePickerTicket
            // 
            this.dateTimePickerTicket.Location = new System.Drawing.Point(806, 334);
            this.dateTimePickerTicket.Name = "dateTimePickerTicket";
            this.dateTimePickerTicket.Size = new System.Drawing.Size(216, 22);
            this.dateTimePickerTicket.TabIndex = 13;
            // 
            // cbDeadline
            // 
            this.cbDeadline.FormattingEnabled = true;
            this.cbDeadline.Location = new System.Drawing.Point(806, 286);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(148, 24);
            this.cbDeadline.TabIndex = 12;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(806, 231);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(148, 24);
            this.cbPriority.TabIndex = 12;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(806, 178);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(148, 22);
            this.txtSubject.TabIndex = 11;
            this.txtSubject.Text = "subject";
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Location = new System.Drawing.Point(705, 470);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(72, 34);
            this.btnDeleteTicket.TabIndex = 10;
            this.btnDeleteTicket.Text = "Delete";
            this.btnDeleteTicket.UseVisualStyleBackColor = true;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.Location = new System.Drawing.Point(806, 410);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(88, 35);
            this.btnUpdateTicket.TabIndex = 10;
            this.btnUpdateTicket.Text = "Update";
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ticket overview";
            // 
            // textBoxTicketSearch
            // 
            this.textBoxTicketSearch.Location = new System.Drawing.Point(200, 59);
            this.textBoxTicketSearch.Name = "textBoxTicketSearch";
            this.textBoxTicketSearch.Size = new System.Drawing.Size(145, 22);
            this.textBoxTicketSearch.TabIndex = 8;
            this.textBoxTicketSearch.Text = "search by ticketNr";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(39, 59);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Text = "search by subject";
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.Location = new System.Drawing.Point(549, 470);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(116, 34);
            this.btnCreateIncident.TabIndex = 7;
            this.btnCreateIncident.Text = "Create Incident";
            this.btnCreateIncident.UseVisualStyleBackColor = true;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // dataGVTicketOverview
            // 
            this.dataGVTicketOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTicketOverview.Location = new System.Drawing.Point(33, 183);
            this.dataGVTicketOverview.Name = "dataGVTicketOverview";
            this.dataGVTicketOverview.RowHeadersWidth = 51;
            this.dataGVTicketOverview.RowTemplate.Height = 24;
            this.dataGVTicketOverview.Size = new System.Drawing.Size(744, 263);
            this.dataGVTicketOverview.TabIndex = 6;
            this.dataGVTicketOverview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVTicketOverview_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NoDeskUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 653);
            this.Controls.Add(this.pnlUserManagement);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTicketOverview)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGVTicketOverview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTicket;
        private System.Windows.Forms.ComboBox cbDeadline;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchBySubject;
        private System.Windows.Forms.Button btnSearchOr;
        private System.Windows.Forms.Button btnAndSearch;
        private System.Windows.Forms.ComboBox comboBoxPriorityOr;
        private System.Windows.Forms.ComboBox comboBoxPriorityAnd;
        private System.Windows.Forms.ComboBox comboBoxStatusOr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStatusAnd;
        private System.Windows.Forms.Button buttonSearchByTicket;
        private System.Windows.Forms.TextBox textBoxTicketSearch;
        private System.Windows.Forms.TextBox txtTicketNr;
    }
}