namespace UI
{
    partial class ArchiveTicket
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
            this.btnAddArchive = new System.Windows.Forms.Button();
            this.dtPickerArchive = new System.Windows.Forms.DateTimePicker();
            this.lblIndicationText = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.pnlTicketSelection = new System.Windows.Forms.Panel();
            this.pnlVerifyUser = new System.Windows.Forms.Panel();
            this.lblAskForPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnVerifyUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlTicketSelection.SuspendLayout();
            this.pnlVerifyUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddArchive
            // 
            this.btnAddArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArchive.Location = new System.Drawing.Point(144, 193);
            this.btnAddArchive.Name = "btnAddArchive";
            this.btnAddArchive.Size = new System.Drawing.Size(110, 42);
            this.btnAddArchive.TabIndex = 0;
            this.btnAddArchive.Text = "Archive";
            this.btnAddArchive.UseVisualStyleBackColor = true;
            this.btnAddArchive.Click += new System.EventHandler(this.btnAddArchive_Click);
            // 
            // dtPickerArchive
            // 
            this.dtPickerArchive.CustomFormat = "MM.dd.yyyy";
            this.dtPickerArchive.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerArchive.Location = new System.Drawing.Point(119, 87);
            this.dtPickerArchive.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtPickerArchive.Name = "dtPickerArchive";
            this.dtPickerArchive.Size = new System.Drawing.Size(160, 22);
            this.dtPickerArchive.TabIndex = 2;
            this.dtPickerArchive.ValueChanged += new System.EventHandler(this.dtPickerArchive_ValueChanged);
            // 
            // lblIndicationText
            // 
            this.lblIndicationText.AutoSize = true;
            this.lblIndicationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicationText.Location = new System.Drawing.Point(2, 4);
            this.lblIndicationText.Name = "lblIndicationText";
            this.lblIndicationText.Size = new System.Drawing.Size(364, 22);
            this.lblIndicationText.TabIndex = 7;
            this.lblIndicationText.Text = "Please select a begining date for the archive";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(40, 29);
            this.lblCount.Name = "lblCount";
            this.lblCount.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lblCount.Size = new System.Drawing.Size(286, 26);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "0 tickets match your criteria";
            // 
            // pnlTicketSelection
            // 
            this.pnlTicketSelection.Controls.Add(this.lblIndicationText);
            this.pnlTicketSelection.Controls.Add(this.lblCount);
            this.pnlTicketSelection.Controls.Add(this.dtPickerArchive);
            this.pnlTicketSelection.Controls.Add(this.btnAddArchive);
            this.pnlTicketSelection.Location = new System.Drawing.Point(12, 12);
            this.pnlTicketSelection.Name = "pnlTicketSelection";
            this.pnlTicketSelection.Size = new System.Drawing.Size(398, 286);
            this.pnlTicketSelection.TabIndex = 9;
            // 
            // pnlVerifyUser
            // 
            this.pnlVerifyUser.Controls.Add(this.lblAskForPassword);
            this.pnlVerifyUser.Controls.Add(this.txtPassword);
            this.pnlVerifyUser.Controls.Add(this.btnVerifyUser);
            this.pnlVerifyUser.Location = new System.Drawing.Point(12, 12);
            this.pnlVerifyUser.Name = "pnlVerifyUser";
            this.pnlVerifyUser.Size = new System.Drawing.Size(398, 286);
            this.pnlVerifyUser.TabIndex = 11;
            // 
            // lblAskForPassword
            // 
            this.lblAskForPassword.AutoSize = true;
            this.lblAskForPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskForPassword.Location = new System.Drawing.Point(70, 4);
            this.lblAskForPassword.Name = "lblAskForPassword";
            this.lblAskForPassword.Size = new System.Drawing.Size(258, 50);
            this.lblAskForPassword.TabIndex = 7;
            this.lblAskForPassword.Text = "Please enter your password \r\nto verify your identity";
            this.lblAskForPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(7, 105);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(368, 30);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnVerifyUser
            // 
            this.btnVerifyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyUser.Location = new System.Drawing.Point(144, 193);
            this.btnVerifyUser.Name = "btnVerifyUser";
            this.btnVerifyUser.Size = new System.Drawing.Size(110, 42);
            this.btnVerifyUser.TabIndex = 4;
            this.btnVerifyUser.Text = "Verify";
            this.btnVerifyUser.UseVisualStyleBackColor = true;
            this.btnVerifyUser.Click += new System.EventHandler(this.btnVerifyUser_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(300, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 42);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ArchiveTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(422, 419);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlVerifyUser);
            this.Controls.Add(this.pnlTicketSelection);
            this.Name = "ArchiveTicket";
            this.Text = "Danger zone";
            this.pnlTicketSelection.ResumeLayout(false);
            this.pnlTicketSelection.PerformLayout();
            this.pnlVerifyUser.ResumeLayout(false);
            this.pnlVerifyUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddArchive;
        private System.Windows.Forms.DateTimePicker dtPickerArchive;
        private System.Windows.Forms.Label lblIndicationText;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlTicketSelection;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlVerifyUser;
        private System.Windows.Forms.Label lblAskForPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnVerifyUser;
    }
}