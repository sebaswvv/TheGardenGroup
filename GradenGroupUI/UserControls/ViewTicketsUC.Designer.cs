namespace GradenGroupUI.UserControls
{
    partial class ViewTicketsUC
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
            this.components = new System.ComponentModel.Container();
            this.showTicketsButton = new System.Windows.Forms.Button();
            this.showDashboardTicketsButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pieChartPanel = new System.Windows.Forms.Panel();
            this.panelViewTickets = new System.Windows.Forms.Panel();
            this.allTicketsListView = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.reportedAt = new System.Windows.Forms.ColumnHeader();
            this.subject = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.priority = new System.Windows.Forms.ColumnHeader();
            this.deadline = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panelViewTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // showTicketsButton
            // 
            this.showTicketsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.showTicketsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showTicketsButton.Location = new System.Drawing.Point(45, 36);
            this.showTicketsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showTicketsButton.Name = "showTicketsButton";
            this.showTicketsButton.Size = new System.Drawing.Size(190, 59);
            this.showTicketsButton.TabIndex = 0;
            this.showTicketsButton.Text = "Show all my tickets";
            this.showTicketsButton.UseVisualStyleBackColor = false;
            this.showTicketsButton.Click += new System.EventHandler(this.showTicketsButton_Click);
            // 
            // showDashboardTicketsButton
            // 
            this.showDashboardTicketsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.showDashboardTicketsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showDashboardTicketsButton.Location = new System.Drawing.Point(45, 117);
            this.showDashboardTicketsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showDashboardTicketsButton.Name = "showDashboardTicketsButton";
            this.showDashboardTicketsButton.Size = new System.Drawing.Size(190, 59);
            this.showDashboardTicketsButton.TabIndex = 1;
            this.showDashboardTicketsButton.Text = "Show dashboard";
            this.showDashboardTicketsButton.UseVisualStyleBackColor = false;
            this.showDashboardTicketsButton.Click += new System.EventHandler(this.showDashboardTicketsButton_Click);
            // 
            // pieChartPanel
            // 
            this.pieChartPanel.Location = new System.Drawing.Point(252, 91);
            this.pieChartPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pieChartPanel.Name = "pieChartPanel";
            this.pieChartPanel.Size = new System.Drawing.Size(787, 623);
            this.pieChartPanel.TabIndex = 2;
            // 
            // panelViewTickets
            // 
            this.panelViewTickets.Controls.Add(this.allTicketsListView);
            this.panelViewTickets.Location = new System.Drawing.Point(252, 87);
            this.panelViewTickets.Name = "panelViewTickets";
            this.panelViewTickets.Size = new System.Drawing.Size(1337, 641);
            this.panelViewTickets.TabIndex = 3;
            // 
            // allTicketsListView
            // 
            this.allTicketsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.reportedAt,
            this.subject,
            this.description,
            this.priority,
            this.deadline,
            this.status});
            this.allTicketsListView.Location = new System.Drawing.Point(3, 3);
            this.allTicketsListView.Name = "allTicketsListView";
            this.allTicketsListView.Size = new System.Drawing.Size(1331, 624);
            this.allTicketsListView.TabIndex = 0;
            this.allTicketsListView.UseCompatibleStateImageBehavior = false;
            this.allTicketsListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id:";
            // 
            // reportedAt
            // 
            this.reportedAt.Text = "Date reported:";
            this.reportedAt.Width = 150;
            // 
            // subject
            // 
            this.subject.Text = "Subject:";
            this.subject.Width = 200;
            // 
            // description
            // 
            this.description.Text = "Description:";
            this.description.Width = 610;
            // 
            // priority
            // 
            this.priority.Text = "Priority:";
            this.priority.Width = 100;
            // 
            // deadline
            // 
            this.deadline.Text = "Deadline:";
            this.deadline.Width = 100;
            // 
            // status
            // 
            this.status.Text = "Status:";
            this.status.Width = 100;
            // 
            // ViewTicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pieChartPanel);
            this.Controls.Add(this.panelViewTickets);
            this.Controls.Add(this.showDashboardTicketsButton);
            this.Controls.Add(this.showTicketsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewTicketsUC";
            this.Size = new System.Drawing.Size(1614, 971);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panelViewTickets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showTicketsButton;
        private System.Windows.Forms.Button showDashboardTicketsButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pieChartPanel;
        private System.Windows.Forms.Panel panelViewTickets;
        private System.Windows.Forms.ListView allTicketsListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader reportedAt;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader priority;
        private System.Windows.Forms.ColumnHeader deadline;
        private System.Windows.Forms.ColumnHeader status;
    }
}
