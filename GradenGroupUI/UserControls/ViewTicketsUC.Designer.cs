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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.pieChartPanel.Location = new System.Drawing.Point(394, 185);
            this.pieChartPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pieChartPanel.Name = "pieChartPanel";
            this.pieChartPanel.Size = new System.Drawing.Size(645, 529);
            this.pieChartPanel.TabIndex = 2;
            // 
            // panelViewTickets
            // 
            this.panelViewTickets.Location = new System.Drawing.Point(345, 87);
            this.panelViewTickets.Name = "panelViewTickets";
            this.panelViewTickets.Size = new System.Drawing.Size(804, 641);
            this.panelViewTickets.TabIndex = 3;
            // 
            // ViewTicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelViewTickets);
            this.Controls.Add(this.pieChartPanel);
            this.Controls.Add(this.showDashboardTicketsButton);
            this.Controls.Add(this.showTicketsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewTicketsUC";
            this.Size = new System.Drawing.Size(1614, 971);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showTicketsButton;
        private System.Windows.Forms.Button showDashboardTicketsButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pieChartPanel;
        private System.Windows.Forms.Panel panelViewTickets;
    }
}
