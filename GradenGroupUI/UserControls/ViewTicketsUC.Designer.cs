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
            this.showTicketsButton = new System.Windows.Forms.Button();
            this.showDashboardTicketsButton = new System.Windows.Forms.Button();
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
            this.showDashboardTicketsButton.Location = new System.Drawing.Point(45, 118);
            this.showDashboardTicketsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showDashboardTicketsButton.Name = "showDashboardTicketsButton";
            this.showDashboardTicketsButton.Size = new System.Drawing.Size(190, 59);
            this.showDashboardTicketsButton.TabIndex = 1;
            this.showDashboardTicketsButton.Text = "Show dashboard";
            this.showDashboardTicketsButton.UseVisualStyleBackColor = false;
            this.showDashboardTicketsButton.Click += new System.EventHandler(this.showDashboardTicketsButton_Click);
            // 
            // ViewTicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showDashboardTicketsButton);
            this.Controls.Add(this.showTicketsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewTicketsUC";
            this.Size = new System.Drawing.Size(1614, 971);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showTicketsButton;
        private System.Windows.Forms.Button showDashboardTicketsButton;
    }
}
