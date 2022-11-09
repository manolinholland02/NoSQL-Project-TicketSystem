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
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.lblSubtitle1 = new System.Windows.Forms.Label();
            this.lblIncidentsPastDeadline = new System.Windows.Forms.Label();
            this.lblUnresolvedIncidents = new System.Windows.Forms.Label();
            this.progressBarIncidentsPastDeadline = new CircularProgressBar.CircularProgressBar();
            this.progressBarUnresolvedIncidents = new CircularProgressBar.CircularProgressBar();
            this.btnShowList = new System.Windows.Forms.Button();
            this.lblCurrentIncidents = new System.Windows.Forms.Label();
            this.pnlUserManagement = new System.Windows.Forms.Panel();
            this.dataGVUser = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlIncidentManagemnt = new System.Windows.Forms.Panel();
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
            this.pnlMenuCOntainer.Controls.Add(this.btnUserManagement);
            this.pnlMenuCOntainer.Controls.Add(this.label2);
            this.pnlMenuCOntainer.Controls.Add(this.btnIncidentManagement);
            this.pnlMenuCOntainer.Controls.Add(this.label1);
            this.pnlMenuCOntainer.Controls.Add(this.btnDashboard);
            this.pnlMenuCOntainer.Location = new System.Drawing.Point(0, 1);
            this.pnlMenuCOntainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenuCOntainer.Name = "pnlMenuCOntainer";
            this.pnlMenuCOntainer.Size = new System.Drawing.Size(1287, 98);
            this.pnlMenuCOntainer.TabIndex = 0;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Location = new System.Drawing.Point(417, 44);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label2.Location = new System.Drawing.Point(823, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // btnIncidentManagement
            // 
            this.btnIncidentManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIncidentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidentManagement.Location = new System.Drawing.Point(195, 46);
            this.btnIncidentManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label1.Location = new System.Drawing.Point(1074, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "NoDesk";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(21, 46);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(147, 54);
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
            this.pnlDashboard.Location = new System.Drawing.Point(22, 138);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1075, 494);
            this.pnlDashboard.TabIndex = 1;
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSubtitle2.Location = new System.Drawing.Point(668, 122);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(376, 20);
            this.lblSubtitle2.TabIndex = 11;
            this.lblSubtitle2.Text = "These tickets need your imeediate attention";
            // 
            // lblSubtitle1
            // 
            this.lblSubtitle1.AutoSize = true;
            this.lblSubtitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSubtitle1.Location = new System.Drawing.Point(133, 122);
            this.lblSubtitle1.Name = "lblSubtitle1";
            this.lblSubtitle1.Size = new System.Drawing.Size(219, 20);
            this.lblSubtitle1.TabIndex = 10;
            this.lblSubtitle1.Text = "All tickets currently open";
            // 
            // lblIncidentsPastDeadline
            // 
            this.lblIncidentsPastDeadline.AutoSize = true;
            this.lblIncidentsPastDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentsPastDeadline.ForeColor = System.Drawing.Color.DimGray;
            this.lblIncidentsPastDeadline.Location = new System.Drawing.Point(693, 93);
            this.lblIncidentsPastDeadline.Name = "lblIncidentsPastDeadline";
            this.lblIncidentsPastDeadline.Size = new System.Drawing.Size(283, 29);
            this.lblIncidentsPastDeadline.TabIndex = 9;
            this.lblIncidentsPastDeadline.Text = "Incidents past deadline";
            // 
            // lblUnresolvedIncidents
            // 
            this.lblUnresolvedIncidents.AutoSize = true;
            this.lblUnresolvedIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnresolvedIncidents.ForeColor = System.Drawing.Color.DimGray;
            this.lblUnresolvedIncidents.Location = new System.Drawing.Point(110, 93);
            this.lblUnresolvedIncidents.Name = "lblUnresolvedIncidents";
            this.lblUnresolvedIncidents.Size = new System.Drawing.Size(258, 29);
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
            this.progressBarIncidentsPastDeadline.Location = new System.Drawing.Point(655, 161);
            this.progressBarIncidentsPastDeadline.MarqueeAnimationSpeed = 2000;
            this.progressBarIncidentsPastDeadline.Name = "progressBarIncidentsPastDeadline";
            this.progressBarIncidentsPastDeadline.OuterColor = System.Drawing.Color.Silver;
            this.progressBarIncidentsPastDeadline.OuterMargin = -46;
            this.progressBarIncidentsPastDeadline.OuterWidth = 46;
            this.progressBarIncidentsPastDeadline.ProgressColor = System.Drawing.Color.Firebrick;
            this.progressBarIncidentsPastDeadline.ProgressWidth = 46;
            this.progressBarIncidentsPastDeadline.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBarIncidentsPastDeadline.Size = new System.Drawing.Size(309, 294);
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
            this.progressBarUnresolvedIncidents.Location = new System.Drawing.Point(77, 161);
            this.progressBarUnresolvedIncidents.MarqueeAnimationSpeed = 2000;
            this.progressBarUnresolvedIncidents.Name = "progressBarUnresolvedIncidents";
            this.progressBarUnresolvedIncidents.OuterColor = System.Drawing.Color.Silver;
            this.progressBarUnresolvedIncidents.OuterMargin = -46;
            this.progressBarUnresolvedIncidents.OuterWidth = 46;
            this.progressBarUnresolvedIncidents.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBarUnresolvedIncidents.ProgressWidth = 46;
            this.progressBarUnresolvedIncidents.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBarUnresolvedIncidents.Size = new System.Drawing.Size(309, 294);
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
            this.btnShowList.Location = new System.Drawing.Point(858, 16);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(172, 48);
            this.btnShowList.TabIndex = 4;
            this.btnShowList.Text = "SHOW LIST";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // lblCurrentIncidents
            // 
            this.lblCurrentIncidents.AutoSize = true;
            this.lblCurrentIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIncidents.Location = new System.Drawing.Point(25, 26);
            this.lblCurrentIncidents.Name = "lblCurrentIncidents";
            this.lblCurrentIncidents.Size = new System.Drawing.Size(317, 42);
            this.lblCurrentIncidents.TabIndex = 3;
            this.lblCurrentIncidents.Text = "Current incidents";
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Controls.Add(this.dataGVUser);
            this.pnlUserManagement.Controls.Add(this.btnAddEmployee);
            this.pnlUserManagement.Controls.Add(this.label5);
            this.pnlUserManagement.Location = new System.Drawing.Point(12, 105);
            this.pnlUserManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(1259, 644);
            this.pnlUserManagement.TabIndex = 1;
            // 
            // dataGVUser
            // 
            this.dataGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUser.Location = new System.Drawing.Point(48, 136);
            this.dataGVUser.Name = "dataGVUser";
            this.dataGVUser.RowHeadersWidth = 51;
            this.dataGVUser.RowTemplate.Height = 24;
            this.dataGVUser.Size = new System.Drawing.Size(915, 362);
            this.dataGVUser.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(854, 533);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(109, 33);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "User Management";
            // 
            // pnlIncidentManagemnt
            // 
            this.pnlIncidentManagemnt.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.pnlIncidentManagemnt.Location = new System.Drawing.Point(12, 105);
            this.pnlIncidentManagemnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIncidentManagemnt.Name = "pnlIncidentManagemnt";
            this.pnlIncidentManagemnt.Size = new System.Drawing.Size(1259, 636);
            this.pnlIncidentManagemnt.TabIndex = 0;
            this.pnlIncidentManagemnt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIncidentManagemnt_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1001, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Filter by incident type:";
            // 
            // cbFilterByType
            // 
            this.cbFilterByType.FormattingEnabled = true;
            this.cbFilterByType.Location = new System.Drawing.Point(1006, 94);
            this.cbFilterByType.Name = "cbFilterByType";
            this.cbFilterByType.Size = new System.Drawing.Size(121, 24);
            this.cbFilterByType.TabIndex = 21;
            this.cbFilterByType.SelectedIndexChanged += new System.EventHandler(this.cbFilterByType_SelectedIndexChanged_1);
            // 
            // btnRecentTicket
            // 
            this.btnRecentTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRecentTicket.Location = new System.Drawing.Point(1006, 174);
            this.btnRecentTicket.Name = "btnRecentTicket";
            this.btnRecentTicket.Size = new System.Drawing.Size(110, 34);
            this.btnRecentTicket.TabIndex = 20;
            this.btnRecentTicket.Text = "Recent ticket";
            this.btnRecentTicket.UseVisualStyleBackColor = false;
            this.btnRecentTicket.Click += new System.EventHandler(this.btnRecentTicket_Click);
            // 
            // txtTicketNr
            // 
            this.txtTicketNr.Location = new System.Drawing.Point(1006, 284);
            this.txtTicketNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTicketNr.Name = "txtTicketNr";
            this.txtTicketNr.Size = new System.Drawing.Size(148, 22);
            this.txtTicketNr.TabIndex = 19;
            // 
            // btnSearchOr
            // 
            this.btnSearchOr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchOr.Location = new System.Drawing.Point(695, 174);
            this.btnSearchOr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchOr.Name = "btnSearchOr";
            this.btnSearchOr.Size = new System.Drawing.Size(72, 34);
            this.btnSearchOr.TabIndex = 18;
            this.btnSearchOr.Text = "Search";
            this.btnSearchOr.UseVisualStyleBackColor = false;
            this.btnSearchOr.Click += new System.EventHandler(this.btnSearchOr_Click);
            // 
            // btnAndSearch
            // 
            this.btnAndSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAndSearch.Location = new System.Drawing.Point(411, 171);
            this.btnAndSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAndSearch.Name = "btnAndSearch";
            this.btnAndSearch.Size = new System.Drawing.Size(72, 34);
            this.btnAndSearch.TabIndex = 18;
            this.btnAndSearch.Text = "Search";
            this.btnAndSearch.UseVisualStyleBackColor = false;
            this.btnAndSearch.Click += new System.EventHandler(this.btnAndSearch_Click);
            // 
            // comboBoxPriorityOr
            // 
            this.comboBoxPriorityOr.FormattingEnabled = true;
            this.comboBoxPriorityOr.Location = new System.Drawing.Point(695, 136);
            this.comboBoxPriorityOr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPriorityOr.Name = "comboBoxPriorityOr";
            this.comboBoxPriorityOr.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPriorityOr.TabIndex = 17;
            // 
            // comboBoxPriorityAnd
            // 
            this.comboBoxPriorityAnd.FormattingEnabled = true;
            this.comboBoxPriorityAnd.Location = new System.Drawing.Point(411, 133);
            this.comboBoxPriorityAnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPriorityAnd.Name = "comboBoxPriorityAnd";
            this.comboBoxPriorityAnd.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPriorityAnd.TabIndex = 17;
            // 
            // comboBoxStatusOr
            // 
            this.comboBoxStatusOr.FormattingEnabled = true;
            this.comboBoxStatusOr.Location = new System.Drawing.Point(695, 94);
            this.comboBoxStatusOr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStatusOr.Name = "comboBoxStatusOr";
            this.comboBoxStatusOr.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatusOr.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(692, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search by status or priority:";
            // 
            // comboBoxStatusAnd
            // 
            this.comboBoxStatusAnd.FormattingEnabled = true;
            this.comboBoxStatusAnd.Location = new System.Drawing.Point(411, 91);
            this.comboBoxStatusAnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStatusAnd.Name = "comboBoxStatusAnd";
            this.comboBoxStatusAnd.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatusAnd.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(217, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search by ticketNr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Search by subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search by status and priority:";
            // 
            // buttonSearchByTicket
            // 
            this.buttonSearchByTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSearchByTicket.Location = new System.Drawing.Point(199, 171);
            this.buttonSearchByTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchByTicket.Name = "buttonSearchByTicket";
            this.buttonSearchByTicket.Size = new System.Drawing.Size(72, 34);
            this.buttonSearchByTicket.TabIndex = 14;
            this.buttonSearchByTicket.Text = "Search";
            this.buttonSearchByTicket.UseVisualStyleBackColor = false;
            this.buttonSearchByTicket.Click += new System.EventHandler(this.buttonSearchByTicket_Click);
            // 
            // btnSearchBySubject
            // 
            this.btnSearchBySubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchBySubject.Location = new System.Drawing.Point(33, 171);
            this.btnSearchBySubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBySubject.Name = "btnSearchBySubject";
            this.btnSearchBySubject.Size = new System.Drawing.Size(72, 34);
            this.btnSearchBySubject.TabIndex = 14;
            this.btnSearchBySubject.Text = "Search";
            this.btnSearchBySubject.UseVisualStyleBackColor = false;
            this.btnSearchBySubject.Click += new System.EventHandler(this.btnSearchBySubject_Click);
            // 
            // dateTimePickerTicket
            // 
            this.dateTimePickerTicket.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerTicket.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTicket.Location = new System.Drawing.Point(1006, 441);
            this.dateTimePickerTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTicket.Name = "dateTimePickerTicket";
            this.dateTimePickerTicket.Size = new System.Drawing.Size(148, 22);
            this.dateTimePickerTicket.TabIndex = 13;
            // 
            // cbDeadline
            // 
            this.cbDeadline.FormattingEnabled = true;
            this.cbDeadline.Location = new System.Drawing.Point(1006, 400);
            this.cbDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(148, 24);
            this.cbDeadline.TabIndex = 12;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(1006, 361);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(148, 24);
            this.cbPriority.TabIndex = 12;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(1006, 320);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(148, 22);
            this.txtSubject.TabIndex = 11;
            this.txtSubject.Text = "subject";
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteTicket.Location = new System.Drawing.Point(902, 574);
            this.btnDeleteTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(72, 34);
            this.btnDeleteTicket.TabIndex = 10;
            this.btnDeleteTicket.Text = "Delete";
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.Location = new System.Drawing.Point(1006, 506);
            this.btnUpdateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(72, 34);
            this.btnUpdateTicket.TabIndex = 10;
            this.btnUpdateTicket.Text = "Update";
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ticket overview";
            // 
            // textBoxTicketSearch
            // 
            this.textBoxTicketSearch.Location = new System.Drawing.Point(217, 94);
            this.textBoxTicketSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTicketSearch.Name = "textBoxTicketSearch";
            this.textBoxTicketSearch.Size = new System.Drawing.Size(145, 22);
            this.textBoxTicketSearch.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(33, 94);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 22);
            this.txtSearch.TabIndex = 8;
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreateIncident.Location = new System.Drawing.Point(736, 574);
            this.btnCreateIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(116, 34);
            this.btnCreateIncident.TabIndex = 7;
            this.btnCreateIncident.Text = "Create Incident";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // dataGVTicketOverview
            // 
            this.dataGVTicketOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTicketOverview.Location = new System.Drawing.Point(33, 221);
            this.dataGVTicketOverview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGVTicketOverview.Name = "dataGVTicketOverview";
            this.dataGVTicketOverview.RowHeadersWidth = 51;
            this.dataGVTicketOverview.RowTemplate.Height = 24;
            this.dataGVTicketOverview.Size = new System.Drawing.Size(941, 328);
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
            this.ClientSize = new System.Drawing.Size(1286, 752);
            this.Controls.Add(this.pnlIncidentManagemnt);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlUserManagement);
            this.Controls.Add(this.pnlMenuCOntainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}