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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonResolved = new System.Windows.Forms.Button();
            this.itemSubjectTextBox = new System.Windows.Forms.TextBox();
            this.allTicketsListView = new System.Windows.Forms.ListView();
            this.subject = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.reportedAt = new System.Windows.Forms.ColumnHeader();
            this.priority = new System.Windows.Forms.ColumnHeader();
            this.deadline = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.welcomeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockPanel
            // 
            this.dockPanel.Location = new System.Drawing.Point(1109, 138);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(380, 380);
            this.dockPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1109, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status of your tickets:";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(283, 579);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(202, 579);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonResolved
            // 
            this.buttonResolved.Location = new System.Drawing.Point(121, 579);
            this.buttonResolved.Name = "buttonResolved";
            this.buttonResolved.Size = new System.Drawing.Size(75, 23);
            this.buttonResolved.TabIndex = 3;
            this.buttonResolved.Text = "Resolve";
            this.buttonResolved.UseVisualStyleBackColor = true;
            this.buttonResolved.Click += new System.EventHandler(this.buttonResolved_Click);
            // 
            // itemSubjectTextBox
            // 
            this.itemSubjectTextBox.Location = new System.Drawing.Point(122, 543);
            this.itemSubjectTextBox.Name = "itemSubjectTextBox";
            this.itemSubjectTextBox.PlaceholderText = "Item subject.....";
            this.itemSubjectTextBox.ReadOnly = true;
            this.itemSubjectTextBox.Size = new System.Drawing.Size(236, 23);
            this.itemSubjectTextBox.TabIndex = 2;
            // 
            // allTicketsListView
            // 
            this.allTicketsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subject,
            this.description,
            this.reportedAt,
            this.priority,
            this.deadline,
            this.status});
            this.allTicketsListView.Location = new System.Drawing.Point(24, 89);
            this.allTicketsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allTicketsListView.Name = "allTicketsListView";
            this.allTicketsListView.Size = new System.Drawing.Size(1059, 429);
            this.allTicketsListView.TabIndex = 0;
            this.allTicketsListView.UseCompatibleStateImageBehavior = false;
            this.allTicketsListView.View = System.Windows.Forms.View.Details;
            this.allTicketsListView.SelectedIndexChanged += new System.EventHandler(this.allTicketsListView_SelectedIndexChanged);
            // 
            // subject
            // 
            this.subject.Text = "Subject:";
            this.subject.Width = 200;
            // 
            // description
            // 
            this.description.Text = "Description:";
            this.description.Width = 400;
            // 
            // reportedAt
            // 
            this.reportedAt.Text = "Date reported:";
            this.reportedAt.Width = 150;
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
            this.welcomeText.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeText.Location = new System.Drawing.Point(25, 19);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(164, 32);
            this.welcomeText.TabIndex = 4;
            this.welcomeText.Text = "Welcome {User}";
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Here you can view and create tickets.";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(27, 558);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 27);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ViewTicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allTicketsListView);
            this.Controls.Add(this.itemSubjectTextBox);
            this.Controls.Add(this.buttonResolved);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.dockPanel);
            this.Name = "ViewTicketsUC";
            this.Size = new System.Drawing.Size(1672, 628);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel dockPanel;
        private System.Windows.Forms.ListView allTicketsListView;
        private System.Windows.Forms.ColumnHeader reportedAt;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader priority;
        private System.Windows.Forms.ColumnHeader deadline;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Label welcomeText;        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemSubjectTextBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonResolved;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button updateButton;
    }
}
