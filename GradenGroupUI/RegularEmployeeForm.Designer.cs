namespace GradenGroupUI
{
    partial class RegularEmployeeForm
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
            this.viewTicketsPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showDashboardButton = new System.Windows.Forms.Button();
            this.buttonCreateTicket = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewTicketsPanel
            // 
            this.viewTicketsPanel.Location = new System.Drawing.Point(12, 107);
            this.viewTicketsPanel.Name = "viewTicketsPanel";
            this.viewTicketsPanel.Size = new System.Drawing.Size(1804, 757);
            this.viewTicketsPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.showDashboardButton);
            this.menuPanel.Controls.Add(this.buttonCreateTicket);
            this.menuPanel.Location = new System.Drawing.Point(-1, 1);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1845, 108);
            this.menuPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Green Desk";
            // 
            // showDashboardButton
            // 
            this.showDashboardButton.FlatAppearance.BorderSize = 0;
            this.showDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showDashboardButton.ForeColor = System.Drawing.Color.White;
            this.showDashboardButton.Location = new System.Drawing.Point(1680, 63);
            this.showDashboardButton.Name = "showDashboardButton";
            this.showDashboardButton.Size = new System.Drawing.Size(137, 37);
            this.showDashboardButton.TabIndex = 1;
            this.showDashboardButton.Text = "Show dashboard";
            this.showDashboardButton.UseVisualStyleBackColor = true;
            this.showDashboardButton.Click += new System.EventHandler(this.showDashboardButton_Click);
            // 
            // buttonCreateTicket
            // 
            this.buttonCreateTicket.FlatAppearance.BorderSize = 0;
            this.buttonCreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTicket.ForeColor = System.Drawing.Color.White;
            this.buttonCreateTicket.Location = new System.Drawing.Point(1511, 63);
            this.buttonCreateTicket.Name = "buttonCreateTicket";
            this.buttonCreateTicket.Size = new System.Drawing.Size(137, 37);
            this.buttonCreateTicket.TabIndex = 0;
            this.buttonCreateTicket.Text = "Create ticket";
            this.buttonCreateTicket.UseVisualStyleBackColor = true;
            this.buttonCreateTicket.Click += new System.EventHandler(this.buttonCreateTicket_Click);
            // 
            // RegularEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 866);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.viewTicketsPanel);
            this.Name = "RegularEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TGG";
            this.Load += new System.EventHandler(this.RegularEmployeeForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewTicketsPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button buttonCreateTicket;
        private System.Windows.Forms.Button showDashboardButton;
        private System.Windows.Forms.Label label1;
    }
}