namespace GradenGroupUI.UserControls
{
    partial class TicketsOverviewUC
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.overviewTicketsLabel = new System.Windows.Forms.Label();
            this.ticketsList = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.subject = new System.Windows.Forms.ColumnHeader();
            this.user = new System.Windows.Forms.ColumnHeader();
            this.incidentType = new System.Windows.Forms.ColumnHeader();
            this.priority = new System.Windows.Forms.ColumnHeader();
            this.reportedAt = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // overviewTicketsLabel
            // 
            this.overviewTicketsLabel.AutoSize = true;
            this.overviewTicketsLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.overviewTicketsLabel.Location = new System.Drawing.Point(16, 13);
            this.overviewTicketsLabel.Name = "overviewTicketsLabel";
            this.overviewTicketsLabel.Size = new System.Drawing.Size(236, 37);
            this.overviewTicketsLabel.TabIndex = 0;
            this.overviewTicketsLabel.Text = "Overview Tickets";
            // 
            // ticketsList
            // 
            this.ticketsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticketsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.subject,
            this.user,
            this.incidentType,
            this.priority,
            this.reportedAt,
            this.status});
            this.ticketsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ticketsList.Location = new System.Drawing.Point(25, 62);
            this.ticketsList.MultiSelect = false;
            this.ticketsList.Name = "ticketsList";
            this.ticketsList.Size = new System.Drawing.Size(860, 361);
            this.ticketsList.TabIndex = 1;
            this.ticketsList.UseCompatibleStateImageBehavior = false;
            this.ticketsList.View = System.Windows.Forms.View.Details;
            this.ticketsList.SelectedIndexChanged += new System.EventHandler(this.ticketsList_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // subject
            // 
            this.subject.Text = "Subject";
            this.subject.Width = 300;
            // 
            // user
            // 
            this.user.Text = "User";
            this.user.Width = 120;
            // 
            // incidentType
            // 
            this.incidentType.Text = "Type of incident";
            this.incidentType.Width = 100;
            // 
            // priority
            // 
            this.priority.Text = "Priority";
            // 
            // reportedAt
            // 
            this.reportedAt.Text = "Reported at";
            this.reportedAt.Width = 120;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 100;
            // 
            // TicketsOverviewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ticketsList);
            this.Controls.Add(this.overviewTicketsLabel);
            this.Name = "TicketsOverviewUC";
            this.Size = new System.Drawing.Size(931, 442);
            this.Load += new System.EventHandler(this.TicketsOverviewUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label overviewTicketsLabel;
        private System.Windows.Forms.ListView ticketsList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.ColumnHeader incidentType;
        private System.Windows.Forms.ColumnHeader priority;
        private System.Windows.Forms.ColumnHeader reportedAt;
        private System.Windows.Forms.ColumnHeader status;
    }
}
