﻿using System;
using System.Drawing;
using System.Windows.Forms;
using GardenGroupModel;

namespace GradenGroupUI
{
    public partial class RegularEmployeeForm : Form
    {
        private Employee employee;
        public RegularEmployeeForm(Employee employee)
        {
            InitializeComponent();

            StyleUI();

            this.employee = employee;
            DockViewTicketsUC();
        }

        private void StyleUI()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.menuPanel.BackColor = Color.FromArgb(156, 179, 128);
            this.buttonCreateTicket.BackColor = Color.FromArgb(27, 81, 43);
            this.showDashboardButton.BackColor = Color.FromArgb(27, 81, 43);
            this.logoutButton.BackColor = Color.White;
        }

        public void DockViewTicketsUC()
        {            
            UserControls.ViewTicketsUC viewTicketsUC = new UserControls.ViewTicketsUC(this.employee, this);
            viewTicketsUC.Dock = DockStyle.Fill;
            this.viewTicketsPanel.Controls.Clear();
            this.viewTicketsPanel.Controls.Add(viewTicketsUC);
        }
        
        public void DockAddTicketsUC()
        {
            this.viewTicketsPanel.Controls.Clear();        
       
            // make and dock
            UserControls.CreateTicketUC createTicketUC = new UserControls.CreateTicketUC(this.employee, this);
            createTicketUC.Dock = DockStyle.Fill;
            this.viewTicketsPanel.Controls.Add(createTicketUC);
        }

        public void DockEditTicket(Ticket ticket)
        {
            this.viewTicketsPanel.Controls.Clear();

            // make and dock
            UserControls.CreateTicketUC createTicketUC = new UserControls.CreateTicketUC(this.employee, this, ticket);
            createTicketUC.Dock = DockStyle.Fill;
            this.viewTicketsPanel.Controls.Add(createTicketUC);
        }

        private void showDashboardButton_Click(object sender, EventArgs e)
        {
            DockViewTicketsUC();
        }

        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            DockAddTicketsUC();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
            loginForm.Closed += (s, args) => this.Close();
        }
    }
}
