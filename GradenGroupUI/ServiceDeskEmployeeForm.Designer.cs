﻿using System.Windows.Forms;

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
            this.SuspendLayout();

            this.userControlPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // userControlPanel

            this.userControlPanel.Location = new System.Drawing.Point(0, 0);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(1070, 625);
            this.userControlPanel.TabIndex = 0;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ClientSize = new System.Drawing.Size(1069, 625);
            this.userControlPanel.Location = new System.Drawing.Point(0, -1);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(2050, 1254);
            this.userControlPanel.TabIndex = 0;
            // 
            // ServiceDeskEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2051, 1253);
            this.Controls.Add(this.userControlPanel);
            this.Name = "ServiceDeskEmployeeForm";
            this.Text = "ServiceDeskEmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        
    }
}