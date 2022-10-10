namespace GradenGroupUI.UserControls
{
    partial class S
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createTicketHeaderLabel = new System.Windows.Forms.Label();
            this.dateTimeReportedLabel = new System.Windows.Forms.Label();
            this.ticketSubjectIncidentLabel = new System.Windows.Forms.Label();
            this.ticketTypeIncidentLabel = new System.Windows.Forms.Label();
            this.ticketReportedUserLabel = new System.Windows.Forms.Label();
            this.ticketPriorityLabel = new System.Windows.Forms.Label();
            this.ticketDeadlineFollowUpLabel = new System.Windows.Forms.Label();
            this.ticketDescriptionLabel = new System.Windows.Forms.Label();
            this.ticketSubjectIncidentTextBox = new System.Windows.Forms.TextBox();
            this.ticketDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ticketTypeIncidentComboBox = new System.Windows.Forms.ComboBox();
            this.ticketReportedUserComboBox = new System.Windows.Forms.ComboBox();
            this.ticketPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.ticketDeadlineFollowUpComboBox = new System.Windows.Forms.ComboBox();
            this.ticketReportedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelTicketButton = new System.Windows.Forms.Button();
            this.submitTicketButton = new System.Windows.Forms.Button();
            this.updateTicketButton = new System.Windows.Forms.Button();
            this.updateTicketLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTicketHeaderLabel
            // 
            this.createTicketHeaderLabel.AutoSize = true;
            this.createTicketHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTicketHeaderLabel.Location = new System.Drawing.Point(89, 166);
            this.createTicketHeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createTicketHeaderLabel.Name = "createTicketHeaderLabel";
            this.createTicketHeaderLabel.Size = new System.Drawing.Size(432, 48);
            this.createTicketHeaderLabel.TabIndex = 0;
            this.createTicketHeaderLabel.Text = "Create new incident ticket";
            // 
            // dateTimeReportedLabel
            // 
            this.dateTimeReportedLabel.AutoSize = true;
            this.dateTimeReportedLabel.Location = new System.Drawing.Point(96, 309);
            this.dateTimeReportedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateTimeReportedLabel.Name = "dateTimeReportedLabel";
            this.dateTimeReportedLabel.Size = new System.Drawing.Size(169, 25);
            this.dateTimeReportedLabel.TabIndex = 1;
            this.dateTimeReportedLabel.Text = "Date/time reported:";
            // 
            // ticketSubjectIncidentLabel
            // 
            this.ticketSubjectIncidentLabel.AutoSize = true;
            this.ticketSubjectIncidentLabel.Location = new System.Drawing.Point(96, 351);
            this.ticketSubjectIncidentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticketSubjectIncidentLabel.Name = "ticketSubjectIncidentLabel";
            this.ticketSubjectIncidentLabel.Size = new System.Drawing.Size(163, 25);
            this.ticketSubjectIncidentLabel.TabIndex = 2;
            this.ticketSubjectIncidentLabel.Text = "Subject of incident:";
            // 
            // ticketTypeIncidentLabel
            // 
            this.ticketTypeIncidentLabel.AutoSize = true;
            this.ticketTypeIncidentLabel.Location = new System.Drawing.Point(96, 394);
            this.ticketTypeIncidentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticketTypeIncidentLabel.Name = "ticketTypeIncidentLabel";
            this.ticketTypeIncidentLabel.Size = new System.Drawing.Size(142, 25);
            this.ticketTypeIncidentLabel.TabIndex = 3;
            this.ticketTypeIncidentLabel.Text = "Type of incident:";
            // 
            // ticketReportedUserLabel
            // 
            this.ticketReportedUserLabel.AutoSize = true;
            this.ticketReportedUserLabel.Location = new System.Drawing.Point(96, 270);
            this.ticketReportedUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticketReportedUserLabel.Name = "ticketReportedUserLabel";
            this.ticketReportedUserLabel.Size = new System.Drawing.Size(152, 25);
            this.ticketReportedUserLabel.TabIndex = 4;
            this.ticketReportedUserLabel.Text = "Reported by user:";
            this.ticketReportedUserLabel.Visible = false;
            // 
            // ticketPriorityLabel
            // 
            this.ticketPriorityLabel.AutoSize = true;
            this.ticketPriorityLabel.Location = new System.Drawing.Point(96, 434);
            this.ticketPriorityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticketPriorityLabel.Name = "ticketPriorityLabel";
            this.ticketPriorityLabel.Size = new System.Drawing.Size(72, 25);
            this.ticketPriorityLabel.TabIndex = 5;
            this.ticketPriorityLabel.Text = "Priority:";
            // 
            // ticketDeadlineFollowUpLabel
            // 
            this.ticketDeadlineFollowUpLabel.AutoSize = true;
            this.ticketDeadlineFollowUpLabel.Location = new System.Drawing.Point(96, 471);
            this.ticketDeadlineFollowUpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticketDeadlineFollowUpLabel.Name = "ticketDeadlineFollowUpLabel";
            this.ticketDeadlineFollowUpLabel.Size = new System.Drawing.Size(167, 25);
            this.ticketDeadlineFollowUpLabel.TabIndex = 6;
            this.ticketDeadlineFollowUpLabel.Text = "Deadline/follow up:";
            // 
            // ticketDescriptionLabel
            // 
            this.ticketDescriptionLabel.AutoSize = true;
            this.ticketDescriptionLabel.Location = new System.Drawing.Point(96, 516);
            this.ticketDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticketDescriptionLabel.Name = "ticketDescriptionLabel";
            this.ticketDescriptionLabel.Size = new System.Drawing.Size(106, 25);
            this.ticketDescriptionLabel.TabIndex = 7;
            this.ticketDescriptionLabel.Text = "Description:";
            // 
            // ticketSubjectIncidentTextBox
            // 
            this.ticketSubjectIncidentTextBox.Location = new System.Drawing.Point(306, 346);
            this.ticketSubjectIncidentTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ticketSubjectIncidentTextBox.Name = "ticketSubjectIncidentTextBox";
            this.ticketSubjectIncidentTextBox.Size = new System.Drawing.Size(285, 31);
            this.ticketSubjectIncidentTextBox.TabIndex = 8;
            // 
            // ticketDescriptionTextBox
            // 
            this.ticketDescriptionTextBox.Location = new System.Drawing.Point(306, 516);
            this.ticketDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ticketDescriptionTextBox.Multiline = true;
            this.ticketDescriptionTextBox.Name = "ticketDescriptionTextBox";
            this.ticketDescriptionTextBox.Size = new System.Drawing.Size(395, 249);
            this.ticketDescriptionTextBox.TabIndex = 11;
            // 
            // ticketTypeIncidentComboBox
            // 
            this.ticketTypeIncidentComboBox.FormattingEnabled = true;
            this.ticketTypeIncidentComboBox.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Service"});
            this.ticketTypeIncidentComboBox.Location = new System.Drawing.Point(306, 386);
            this.ticketTypeIncidentComboBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ticketTypeIncidentComboBox.Name = "ticketTypeIncidentComboBox";
            this.ticketTypeIncidentComboBox.Size = new System.Drawing.Size(285, 33);
            this.ticketTypeIncidentComboBox.TabIndex = 12;
            this.ticketTypeIncidentComboBox.Text = "Select type";
            // 
            // ticketReportedUserComboBox
            // 
            this.ticketReportedUserComboBox.FormattingEnabled = true;
            this.ticketReportedUserComboBox.Location = new System.Drawing.Point(306, 270);
            this.ticketReportedUserComboBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ticketReportedUserComboBox.Name = "ticketReportedUserComboBox";
            this.ticketReportedUserComboBox.Size = new System.Drawing.Size(285, 33);
            this.ticketReportedUserComboBox.TabIndex = 13;
            this.ticketReportedUserComboBox.Text = "Select user";
            this.ticketReportedUserComboBox.Visible = false;
            // 
            // ticketPriorityComboBox
            // 
            this.ticketPriorityComboBox.FormattingEnabled = true;
            this.ticketPriorityComboBox.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.ticketPriorityComboBox.Location = new System.Drawing.Point(306, 425);
            this.ticketPriorityComboBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ticketPriorityComboBox.Name = "ticketPriorityComboBox";
            this.ticketPriorityComboBox.Size = new System.Drawing.Size(285, 33);
            this.ticketPriorityComboBox.TabIndex = 14;
            this.ticketPriorityComboBox.Text = "Select priority";
            // 
            // ticketDeadlineFollowUpComboBox
            // 
            this.ticketDeadlineFollowUpComboBox.FormattingEnabled = true;
            this.ticketDeadlineFollowUpComboBox.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.ticketDeadlineFollowUpComboBox.Location = new System.Drawing.Point(306, 464);
            this.ticketDeadlineFollowUpComboBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ticketDeadlineFollowUpComboBox.Name = "ticketDeadlineFollowUpComboBox";
            this.ticketDeadlineFollowUpComboBox.Size = new System.Drawing.Size(285, 33);
            this.ticketDeadlineFollowUpComboBox.TabIndex = 15;
            this.ticketDeadlineFollowUpComboBox.Text = "Select deadline";
            // 
            // ticketReportedDateTimePicker
            // 
            this.ticketReportedDateTimePicker.Location = new System.Drawing.Point(306, 309);
            this.ticketReportedDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ticketReportedDateTimePicker.Name = "ticketReportedDateTimePicker";
            this.ticketReportedDateTimePicker.Size = new System.Drawing.Size(285, 31);
            this.ticketReportedDateTimePicker.TabIndex = 16;
            // 
            // cancelTicketButton
            // 
            this.cancelTicketButton.Location = new System.Drawing.Point(306, 796);
            this.cancelTicketButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cancelTicketButton.Name = "cancelTicketButton";
            this.cancelTicketButton.Size = new System.Drawing.Size(159, 54);
            this.cancelTicketButton.TabIndex = 17;
            this.cancelTicketButton.Text = "Cancel";
            this.cancelTicketButton.UseVisualStyleBackColor = true;
            this.cancelTicketButton.Click += new System.EventHandler(this.cancelTicketButton_Click);
            // 
            // submitTicketButton
            // 
            this.submitTicketButton.Location = new System.Drawing.Point(704, 796);
            this.submitTicketButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.submitTicketButton.Name = "submitTicketButton";
            this.submitTicketButton.Size = new System.Drawing.Size(154, 54);
            this.submitTicketButton.TabIndex = 18;
            this.submitTicketButton.Text = "Submit ticket";
            this.submitTicketButton.UseVisualStyleBackColor = true;
            this.submitTicketButton.Click += new System.EventHandler(this.submitTicketButton_Click);
            // 
            // updateTicketButton
            // 
            this.updateTicketButton.Location = new System.Drawing.Point(546, 796);
            this.updateTicketButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.updateTicketButton.Name = "updateTicketButton";
            this.updateTicketButton.Size = new System.Drawing.Size(154, 54);
            this.updateTicketButton.TabIndex = 19;
            this.updateTicketButton.Text = "Update ticket";
            this.updateTicketButton.UseVisualStyleBackColor = true;
            this.updateTicketButton.Visible = false;
            this.updateTicketButton.Click += new System.EventHandler(this.updateTicketButton_Click);
            // 
            // updateTicketLabel
            // 
            this.updateTicketLabel.AutoSize = true;
            this.updateTicketLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateTicketLabel.Location = new System.Drawing.Point(96, 166);
            this.updateTicketLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updateTicketLabel.Name = "updateTicketLabel";
            this.updateTicketLabel.Size = new System.Drawing.Size(370, 48);
            this.updateTicketLabel.TabIndex = 20;
            this.updateTicketLabel.Text = "Update incident ticket";
            // 
            // S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.updateTicketLabel);
            this.Controls.Add(this.updateTicketButton);
            this.Controls.Add(this.submitTicketButton);
            this.Controls.Add(this.cancelTicketButton);
            this.Controls.Add(this.ticketReportedDateTimePicker);
            this.Controls.Add(this.ticketDeadlineFollowUpComboBox);
            this.Controls.Add(this.ticketPriorityComboBox);
            this.Controls.Add(this.ticketReportedUserComboBox);
            this.Controls.Add(this.ticketTypeIncidentComboBox);
            this.Controls.Add(this.ticketDescriptionTextBox);
            this.Controls.Add(this.ticketSubjectIncidentTextBox);
            this.Controls.Add(this.ticketDescriptionLabel);
            this.Controls.Add(this.ticketDeadlineFollowUpLabel);
            this.Controls.Add(this.ticketPriorityLabel);
            this.Controls.Add(this.ticketReportedUserLabel);
            this.Controls.Add(this.ticketTypeIncidentLabel);
            this.Controls.Add(this.ticketSubjectIncidentLabel);
            this.Controls.Add(this.dateTimeReportedLabel);
            this.Controls.Add(this.createTicketHeaderLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "S";
            this.Size = new System.Drawing.Size(1640, 886);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTicketHeaderLabel;
        private System.Windows.Forms.Label dateTimeReportedLabel;
        private System.Windows.Forms.Label ticketSubjectIncidentLabel;
        private System.Windows.Forms.Label ticketTypeIncidentLabel;
        private System.Windows.Forms.Label ticketReportedUserLabel;
        private System.Windows.Forms.Label ticketPriorityLabel;
        private System.Windows.Forms.Label ticketDeadlineFollowUpLabel;
        private System.Windows.Forms.Label ticketDescriptionLabel;
        private System.Windows.Forms.TextBox ticketSubjectIncidentTextBox;
        private System.Windows.Forms.TextBox ticketDescriptionTextBox;
        private System.Windows.Forms.ComboBox ticketTypeIncidentComboBox;
        private System.Windows.Forms.ComboBox ticketReportedUserComboBox;
        private System.Windows.Forms.ComboBox ticketPriorityComboBox;
        private System.Windows.Forms.ComboBox ticketDeadlineFollowUpComboBox;
        private System.Windows.Forms.DateTimePicker ticketReportedDateTimePicker;
        private System.Windows.Forms.Button cancelTicketButton;
        private System.Windows.Forms.Button submitTicketButton;
        private System.Windows.Forms.Button updateTicketButton;
        private System.Windows.Forms.Label updateTicketLabel;
    }
}
