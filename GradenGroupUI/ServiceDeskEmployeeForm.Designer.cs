using System.Windows.Forms;

namespace GradenGroupUI
{
    partial class ServiceDeskEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel userControlPanel;

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
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showDashboardButton = new System.Windows.Forms.Button();
            this.buttonCreateTicket = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControlPanel
            // 
            this.userControlPanel.Location = new System.Drawing.Point(12, 109);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(1804, 757);
            this.userControlPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.showDashboardButton);
            this.menuPanel.Controls.Add(this.buttonCreateTicket);
            this.menuPanel.Location = new System.Drawing.Point(2, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1845, 116);
            this.menuPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "The Garden Group Service";
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
            // 
            // ServiceDeskEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 866);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.userControlPanel);
            this.Name = "ServiceDeskEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TGG";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private Panel menuPanel;
        private Label label1;
        private Button showDashboardButton;
        private Button buttonCreateTicket;
    }
}