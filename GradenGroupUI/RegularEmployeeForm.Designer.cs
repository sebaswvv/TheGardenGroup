﻿namespace GradenGroupUI
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
            this.SuspendLayout();
            // 
            // viewTicketsPanel
            // 
            this.viewTicketsPanel.Location = new System.Drawing.Point(14, 16);
            this.viewTicketsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewTicketsPanel.Name = "viewTicketsPanel";
            this.viewTicketsPanel.Size = new System.Drawing.Size(1690, 971);
            this.viewTicketsPanel.TabIndex = 0;
            // 
            // RegularEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 1003);
            this.Controls.Add(this.viewTicketsPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegularEmployeeForm";
            this.Text = "RegularEmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewTicketsPanel;
    }
}