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
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxPrioritySorting = new System.Windows.Forms.ComboBox();
            this.btnArchiveTickets = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbFilterByStatus = new System.Windows.Forms.ComboBox();
            this.cbFilterByPriority = new System.Windows.Forms.ComboBox();
            this.cbFilterByDeadline = new System.Windows.Forms.ComboBox();
            this.btnTransferTicket = new System.Windows.Forms.Button();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFilterByType = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.pnlMenuCOntainer.BackColor = System.Drawing.Color.LimeGreen;
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
            this.btnLogout.BackColor = System.Drawing.Color.Salmon;
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(634, 31);
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
            this.btnUserManagement.BackColor = System.Drawing.Color.LightGreen;
            this.btnUserManagement.FlatAppearance.BorderSize = 2;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Location = new System.Drawing.Point(363, 31);
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
            this.btnIncidentManagement.BackColor = System.Drawing.Color.LightGreen;
            this.btnIncidentManagement.FlatAppearance.BorderSize = 2;
            this.btnIncidentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidentManagement.Location = new System.Drawing.Point(151, 31);
            this.btnIncidentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncidentManagement.Name = "btnIncidentManagement";
            this.btnIncidentManagement.Size = new System.Drawing.Size(179, 44);
            this.btnIncidentManagement.TabIndex = 1;
            this.btnIncidentManagement.Text = "Incident Management";
            this.btnIncidentManagement.UseVisualStyleBackColor = false;
            this.btnIncidentManagement.Click += new System.EventHandler(this.btnIncidentManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(934, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "NoDesk";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.LightGreen;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.FlatAppearance.BorderSize = 2;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(9, 31);
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
            this.pnlDashboard.Location = new System.Drawing.Point(9, 87);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1073, 474);
            this.pnlDashboard.TabIndex = 1;
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSubtitle2.Location = new System.Drawing.Point(679, 99);
            this.lblSubtitle2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(330, 17);
            this.lblSubtitle2.TabIndex = 11;
            this.lblSubtitle2.Text = "These tickets need your immediate attention";
            // 
            // lblSubtitle1
            // 
            this.lblSubtitle1.AutoSize = true;
            this.lblSubtitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSubtitle1.Location = new System.Drawing.Point(139, 99);
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
            this.lblIncidentsPastDeadline.Location = new System.Drawing.Point(722, 75);
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
            this.lblUnresolvedIncidents.Location = new System.Drawing.Point(128, 75);
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
            this.progressBarIncidentsPastDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarIncidentsPastDeadline.ForeColor = System.Drawing.Color.Black;
            this.progressBarIncidentsPastDeadline.InnerColor = System.Drawing.Color.White;
            this.progressBarIncidentsPastDeadline.InnerMargin = 2;
            this.progressBarIncidentsPastDeadline.InnerWidth = -1;
            this.progressBarIncidentsPastDeadline.Location = new System.Drawing.Point(682, 131);
            this.progressBarIncidentsPastDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarIncidentsPastDeadline.MarqueeAnimationSpeed = 2000;
            this.progressBarIncidentsPastDeadline.Name = "progressBarIncidentsPastDeadline";
            this.progressBarIncidentsPastDeadline.OuterColor = System.Drawing.Color.Silver;
            this.progressBarIncidentsPastDeadline.OuterMargin = -70;
            this.progressBarIncidentsPastDeadline.OuterWidth = 70;
            this.progressBarIncidentsPastDeadline.ProgressColor = System.Drawing.Color.Firebrick;
            this.progressBarIncidentsPastDeadline.ProgressWidth = 70;
            this.progressBarIncidentsPastDeadline.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarIncidentsPastDeadline.Size = new System.Drawing.Size(302, 315);
            this.progressBarIncidentsPastDeadline.StartAngle = 270;
            this.progressBarIncidentsPastDeadline.Step = 1;
            this.progressBarIncidentsPastDeadline.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarIncidentsPastDeadline.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBarIncidentsPastDeadline.SubscriptText = "";
            this.progressBarIncidentsPastDeadline.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarIncidentsPastDeadline.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBarIncidentsPastDeadline.SuperscriptText = "";
            this.progressBarIncidentsPastDeadline.TabIndex = 7;
            this.progressBarIncidentsPastDeadline.TextMargin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.progressBarIncidentsPastDeadline.Value = 68;
            // 
            // progressBarUnresolvedIncidents
            // 
            this.progressBarUnresolvedIncidents.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBarUnresolvedIncidents.AnimationSpeed = 500;
            this.progressBarUnresolvedIncidents.BackColor = System.Drawing.Color.Transparent;
            this.progressBarUnresolvedIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarUnresolvedIncidents.ForeColor = System.Drawing.Color.Black;
            this.progressBarUnresolvedIncidents.InnerColor = System.Drawing.Color.White;
            this.progressBarUnresolvedIncidents.InnerMargin = 2;
            this.progressBarUnresolvedIncidents.InnerWidth = -1;
            this.progressBarUnresolvedIncidents.Location = new System.Drawing.Point(76, 131);
            this.progressBarUnresolvedIncidents.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarUnresolvedIncidents.MarqueeAnimationSpeed = 2000;
            this.progressBarUnresolvedIncidents.Name = "progressBarUnresolvedIncidents";
            this.progressBarUnresolvedIncidents.OuterColor = System.Drawing.Color.Silver;
            this.progressBarUnresolvedIncidents.OuterMargin = -70;
            this.progressBarUnresolvedIncidents.OuterWidth = 70;
            this.progressBarUnresolvedIncidents.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBarUnresolvedIncidents.ProgressWidth = 70;
            this.progressBarUnresolvedIncidents.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarUnresolvedIncidents.Size = new System.Drawing.Size(302, 315);
            this.progressBarUnresolvedIncidents.StartAngle = 270;
            this.progressBarUnresolvedIncidents.Step = 1;
            this.progressBarUnresolvedIncidents.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarUnresolvedIncidents.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBarUnresolvedIncidents.SubscriptText = "";
            this.progressBarUnresolvedIncidents.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarUnresolvedIncidents.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBarUnresolvedIncidents.SuperscriptText = "";
            this.progressBarUnresolvedIncidents.TabIndex = 6;
            this.progressBarUnresolvedIncidents.TextMargin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.progressBarUnresolvedIncidents.Value = 68;
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.LightGreen;
            this.btnShowList.FlatAppearance.BorderSize = 2;
            this.btnShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.ForeColor = System.Drawing.Color.Black;
            this.btnShowList.Location = new System.Drawing.Point(932, 16);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(129, 39);
            this.btnShowList.TabIndex = 4;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // lblCurrentIncidents
            // 
            this.lblCurrentIncidents.AutoSize = true;
            this.lblCurrentIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIncidents.Location = new System.Drawing.Point(31, 14);
            this.lblCurrentIncidents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentIncidents.Name = "lblCurrentIncidents";
            this.lblCurrentIncidents.Size = new System.Drawing.Size(258, 36);
            this.lblCurrentIncidents.TabIndex = 3;
            this.lblCurrentIncidents.Text = "Current incidents";
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.BackColor = System.Drawing.Color.White;
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
            this.btnDeleteUser.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteUser.FlatAppearance.BorderSize = 2;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(347, 401);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(143, 41);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Delete Employee";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnRefreshUser
            // 
            this.btnRefreshUser.BackColor = System.Drawing.Color.LightGreen;
            this.btnRefreshUser.FlatAppearance.BorderSize = 2;
            this.btnRefreshUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUser.Location = new System.Drawing.Point(196, 401);
            this.btnRefreshUser.Name = "btnRefreshUser";
            this.btnRefreshUser.Size = new System.Drawing.Size(124, 41);
            this.btnRefreshUser.TabIndex = 5;
            this.btnRefreshUser.Text = "Refresh";
            this.btnRefreshUser.UseVisualStyleBackColor = false;
            this.btnRefreshUser.Click += new System.EventHandler(this.btnRefreshUser_Click);
            // 
            // dataGVUser
            // 
            this.dataGVUser.AllowUserToAddRows = false;
            this.dataGVUser.AllowUserToDeleteRows = false;
            this.dataGVUser.AllowUserToResizeColumns = false;
            this.dataGVUser.AllowUserToResizeRows = false;
            this.dataGVUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUser.Location = new System.Drawing.Point(46, 95);
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
            this.btnAddEmployee.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddEmployee.FlatAppearance.BorderSize = 2;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(46, 401);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(124, 41);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "User Management";
            // 
            // pnlIncidentManagemnt
            // 
            this.pnlIncidentManagemnt.BackColor = System.Drawing.Color.White;
            this.pnlIncidentManagemnt.Controls.Add(this.label10);
            this.pnlIncidentManagemnt.Controls.Add(this.comboBoxPrioritySorting);
            this.pnlIncidentManagemnt.Controls.Add(this.btnArchiveTickets);
            this.pnlIncidentManagemnt.Controls.Add(this.btnFilter);
            this.pnlIncidentManagemnt.Controls.Add(this.cbFilterByStatus);
            this.pnlIncidentManagemnt.Controls.Add(this.cbFilterByPriority);
            this.pnlIncidentManagemnt.Controls.Add(this.cbFilterByDeadline);
            this.pnlIncidentManagemnt.Controls.Add(this.btnTransferTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.btnCloseTicket);
            this.pnlIncidentManagemnt.Controls.Add(this.label9);
            this.pnlIncidentManagemnt.Controls.Add(this.cbFilterByType);
            this.pnlIncidentManagemnt.Controls.Add(this.btnResetFilter);
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
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(905, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Sort by priority:";
            // 
            // comboBoxPrioritySorting
            // 
            this.comboBoxPrioritySorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrioritySorting.FormattingEnabled = true;
            this.comboBoxPrioritySorting.Location = new System.Drawing.Point(909, 206);
            this.comboBoxPrioritySorting.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPrioritySorting.Name = "comboBoxPrioritySorting";
            this.comboBoxPrioritySorting.Size = new System.Drawing.Size(96, 21);
            this.comboBoxPrioritySorting.TabIndex = 30;
            this.comboBoxPrioritySorting.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrioritySorting_SelectedIndexChanged);
            // 
            // btnArchiveTickets
            // 
            this.btnArchiveTickets.BackColor = System.Drawing.Color.Salmon;
            this.btnArchiveTickets.FlatAppearance.BorderSize = 2;
            this.btnArchiveTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveTickets.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnArchiveTickets.Location = new System.Drawing.Point(466, 415);
            this.btnArchiveTickets.Margin = new System.Windows.Forms.Padding(2);
            this.btnArchiveTickets.Name = "btnArchiveTickets";
            this.btnArchiveTickets.Size = new System.Drawing.Size(124, 41);
            this.btnArchiveTickets.TabIndex = 29;
            this.btnArchiveTickets.Text = "Archive Tickets";
            this.btnArchiveTickets.UseVisualStyleBackColor = false;
            this.btnArchiveTickets.Click += new System.EventHandler(this.btnArchiveTickets_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LightGreen;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(962, 93);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 23);
            this.btnFilter.TabIndex = 28;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbFilterByStatus
            // 
            this.cbFilterByStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByStatus.FormattingEnabled = true;
            this.cbFilterByStatus.Location = new System.Drawing.Point(727, 93);
            this.cbFilterByStatus.Name = "cbFilterByStatus";
            this.cbFilterByStatus.Size = new System.Drawing.Size(100, 21);
            this.cbFilterByStatus.TabIndex = 27;
            // 
            // cbFilterByPriority
            // 
            this.cbFilterByPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByPriority.FormattingEnabled = true;
            this.cbFilterByPriority.Location = new System.Drawing.Point(841, 93);
            this.cbFilterByPriority.Name = "cbFilterByPriority";
            this.cbFilterByPriority.Size = new System.Drawing.Size(99, 21);
            this.cbFilterByPriority.TabIndex = 26;
            // 
            // cbFilterByDeadline
            // 
            this.cbFilterByDeadline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByDeadline.FormattingEnabled = true;
            this.cbFilterByDeadline.Location = new System.Drawing.Point(728, 124);
            this.cbFilterByDeadline.Name = "cbFilterByDeadline";
            this.cbFilterByDeadline.Size = new System.Drawing.Size(99, 21);
            this.cbFilterByDeadline.TabIndex = 25;
            // 
            // btnTransferTicket
            // 
            this.btnTransferTicket.BackColor = System.Drawing.Color.LightGreen;
            this.btnTransferTicket.FlatAppearance.BorderSize = 2;
            this.btnTransferTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferTicket.Location = new System.Drawing.Point(318, 415);
            this.btnTransferTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransferTicket.Name = "btnTransferTicket";
            this.btnTransferTicket.Size = new System.Drawing.Size(124, 41);
            this.btnTransferTicket.TabIndex = 24;
            this.btnTransferTicket.Text = "Transfer Ticket";
            this.btnTransferTicket.UseVisualStyleBackColor = false;
            this.btnTransferTicket.Click += new System.EventHandler(this.btnTransferTicket_Click);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.BackColor = System.Drawing.Color.Salmon;
            this.btnCloseTicket.FlatAppearance.BorderSize = 2;
            this.btnCloseTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTicket.Location = new System.Drawing.Point(615, 415);
            this.btnCloseTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(124, 41);
            this.btnCloseTicket.TabIndex = 23;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = false;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(722, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Filter Ticket";
            // 
            // cbFilterByType
            // 
            this.cbFilterByType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByType.FormattingEnabled = true;
            this.cbFilterByType.Location = new System.Drawing.Point(841, 124);
            this.cbFilterByType.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterByType.Name = "cbFilterByType";
            this.cbFilterByType.Size = new System.Drawing.Size(99, 21);
            this.cbFilterByType.TabIndex = 21;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.LightGreen;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.Location = new System.Drawing.Point(962, 121);
            this.btnResetFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(90, 23);
            this.btnResetFilter.TabIndex = 20;
            this.btnResetFilter.Text = "Reset Filters";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // txtTicketNr
            // 
            this.txtTicketNr.Location = new System.Drawing.Point(909, 247);
            this.txtTicketNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtTicketNr.Name = "txtTicketNr";
            this.txtTicketNr.Size = new System.Drawing.Size(112, 20);
            this.txtTicketNr.TabIndex = 19;
            // 
            // btnSearchOr
            // 
            this.btnSearchOr.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearchOr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOr.Location = new System.Drawing.Point(519, 122);
            this.btnSearchOr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchOr.Name = "btnSearchOr";
            this.btnSearchOr.Size = new System.Drawing.Size(63, 28);
            this.btnSearchOr.TabIndex = 18;
            this.btnSearchOr.Text = "Search";
            this.btnSearchOr.UseVisualStyleBackColor = false;
            this.btnSearchOr.Click += new System.EventHandler(this.btnSearchOr_Click);
            // 
            // btnAndSearch
            // 
            this.btnAndSearch.BackColor = System.Drawing.Color.LightGreen;
            this.btnAndSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAndSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndSearch.Location = new System.Drawing.Point(306, 119);
            this.btnAndSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndSearch.Name = "btnAndSearch";
            this.btnAndSearch.Size = new System.Drawing.Size(63, 28);
            this.btnAndSearch.TabIndex = 18;
            this.btnAndSearch.Text = "Search";
            this.btnAndSearch.UseVisualStyleBackColor = false;
            this.btnAndSearch.Click += new System.EventHandler(this.btnAndSearch_Click);
            // 
            // comboBoxPriorityOr
            // 
            this.comboBoxPriorityOr.FormattingEnabled = true;
            this.comboBoxPriorityOr.Location = new System.Drawing.Point(622, 92);
            this.comboBoxPriorityOr.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPriorityOr.Name = "comboBoxPriorityOr";
            this.comboBoxPriorityOr.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPriorityOr.TabIndex = 17;
            // 
            // comboBoxPriorityAnd
            // 
            this.comboBoxPriorityAnd.FormattingEnabled = true;
            this.comboBoxPriorityAnd.Location = new System.Drawing.Point(410, 92);
            this.comboBoxPriorityAnd.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPriorityAnd.Name = "comboBoxPriorityAnd";
            this.comboBoxPriorityAnd.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPriorityAnd.TabIndex = 17;
            // 
            // comboBoxStatusOr
            // 
            this.comboBoxStatusOr.FormattingEnabled = true;
            this.comboBoxStatusOr.Location = new System.Drawing.Point(519, 92);
            this.comboBoxStatusOr.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStatusOr.Name = "comboBoxStatusOr";
            this.comboBoxStatusOr.Size = new System.Drawing.Size(92, 21);
            this.comboBoxStatusOr.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(515, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search by status or priority:";
            // 
            // comboBoxStatusAnd
            // 
            this.comboBoxStatusAnd.FormattingEnabled = true;
            this.comboBoxStatusAnd.Location = new System.Drawing.Point(306, 92);
            this.comboBoxStatusAnd.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStatusAnd.Name = "comboBoxStatusAnd";
            this.comboBoxStatusAnd.Size = new System.Drawing.Size(92, 21);
            this.comboBoxStatusAnd.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(155, 67);
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
            this.label3.Location = new System.Drawing.Point(20, 67);
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
            this.label6.Location = new System.Drawing.Point(302, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search by status and priority:";
            // 
            // buttonSearchByTicket
            // 
            this.buttonSearchByTicket.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSearchByTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchByTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchByTicket.Location = new System.Drawing.Point(159, 119);
            this.buttonSearchByTicket.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchByTicket.Name = "buttonSearchByTicket";
            this.buttonSearchByTicket.Size = new System.Drawing.Size(63, 28);
            this.buttonSearchByTicket.TabIndex = 14;
            this.buttonSearchByTicket.Text = "Search";
            this.buttonSearchByTicket.UseVisualStyleBackColor = false;
            this.buttonSearchByTicket.Click += new System.EventHandler(this.buttonSearchByTicket_Click);
            // 
            // btnSearchBySubject
            // 
            this.btnSearchBySubject.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearchBySubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBySubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBySubject.Location = new System.Drawing.Point(24, 119);
            this.btnSearchBySubject.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchBySubject.Name = "btnSearchBySubject";
            this.btnSearchBySubject.Size = new System.Drawing.Size(63, 28);
            this.btnSearchBySubject.TabIndex = 14;
            this.btnSearchBySubject.Text = "Search";
            this.btnSearchBySubject.UseVisualStyleBackColor = false;
            this.btnSearchBySubject.Click += new System.EventHandler(this.btnSearchBySubject_Click);
            // 
            // dateTimePickerTicket
            // 
            this.dateTimePickerTicket.CustomFormat = "MM.dd.yyyy";
            this.dateTimePickerTicket.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTicket.Location = new System.Drawing.Point(909, 375);
            this.dateTimePickerTicket.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTicket.MaxDate = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            this.dateTimePickerTicket.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTicket.Name = "dateTimePickerTicket";
            this.dateTimePickerTicket.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerTicket.TabIndex = 13;
            this.dateTimePickerTicket.Value = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            // 
            // cbDeadline
            // 
            this.cbDeadline.FormattingEnabled = true;
            this.cbDeadline.Location = new System.Drawing.Point(909, 341);
            this.cbDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(112, 21);
            this.cbDeadline.TabIndex = 12;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(909, 310);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(2);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(112, 21);
            this.cbPriority.TabIndex = 12;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(909, 276);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(112, 20);
            this.txtSubject.TabIndex = 11;
            this.txtSubject.Text = "subject";
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteTicket.FlatAppearance.BorderSize = 2;
            this.btnDeleteTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicket.Location = new System.Drawing.Point(764, 415);
            this.btnDeleteTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(124, 41);
            this.btnDeleteTicket.TabIndex = 10;
            this.btnDeleteTicket.Text = "Delete Ticket";
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpdateTicket.FlatAppearance.BorderSize = 2;
            this.btnUpdateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTicket.Location = new System.Drawing.Point(172, 415);
            this.btnUpdateTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(124, 41);
            this.btnUpdateTicket.TabIndex = 10;
            this.btnUpdateTicket.Text = "Update Ticket";
            this.btnUpdateTicket.UseVisualStyleBackColor = false;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ticket overview";
            // 
            // textBoxTicketSearch
            // 
            this.textBoxTicketSearch.Location = new System.Drawing.Point(159, 92);
            this.textBoxTicketSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTicketSearch.Name = "textBoxTicketSearch";
            this.textBoxTicketSearch.Size = new System.Drawing.Size(122, 20);
            this.textBoxTicketSearch.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 92);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.Color.LightGreen;
            this.btnCreateIncident.FlatAppearance.BorderSize = 2;
            this.btnCreateIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateIncident.Location = new System.Drawing.Point(23, 415);
            this.btnCreateIncident.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(124, 41);
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
            this.dataGVTicketOverview.BackgroundColor = System.Drawing.Color.White;
            this.dataGVTicketOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTicketOverview.Location = new System.Drawing.Point(24, 165);
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
            this.Controls.Add(this.pnlUserManagement);
            this.Controls.Add(this.pnlIncidentManagemnt);
            this.Controls.Add(this.pnlDashboard);
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
        private System.Windows.Forms.Button btnResetFilter;
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
        private System.Windows.Forms.ComboBox cbFilterByStatus;
        private System.Windows.Forms.ComboBox cbFilterByPriority;
        private System.Windows.Forms.ComboBox cbFilterByDeadline;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnArchiveTickets;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxPrioritySorting;
        private System.Windows.Forms.Label label10;
    }
}