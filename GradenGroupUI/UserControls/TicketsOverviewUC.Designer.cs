namespace GradenGroupUI.UserControls
{
    partial class TicketsOverviewUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.overviewTicketsLabel = new System.Windows.Forms.Label();
            this.createIncidentButton = new System.Windows.Forms.Button();
            this.ticketsList = new System.Windows.Forms.DataGridView();
            this.viewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfIncident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsList)).BeginInit();
            this.SuspendLayout();
            // 
            // overviewTicketsLabel
            // 
            this.overviewTicketsLabel.AutoSize = true;
            this.overviewTicketsLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.overviewTicketsLabel.Location = new System.Drawing.Point(8, 13);
            this.overviewTicketsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.overviewTicketsLabel.Name = "overviewTicketsLabel";
            this.overviewTicketsLabel.Size = new System.Drawing.Size(236, 37);
            this.overviewTicketsLabel.TabIndex = 0;
            this.overviewTicketsLabel.Text = "Overview Tickets";
            // 
            // createIncidentButton
            // 
            this.createIncidentButton.FlatAppearance.BorderSize = 0;
            this.createIncidentButton.Location = new System.Drawing.Point(1685, 13);
            this.createIncidentButton.Margin = new System.Windows.Forms.Padding(2);
            this.createIncidentButton.Name = "createIncidentButton";
            this.createIncidentButton.Size = new System.Drawing.Size(116, 46);
            this.createIncidentButton.TabIndex = 2;
            this.createIncidentButton.Text = "Create Incident";
            this.createIncidentButton.UseVisualStyleBackColor = true;
            // 
            // ticketsList
            // 
            this.ticketsList.AllowUserToAddRows = false;
            this.ticketsList.AllowUserToDeleteRows = false;
            this.ticketsList.AllowUserToResizeRows = false;
            this.ticketsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ticketsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticketsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ticketsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ticketsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viewButtonColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.typeOfIncident,
            this.createdBy});
            this.ticketsList.Location = new System.Drawing.Point(16, 64);
            this.ticketsList.MultiSelect = false;
            this.ticketsList.Name = "ticketsList";
            this.ticketsList.ReadOnly = true;
            this.ticketsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ticketsList.RowHeadersVisible = false;
            this.ticketsList.RowTemplate.Height = 25;
            this.ticketsList.ShowEditingIcon = false;
            this.ticketsList.Size = new System.Drawing.Size(1785, 679);
            this.ticketsList.TabIndex = 3;
            this.ticketsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketsList_CellClick);
            // 
            // viewButtonColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewButtonColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewButtonColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButtonColumn.HeaderText = "";
            this.viewButtonColumn.Name = "viewButtonColumn";
            this.viewButtonColumn.ReadOnly = true;
            this.viewButtonColumn.Text = "View";
            this.viewButtonColumn.UseColumnTextForButtonValue = true;
            this.viewButtonColumn.Width = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn1.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Priority";
            this.dataGridViewTextBoxColumn2.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateReported";
            this.dataGridViewTextBoxColumn3.HeaderText = "Reported at";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // typeOfIncident
            // 
            this.typeOfIncident.DataPropertyName = "IncidentType";
            this.typeOfIncident.HeaderText = "Type of incident";
            this.typeOfIncident.Name = "typeOfIncident";
            this.typeOfIncident.ReadOnly = true;
            this.typeOfIncident.Width = 150;
            // 
            // createdBy
            // 
            this.createdBy.DataPropertyName = "Employee";
            this.createdBy.HeaderText = "Reported by";
            this.createdBy.Name = "createdBy";
            this.createdBy.ReadOnly = true;
            this.createdBy.Width = 150;
            // 
            // TicketsOverviewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ticketsList);
            this.Controls.Add(this.createIncidentButton);
            this.Controls.Add(this.overviewTicketsLabel);
            this.Name = "TicketsOverviewUC";
            this.Size = new System.Drawing.Size(1804, 746);
            this.Load += new System.EventHandler(this.TicketsOverviewUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label overviewTicketsLabel;
        private System.Windows.Forms.Button createIncidentButton;
        private System.Windows.Forms.DataGridView ticketsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfIncident;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn viewButtonColumn;
    }
}
