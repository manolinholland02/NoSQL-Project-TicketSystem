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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIncidentManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.lblSubtitle1 = new System.Windows.Forms.Label();
            this.lblIncidentsPastDeadline = new System.Windows.Forms.Label();
            this.lblUnresolvedIncidents = new System.Windows.Forms.Label();
            this.progressBarIncidentsPastDeadline = new CircularProgressBar.CircularProgressBar();
            this.progressBarUnresolvedIncidents = new CircularProgressBar.CircularProgressBar();
            this.btnShowList = new System.Windows.Forms.Button();
            this.lblCurrentIncidents = new System.Windows.Forms.Label();
            this.pnlUserManagement = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnRefreshUser = new System.Windows.Forms.Button();
            this.dataGVUser = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlIncidentManagemnt = new System.Windows.Forms.Panel();
            this.btnTransferTicket = new System.Windows.Forms.Button();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFilterByType = new System.Windows.Forms.ComboBox();
            this.btnRecentTicket = new System.Windows.Forms.Button();
            this.txtTicketNr = new System.Windows.Forms.TextBox();
            this.btnSearchOr = new System.Windows.Forms.Button();
            this.btnAndSearch = new System.Windows.Forms.Button();
            this.comboBoxPriorityOr = new System.Windows.Forms.ComboBox();
            this.comboBoxPriorityAnd = new System.Windows.Forms.ComboBox();
            this.comboBoxStatusOr = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStatusAnd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMenuCOntainer.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUser)).BeginInit();
            this.pnlIncidentManagemnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTicketOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuCOntainer
            // 
            this.pnlMenuCOntainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMenuCOntainer.Controls.Add(this.btnLogout);
            this.pnlMenuCOntainer.Controls.Add(this.btnUserManagement);
            this.pnlMenuCOntainer.Controls.Add(this.label2);
            this.pnlMenuCOntainer.Controls.Add(this.btnIncidentManagement);
            this.pnlMenuCOntainer.Controls.Add(this.label1);
            this.pnlMenuCOntainer.Controls.Add(this.btnDashboard);
            this.pnlMenuCOntainer.Location = new System.Drawing.Point(0, 1);
            this.pnlMenuCOntainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenuCOntainer.Name = "pnlMenuCOntainer";
            this.pnlMenuCOntainer.Size = new System.Drawing.Size(1102, 80);
            this.pnlMenuCOntainer.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Brown;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(499, 37);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(114, 44);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Location = new System.Drawing.Point(313, 36);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(160, 44);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(746, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // btnIncidentManagement
            // 
            this.btnIncidentManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIncidentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidentManagement.Location = new System.Drawing.Point(146, 37);
            this.btnIncidentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncidentManagement.Name = "btnIncidentManagement";
            this.btnIncidentManagement.Size = new System.Drawing.Size(160, 44);
            this.btnIncidentManagement.TabIndex = 1;
            this.btnIncidentManagement.Text = "Incident Management";
            this.btnIncidentManagement.UseVisualStyleBackColor = false;
            this.btnIncidentManagement.Click += new System.EventHandler(this.btnIncidentManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(934, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "NoDesk";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(16, 37);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(110, 44);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.White;
            this.pnlDashboard.Controls.Add(this.lblSubtitle2);
            this.pnlDashboard.Controls.Add(this.lblSubtitle1);
            this.pnlDashboard.Controls.Add(this.lblIncidentsPastDeadline);
            this.pnlDashboard.Controls.Add(this.lblUnresolvedIncidents);
            this.pnlDashboard.Controls.Add(this.progressBarIncidentsPastDeadline);
            this.pnlDashboard.Controls.Add(this.progressBarUnresolvedIncidents);
            this.pnlDashboard.Controls.Add(this.btnShowList);
            this.pnlDashboard.Controls.Add(this.lblCurrentIncidents);
            this.pnlDashboard.Location = new System.Drawing.Point(16, 112);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(806, 401);
            this.pnlDashboard.TabIndex = 1;
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSubtitle2.Location = new System.Drawing.Point(501, 99);
            this.lblSubtitle2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(327, 17);
            this.lblSubtitle2.TabIndex = 11;
            this.lblSubtitle2.Text = "These tickets need your imeediate attention";
            // 
            // lblSubtitle1
            // 
            this.lblSubtitle1.AutoSize = true;
            this.lblSubtitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSubtitle1.Location = new System.Drawing.Point(100, 99);
            this.lblSubtitle1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle1.Name = "lblSubtitle1";
            this.lblSubtitle1.Size = new System.Drawing.Size(188, 17);
            this.lblSubtitle1.TabIndex = 10;
            this.lblSubtitle1.Text = "All tickets currently open";
            // 
            // lblIncidentsPastDeadline
            // 
            this.lblIncidentsPastDeadline.AutoSize = true;
            this.lblIncidentsPastDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentsPastDeadline.ForeColor = System.Drawing.Color.DimGray;
            this.lblIncidentsPastDeadline.Location = new System.Drawing.Point(520, 76);
            this.lblIncidentsPastDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidentsPastDeadline.Name = "lblIncidentsPastDeadline";
            this.lblIncidentsPastDeadline.Size = new System.Drawing.Size(225, 24);
            this.lblIncidentsPastDeadline.TabIndex = 9;
            this.lblIncidentsPastDeadline.Text = "Incidents past deadline";
            // 
            // lblUnresolvedIncidents
            // 
            this.lblUnresolvedIncidents.AutoSize = true;
            this.lblUnresolvedIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnresolvedIncidents.ForeColor = System.Drawing.Color.DimGray;
            this.lblUnresolvedIncidents.Location = new System.Drawing.Point(82, 76);
            this.lblUnresolvedIncidents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnresolvedIncidents.Name = "lblUnresolvedIncidents";
            this.lblUnresolvedIncidents.Size = new System.Drawing.Size(206, 24);
            this.lblUnresolvedIncidents.TabIndex = 8;
            this.lblUnresolvedIncidents.Text = "Unresolved incidents";
            // 
            // progressBarIncidentsPastDeadline
            // 
            this.progressBarIncidentsPastDeadline.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBarIncidentsPastDeadline.AnimationSpeed = 500;
            this.progressBarIncidentsPastDeadline.BackColor = System.Drawing.Color.Transparent;
            this.progressBarIncidentsPastDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progressBarIncidentsPastDeadline.ForeColor = System.Drawing.Color.Silver;
            this.progressBarIncidentsPastDeadline.InnerColor = System.Drawing.Color.White;
            this.progressBarIncidentsPastDeadline.InnerMargin = 2;
            this.progressBarIncidentsPastDeadline.InnerWidth = -1;
            this.progressBarIncidentsPastDeadline.Location = new System.Drawing.Point(491, 131);
            this.progressBarIncidentsPastDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarIncidentsPastDeadline.MarqueeAnimationSpeed = 2000;
            this.progressBarIncidentsPastDeadline.Name = "progressBarIncidentsPastDeadline";
            this.progressBarIncidentsPastDeadline.OuterColor = System.Drawing.Color.Silver;
            this.progressBarIncidentsPastDeadline.OuterMargin = -46;
            this.progressBarIncidentsPastDeadline.OuterWidth = 46;
            this.progressBarIncidentsPastDeadline.ProgressColor = System.Drawing.Color.Firebrick;
            this.progressBarIncidentsPastDeadline.ProgressWidth = 46;
            this.progressBarIncidentsPastDeadline.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBarIncidentsPastDeadline.Size = new System.Drawing.Size(232, 239);
            this.progressBarIncidentsPastDeadline.StartAngle = 270;
            this.progressBarIncidentsPastDeadline.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarIncidentsPastDeadline.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBarIncidentsPastDeadline.SubscriptText = "";
            this.progressBarIncidentsPastDeadline.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarIncidentsPastDeadline.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBarIncidentsPastDeadline.SuperscriptText = "";
            this.progressBarIncidentsPastDeadline.TabIndex = 7;
            this.progressBarIncidentsPastDeadline.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBarIncidentsPastDeadline.Value = 68;
            // 
            // progressBarUnresolvedIncidents
            // 
            this.progressBarUnresolvedIncidents.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBarUnresolvedIncidents.AnimationSpeed = 500;
            this.progressBarUnresolvedIncidents.BackColor = System.Drawing.Color.Transparent;
            this.progressBarUnresolvedIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progressBarUnresolvedIncidents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBarUnresolvedIncidents.InnerColor = System.Drawing.Color.White;
            this.progressBarUnresolvedIncidents.InnerMargin = 2;
            this.progressBarUnresolvedIncidents.InnerWidth = -1;
            this.progressBarUnresolvedIncidents.Location = new System.Drawing.Point(58, 131);
            this.progressBarUnresolvedIncidents.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarUnresolvedIncidents.MarqueeAnimationSpeed = 2000;
            this.progressBarUnresolvedIncidents.Name = "progressBarUnresolvedIncidents";
            this.progressBarUnresolvedIncidents.OuterColor = System.Drawing.Color.Silver;
            this.progressBarUnresolvedIncidents.OuterMargin = -46;
            this.progressBarUnresolvedIncidents.OuterWidth = 46;
            this.progressBarUnresolvedIncidents.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBarUnresolvedIncidents.ProgressWidth = 46;
            this.progressBarUnresolvedIncidents.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBarUnresolvedIncidents.Size = new System.Drawing.Size(232, 239);
            this.progressBarUnresolvedIncidents.StartAngle = 270;
            this.progressBarUnresolvedIncidents.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarUnresolvedIncidents.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBarUnresolvedIncidents.SubscriptText = "";
            this.progressBarUnresolvedIncidents.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarUnresolvedIncidents.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBarUnresolvedIncidents.SuperscriptText = "";
            this.progressBarUnresolvedIncidents.TabIndex = 6;
            this.progressBarUnresolvedIncidents.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBarUnresolvedIncidents.Value = 68;
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowList.Location = new System.Drawing.Point(644, 13);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(129, 39);
            this.btnShowList.TabIndex = 4;
            this.btnShowList.Text = "SHOW LIST";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // lblCurrentIncidents
            // 
            this.lblCurrentIncidents.AutoSize = true;
            this.lblCurrentIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIncidents.Location = new System.Drawing.Point(19, 21);
            this.lblCurrentIncidents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentIncidents.Name = "lblCurrentIncidents";
            this.lblCurrentIncidents.Size = new System.Drawing.Size(258, 36);
            this.lblCurrentIncidents.TabIndex = 3;
            this.lblCurrentIncidents.Text = "Current incidents";
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Controls.Add(this.btnDeleteUser);
            this.pnlUserManagement.Controls.Add(this.btnRefreshUser);
            this.pnlUserManagement.Controls.Add(this.dataGVUser);
            this.pnlUserManagement.Controls.Add(this.btnAddEmployee);
            this.pnlUserManagement.Controls.Add(this.label5);
            this.pnlUserManagement.Location = new System.Drawing.Point(9, 85);
            this.pnlUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(1071, 474);
            this.pnlUserManagement.TabIndex = 1;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(728, 433);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(89, 25);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnRefreshUser
            // 
            this.btnRefreshUser.Location = new System.Drawing.Point(728, 46);
            this.btnRefreshUser.Name = "btnRefreshUser";
            this.btnRefreshUser.Size = new System.Drawing.Size(92, 27);
            this.btnRefreshUser.TabIndex = 5;
            this.btnRefreshUser.Text = "Refresh";
            this.btnRefreshUser.UseVisualStyleBackColor = true;
            this.btnRefreshUser.Click += new System.EventHandler(this.btnRefreshUser_Click);
            // 
            // dataGVUser
            // 
            this.dataGVUser.AllowUserToAddRows = false;
            this.dataGVUser.AllowUserToDeleteRows = false;
            this.dataGVUser.AllowUserToResizeColumns = false;
            this.dataGVUser.AllowUserToResizeRows = false;
            this.dataGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUser.Location = new System.Drawing.Point(36, 110);
            this.dataGVUser.Margin = new System.Windows.Forms.Padding(2);
            this.dataGVUser.MultiSelect = false;
            this.dataGVUser.Name = "dataGVUser";
            this.dataGVUser.ReadOnly = true;
            this.dataGVUser.RowHeadersWidth = 51;
            this.dataGVUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGVUser.RowTemplate.Height = 24;
            this.dataGVUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVUser.Size = new System.Drawing.Size(784, 294);
            this.dataGVUser.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(640, 433);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(82, 27);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "User Management";
            // 
            // pnlIncidentManagemnt
            // 
            this.pnlIncidentManagemnt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlIncidentManagemnt.Controls.Add(this.btnTransferTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.btnCloseTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.label9);
            this.pnlIncidentManagemnt.Controls.Add(this.cbFilterByType);
            this.pnlIncidentManagemnt.Controls.Add(this.btnRecentTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.txtTicketNr);
            this.pnlIncidentManagemnt.Controls.Add(this.btnSearchOr);
            this.pnlIncidentManagemnt.Controls.Add(this.btnAndSearch);
            this.pnlIncidentManagemnt.Controls.Add(this.comboBoxPriorityOr);
            this.pnlIncidentManagemnt.Controls.Add(this.comboBoxPriorityAnd);
            this.pnlIncidentManagemnt.Controls.Add(this.comboBoxStatusOr);
            this.pnlIncidentManagemnt.Controls.Add(this.label7);
            this.pnlIncidentManagemnt.Controls.Add(this.comboBoxStatusAnd);
            this.pnlIncidentManagemnt.Controls.Add(this.label8);
            this.pnlIncidentManagemnt.Controls.Add(this.label3);
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
            this.pnlIncidentManagemnt.Location = new System.Drawing.Point(9, 87);
            this.pnlIncidentManagemnt.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIncidentManagemnt.Name = "pnlIncidentManagemnt";
            this.pnlIncidentManagemnt.Size = new System.Drawing.Size(1073, 474);
            this.pnlIncidentManagemnt.TabIndex = 0;
            this.pnlIncidentManagemnt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIncidentManagemnt_Paint);
            // 
            // btnTransferTicket
            // 
            this.btnTransferTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTransferTicket.Location = new System.Drawing.Point(964, 382);
            this.btnTransferTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransferTicket.Name = "btnTransferTicket";
            this.btnTransferTicket.Size = new System.Drawing.Size(90, 28);
            this.btnTransferTicket.TabIndex = 24;
            this.btnTransferTicket.Text = "Transfer Ticket";
            this.btnTransferTicket.UseVisualStyleBackColor = false;
            this.btnTransferTicket.Click += new System.EventHandler(this.btnTransferTicket_Click);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseTicket.Location = new System.Drawing.Point(806, 426);
            this.btnCloseTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(84, 29);
            this.btnCloseTicket.TabIndex = 23;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = false;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(751, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Filter by incident type:";
            // 
            // cbFilterByType
            // 
            this.cbFilterByType.FormattingEnabled = true;
            this.cbFilterByType.Location = new System.Drawing.Point(754, 76);
            this.cbFilterByType.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterByType.Name = "cbFilterByType";
            this.cbFilterByType.Size = new System.Drawing.Size(92, 21);
            this.cbFilterByType.TabIndex = 21;
            // 
            // btnRecentTicket
            // 
            this.btnRecentTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRecentTicket.Location = new System.Drawing.Point(806, 139);
            this.btnRecentTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecentTicket.Name = "btnRecentTicket";
            this.btnRecentTicket.Size = new System.Drawing.Size(82, 28);
            this.btnRecentTicket.TabIndex = 20;
            this.btnRecentTicket.Text = "Recent ticket";
            this.btnRecentTicket.UseVisualStyleBackColor = false;
            this.btnRecentTicket.Click += new System.EventHandler(this.btnRecentTicket_Click);
            // 
            // txtTicketNr
            // 
            this.txtTicketNr.Location = new System.Drawing.Point(906, 184);
            this.txtTicketNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtTicketNr.Name = "txtTicketNr";
            this.txtTicketNr.Size = new System.Drawing.Size(112, 20);
            this.txtTicketNr.TabIndex = 19;
            // 
            // btnSearchOr
            // 
            this.btnSearchOr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchOr.Location = new System.Drawing.Point(521, 141);
            this.btnSearchOr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchOr.Name = "btnSearchOr";
            this.btnSearchOr.Size = new System.Drawing.Size(54, 28);
            this.btnSearchOr.TabIndex = 18;
            this.btnSearchOr.Text = "Search";
            this.btnSearchOr.UseVisualStyleBackColor = false;
            this.btnSearchOr.Click += new System.EventHandler(this.btnSearchOr_Click);
            // 
            // btnAndSearch
            // 
            this.btnAndSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAndSearch.Location = new System.Drawing.Point(308, 139);
            this.btnAndSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndSearch.Name = "btnAndSearch";
            this.btnAndSearch.Size = new System.Drawing.Size(54, 28);
            this.btnAndSearch.TabIndex = 18;
            this.btnAndSearch.Text = "Search";
            this.btnAndSearch.UseVisualStyleBackColor = false;
            this.btnAndSearch.Click += new System.EventHandler(this.btnAndSearch_Click);
            // 
            // comboBoxPriorityOr
            // 
            this.comboBoxPriorityOr.FormattingEnabled = true;
            this.comboBoxPriorityOr.Location = new System.Drawing.Point(521, 110);
            this.comboBoxPriorityOr.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPriorityOr.Name = "comboBoxPriorityOr";
            this.comboBoxPriorityOr.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPriorityOr.TabIndex = 17;
            // 
            // comboBoxPriorityAnd
            // 
            this.comboBoxPriorityAnd.FormattingEnabled = true;
            this.comboBoxPriorityAnd.Location = new System.Drawing.Point(308, 108);
            this.comboBoxPriorityAnd.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPriorityAnd.Name = "comboBoxPriorityAnd";
            this.comboBoxPriorityAnd.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPriorityAnd.TabIndex = 17;
            // 
            // comboBoxStatusOr
            // 
            this.comboBoxStatusOr.FormattingEnabled = true;
            this.comboBoxStatusOr.Location = new System.Drawing.Point(521, 76);
            this.comboBoxStatusOr.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStatusOr.Name = "comboBoxStatusOr";
            this.comboBoxStatusOr.Size = new System.Drawing.Size(92, 21);
            this.comboBoxStatusOr.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(519, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search by status or priority:";
            // 
            // comboBoxStatusAnd
            // 
            this.comboBoxStatusAnd.FormattingEnabled = true;
            this.comboBoxStatusAnd.Location = new System.Drawing.Point(308, 74);
            this.comboBoxStatusAnd.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStatusAnd.Name = "comboBoxStatusAnd";
            this.comboBoxStatusAnd.Size = new System.Drawing.Size(92, 21);
            this.comboBoxStatusAnd.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search by ticketNr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Search by subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search by status and priority:";
            // 
            // buttonSearchByTicket
            // 
            this.buttonSearchByTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSearchByTicket.Location = new System.Drawing.Point(161, 139);
            this.buttonSearchByTicket.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchByTicket.Name = "buttonSearchByTicket";
            this.buttonSearchByTicket.Size = new System.Drawing.Size(54, 28);
            this.buttonSearchByTicket.TabIndex = 14;
            this.buttonSearchByTicket.Text = "Search";
            this.buttonSearchByTicket.UseVisualStyleBackColor = false;
            this.buttonSearchByTicket.Click += new System.EventHandler(this.buttonSearchByTicket_Click);
            // 
            // btnSearchBySubject
            // 
            this.btnSearchBySubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchBySubject.Location = new System.Drawing.Point(25, 139);
            this.btnSearchBySubject.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchBySubject.Name = "btnSearchBySubject";
            this.btnSearchBySubject.Size = new System.Drawing.Size(54, 28);
            this.btnSearchBySubject.TabIndex = 14;
            this.btnSearchBySubject.Text = "Search";
            this.btnSearchBySubject.UseVisualStyleBackColor = false;
            this.btnSearchBySubject.Click += new System.EventHandler(this.btnSearchBySubject_Click);
            // 
            // dateTimePickerTicket
            // 
            this.dateTimePickerTicket.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerTicket.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTicket.Location = new System.Drawing.Point(906, 311);
            this.dateTimePickerTicket.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTicket.Name = "dateTimePickerTicket";
            this.dateTimePickerTicket.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerTicket.TabIndex = 13;
            // 
            // cbDeadline
            // 
            this.cbDeadline.FormattingEnabled = true;
            this.cbDeadline.Location = new System.Drawing.Point(906, 278);
            this.cbDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(112, 21);
            this.cbDeadline.TabIndex = 12;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(906, 246);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(2);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(112, 21);
            this.cbPriority.TabIndex = 12;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(906, 213);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(112, 20);
            this.txtSubject.TabIndex = 11;
            this.txtSubject.Text = "subject";
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteTicket.Location = new System.Drawing.Point(726, 426);
            this.btnDeleteTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(55, 29);
            this.btnDeleteTicket.TabIndex = 10;
            this.btnDeleteTicket.Text = "Delete";
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdateTicket.Location = new System.Drawing.Point(906, 382);
            this.btnUpdateTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(54, 28);
            this.btnUpdateTicket.TabIndex = 10;
            this.btnUpdateTicket.Text = "Update";
            this.btnUpdateTicket.UseVisualStyleBackColor = false;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ticket overview";
            // 
            // textBoxTicketSearch
            // 
            this.textBoxTicketSearch.Location = new System.Drawing.Point(163, 76);
            this.textBoxTicketSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTicketSearch.Name = "textBoxTicketSearch";
            this.textBoxTicketSearch.Size = new System.Drawing.Size(110, 20);
            this.textBoxTicketSearch.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(25, 76);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(110, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreateIncident.Location = new System.Drawing.Point(602, 426);
            this.btnCreateIncident.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(88, 29);
            this.btnCreateIncident.TabIndex = 7;
            this.btnCreateIncident.Text = "Create Incident";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // dataGVTicketOverview
            // 
            this.dataGVTicketOverview.AllowUserToAddRows = false;
            this.dataGVTicketOverview.AllowUserToDeleteRows = false;
            this.dataGVTicketOverview.AllowUserToResizeColumns = false;
            this.dataGVTicketOverview.AllowUserToResizeRows = false;
            this.dataGVTicketOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTicketOverview.Location = new System.Drawing.Point(25, 180);
            this.dataGVTicketOverview.Margin = new System.Windows.Forms.Padding(2);
            this.dataGVTicketOverview.MultiSelect = false;
            this.dataGVTicketOverview.Name = "dataGVTicketOverview";
            this.dataGVTicketOverview.ReadOnly = true;
            this.dataGVTicketOverview.RowHeadersWidth = 51;
            this.dataGVTicketOverview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGVTicketOverview.RowTemplate.Height = 24;
            this.dataGVTicketOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVTicketOverview.Size = new System.Drawing.Size(864, 229);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 581);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenuCOntainer);
            this.Controls.Add(this.pnlIncidentManagemnt);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlUserManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoDeskUI";
            this.Text = "NoDeskUI";
            this.pnlMenuCOntainer.ResumeLayout(false);
            this.pnlMenuCOntainer.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlUserManagement.ResumeLayout(false);
            this.pnlUserManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUser)).EndInit();
            this.pnlIncidentManagemnt.ResumeLayout(false);
            this.pnlIncidentManagemnt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTicketOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuCOntainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnIncidentManagement;
        private System.Windows.Forms.Button btnUserManagement;
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
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Label lblCurrentIncidents;
        private CircularProgressBar.CircularProgressBar progressBarUnresolvedIncidents;
        private CircularProgressBar.CircularProgressBar progressBarIncidentsPastDeadline;
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.Label lblSubtitle1;
        private System.Windows.Forms.Label lblIncidentsPastDeadline;
        private System.Windows.Forms.Label lblUnresolvedIncidents;
        private System.Windows.Forms.Button btnRecentTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGVUser;
        private System.Windows.Forms.ComboBox cbFilterByType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnRefreshUser;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTransferTicket;
    }
}