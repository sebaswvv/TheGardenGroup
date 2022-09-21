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
            this.SuspendLayout();
            // 
            // showTicketsButton
            // 
            this.showTicketsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.showTicketsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showTicketsButton.Location = new System.Drawing.Point(39, 27);
            this.showTicketsButton.Name = "showTicketsButton";
            this.showTicketsButton.Size = new System.Drawing.Size(166, 44);
            this.showTicketsButton.TabIndex = 0;
            this.showTicketsButton.Text = "Show all tickets";
            this.showTicketsButton.UseVisualStyleBackColor = false;
            this.showTicketsButton.Click += new System.EventHandler(this.showTicketsButton_Click);
            // 
            // ViewTicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showTicketsButton);
            this.Name = "ViewTicketsUC";
            this.Size = new System.Drawing.Size(1412, 728);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showTicketsButton;
    }
}
