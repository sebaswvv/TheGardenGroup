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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dockPanel = new System.Windows.Forms.Panel();
            this.allTicketsListView = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.reportedAt = new System.Windows.Forms.ColumnHeader();
            this.subject = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.priority = new System.Windows.Forms.ColumnHeader();
            this.deadline = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.welcomeText = new System.Windows.Forms.Label();
            this.createNewTicketButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.dockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel
            // 
            this.dockPanel.Controls.Add(this.allTicketsListView);
            this.dockPanel.Location = new System.Drawing.Point(3, 75);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1649, 500);
            this.dockPanel.TabIndex = 2;
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
            this.allTicketsListView.Location = new System.Drawing.Point(23, 29);
            this.allTicketsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allTicketsListView.Name = "allTicketsListView";
            this.allTicketsListView.Size = new System.Drawing.Size(1225, 429);
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
            this.description.Width = 500;
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
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeText.Location = new System.Drawing.Point(25, 19);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(153, 32);
            this.welcomeText.TabIndex = 4;
            this.welcomeText.Text = "Welcome {User}";
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // createNewTicketButton
            // 
            this.createNewTicketButton.Location = new System.Drawing.Point(1256, 19);
            this.createNewTicketButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createNewTicketButton.Name = "createNewTicketButton";
            this.createNewTicketButton.Size = new System.Drawing.Size(173, 42);
            this.createNewTicketButton.TabIndex = 5;
            this.createNewTicketButton.Text = "Create new Ticket";
            this.createNewTicketButton.UseVisualStyleBackColor = true;
            this.createNewTicketButton.Click += new System.EventHandler(this.createNewTicketButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // ViewTicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createNewTicketButton);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.dockPanel);
            this.Name = "ViewTicketsUC";
            this.Size = new System.Drawing.Size(1672, 592);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.dockPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel dockPanel;
        private System.Windows.Forms.ListView allTicketsListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader reportedAt;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader priority;
        private System.Windows.Forms.ColumnHeader deadline;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button createNewTicketButton;
        private System.Windows.Forms.Label label1;
    }
}
