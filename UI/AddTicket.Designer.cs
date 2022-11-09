namespace UI
{
    partial class AddTicket
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtPickerIncident = new System.Windows.Forms.DateTimePicker();
            this.txtSubOfIncident = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbReportedUser = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbDeadline = new System.Windows.Forms.ComboBox();
            this.btnSubmitIncident = new System.Windows.Forms.Button();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cbTypeOfIncident = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(35, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(163, 22);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date/time reported:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(35, 80);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(162, 22);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject of incident:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(39, 200);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(153, 22);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Reported by user:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(39, 243);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(70, 22);
            this.lblPriority.TabIndex = 0;
            this.lblPriority.Text = "Priotity:";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(35, 290);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(162, 22);
            this.lblDeadline.TabIndex = 0;
            this.lblDeadline.Text = "Deadline/follow up:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(39, 346);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 22);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // dtPickerIncident
            // 
            this.dtPickerIncident.CustomFormat = "dd.MM.yyyy";
            this.dtPickerIncident.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerIncident.Location = new System.Drawing.Point(216, 37);
            this.dtPickerIncident.Margin = new System.Windows.Forms.Padding(0);
            this.dtPickerIncident.Name = "dtPickerIncident";
            this.dtPickerIncident.Size = new System.Drawing.Size(199, 22);
            this.dtPickerIncident.TabIndex = 1;
            this.dtPickerIncident.Value = new System.DateTime(2022, 11, 7, 0, 39, 2, 0);
            // 
            // txtSubOfIncident
            // 
            this.txtSubOfIncident.Location = new System.Drawing.Point(216, 80);
            this.txtSubOfIncident.Name = "txtSubOfIncident";
            this.txtSubOfIncident.Size = new System.Drawing.Size(200, 22);
            this.txtSubOfIncident.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(216, 353);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 88);
            this.txtDescription.TabIndex = 2;
            // 
            // cbReportedUser
            // 
            this.cbReportedUser.FormattingEnabled = true;
            this.cbReportedUser.Location = new System.Drawing.Point(216, 200);
            this.cbReportedUser.Name = "cbReportedUser";
            this.cbReportedUser.Size = new System.Drawing.Size(200, 24);
            this.cbReportedUser.TabIndex = 3;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(216, 245);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(200, 24);
            this.cbPriority.TabIndex = 3;
            // 
            // cbDeadline
            // 
            this.cbDeadline.FormattingEnabled = true;
            this.cbDeadline.Location = new System.Drawing.Point(216, 292);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(200, 24);
            this.cbDeadline.TabIndex = 3;
            // 
            // btnSubmitIncident
            // 
            this.btnSubmitIncident.Location = new System.Drawing.Point(340, 467);
            this.btnSubmitIncident.Name = "btnSubmitIncident";
            this.btnSubmitIncident.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitIncident.TabIndex = 4;
            this.btnSubmitIncident.Text = "Submit";
            this.btnSubmitIncident.UseVisualStyleBackColor = true;
            this.btnSubmitIncident.Click += new System.EventHandler(this.btnSubmitIncident_Click);
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.Location = new System.Drawing.Point(243, 468);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTicket.TabIndex = 5;
            this.btnCancelTicket.Text = "Cancel";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(35, 125);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(143, 22);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type of incident:";
            // 
            // cbTypeOfIncident
            // 
            this.cbTypeOfIncident.FormattingEnabled = true;
            this.cbTypeOfIncident.Location = new System.Drawing.Point(216, 123);
            this.cbTypeOfIncident.Name = "cbTypeOfIncident";
            this.cbTypeOfIncident.Size = new System.Drawing.Size(200, 24);
            this.cbTypeOfIncident.TabIndex = 7;
            // 
            // CreateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 588);
            this.Controls.Add(this.cbTypeOfIncident);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnCancelTicket);
            this.Controls.Add(this.btnSubmitIncident);
            this.Controls.Add(this.cbDeadline);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.cbReportedUser);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSubOfIncident);
            this.Controls.Add(this.dtPickerIncident);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblDate);
            this.Name = "CreateTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtPickerIncident;
        private System.Windows.Forms.TextBox txtSubOfIncident;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbReportedUser;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.ComboBox cbDeadline;
        private System.Windows.Forms.Button btnSubmitIncident;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbTypeOfIncident;
    }
}