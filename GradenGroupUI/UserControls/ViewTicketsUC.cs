﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;
using System.Windows.Forms.DataVisualization.Charting;

namespace GradenGroupUI.UserControls
{
    public partial class ViewTicketsUC : UserControl
    {        
        private TicketService ticketService;
        private List<Ticket> ticketsOfUser;
        private RegularEmployeeForm regularEmployeeForm;
        private Employee employee;        

        public ViewTicketsUC(Employee employee, RegularEmployeeForm regularEmployeeForm)
        {
            InitializeComponent();            
            this.ticketService = new TicketService();
            this.employee = employee;
            this.ticketsOfUser = GetAllTicketsOfUser(employee);
            this.regularEmployeeForm = regularEmployeeForm;

            this.welcomeText.Text = $"Welcome {employee.FirstName} {employee.LastName}";

            StyleUI();

            DisplayTicketsOfUser(this.ticketsOfUser);
            ShowDashBoardTickets();
        }

        private void StyleUI()
        {            
            this.buttonOpen.BackColor = Color.FromArgb(156, 179, 128);
            this.buttonClose.BackColor = Color.FromArgb(156, 179, 128);
            this.buttonResolved.BackColor = Color.FromArgb(156, 179, 128);
            this.updateButton.BackColor = Color.FromArgb(156, 179, 128);

            this.allTicketsListView.FullRowSelect = true;
        }
        

        private void ShowDashBoardTickets()
        {
            // remove the existing pie chart
            this.dockPanel.Controls.Clear();
           
            double[] percentageTicketStatus = GetPercentageTicketStatus();

            // Create a new chart.
            Chart chart = new Chart();               
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "Default";
            chart.ChartAreas.Add(chartArea);           
            
            // make the chart
            chart.Series.Add("Tickets");
            chart.Series["Tickets"].ChartType = SeriesChartType.Pie;            
            chart.BackColor = Color.FromArgb(156, 179, 128);                    
            chart.Size = new Size(380, 380);

            int amountOfPies = 0;

            // load data with 2 digits after the comma
            // change pies colour
            if (percentageTicketStatus[0] != 0)
            {
                chart.Series["Tickets"].Points.AddXY($"Open {Math.Round(percentageTicketStatus[0])}%", percentageTicketStatus[0]);
                chart.Series["Tickets"].Points[amountOfPies].Color = Color.FromArgb(108, 255, 108);
                amountOfPies++;
            }
            if (percentageTicketStatus[1] != 0)
            {
                chart.Series["Tickets"].Points.AddXY($"Closed {Math.Round(percentageTicketStatus[1])}%", percentageTicketStatus[1]);
                chart.Series["Tickets"].Points[amountOfPies].Color = Color.FromArgb(255, 58, 58);
                amountOfPies++;
            }
            if (percentageTicketStatus[2] != 0)
            {
                chart.Series["Tickets"].Points.AddXY($"Resolved {Math.Round(percentageTicketStatus[2])}%", percentageTicketStatus[2]);                
                chart.Series["Tickets"].Points[amountOfPies].Color = Color.FromArgb(255, 150, 71);
                amountOfPies++;
            }           

            // add the chart to the form
            this.dockPanel.Controls.Add(chart);
        }        

        private void DisplayTicketsOfUser(List<Ticket> tickets)
        {
            this.allTicketsListView.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = CreateListViewItem(ticket);
                this.allTicketsListView.Items.Add(item);
                item.Tag = ticket;
            }
        }

        private ListViewItem CreateListViewItem(Ticket ticket)
        {
            string deadline = "";
            DateTime deadLineDate = DateTime.Now;
            // Get the deadline of the ticket and format it
            switch (ticket.Deadline)
            {
                case GardenGroupModel.Enums.Deadline.SevenDays:
                    deadline = ticket.DateReported.AddDays(7).ToString("dd/MM/yyyy");
                    deadLineDate = ticket.DateReported.AddDays(7);
                    break;
                case GardenGroupModel.Enums.Deadline.FourtheenDays:
                    deadline = ticket.DateReported.AddDays(14).ToString("dd/MM/yyyy");
                    deadLineDate = ticket.DateReported.AddDays(7);
                    break;
                case GardenGroupModel.Enums.Deadline.TwentyEightDays:
                    deadline = ticket.DateReported.AddDays(28).ToString("dd/MM/yyyy");
                    deadLineDate = ticket.DateReported.AddDays(7);
                    break;
                case GardenGroupModel.Enums.Deadline.SixMonths:
                    deadline = ticket.DateReported.AddMonths(6).ToString("dd/MM/yyyy");
                    deadLineDate = ticket.DateReported.AddDays(7);
                    break;
            }

            ListViewItem item = new ListViewItem(new string[] {ticket.Subject,
                ticket.Description,
                ticket.DateReported.ToString("dd/MM/yyyy"),
                ticket.Priority.ToString(), deadline,
                ticket.Status.ToString()});            

            return item;
        }

        private double[] GetPercentageTicketStatus()
        {
            int[] ticketSatus = new int[3];
            // View a dashboard with current status of tickets (% open, % resolved, % closed without resolve)
            foreach (Ticket ticket in this.ticketsOfUser)
            {
                switch (ticket.Status)
                {
                    case GardenGroupModel.Enums.Status.Open:
                        ticketSatus[0]++;
                        break;
                    case GardenGroupModel.Enums.Status.Closed:
                        ticketSatus[1]++;
                        break;
                    case GardenGroupModel.Enums.Status.Resolved:
                        ticketSatus[2]++;
                        break;
                }
            }
            double[] percentageTicketStatus = new double[3];
            for (int i = 0; i < ticketSatus.Length; i++)
                percentageTicketStatus[i] = (double)ticketSatus[i] / this.ticketsOfUser.Count * 100;
            return percentageTicketStatus;
        }

        private List<Ticket> GetAllTicketsOfUser(Employee employee)
        {
            return this.ticketService.GetTicketsOfUser(employee.Id);            
        }        

        private void allTicketsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allTicketsListView.SelectedItems.Count == 0)
                return;
            // get the selected ticket
            Ticket ticket = (Ticket)allTicketsListView.SelectedItems[0].Tag;
            this.itemSubjectTextBox.Text = ticket.Subject;

            switch (ticket.Status)
            {
                case GardenGroupModel.Enums.Status.Open:
                    this.buttonResolved.Enabled = true;
                    this.buttonClose.Enabled = true;
                    this.buttonOpen.Enabled = false;
                    break;
                case GardenGroupModel.Enums.Status.Resolved:
                    this.buttonResolved.Enabled = false;
                    this.buttonClose.Enabled = true;
                    this.buttonOpen.Enabled = true;
                    break;
                case GardenGroupModel.Enums.Status.Closed:
                    this.buttonResolved.Enabled = true;
                    this.buttonClose.Enabled = false;
                    this.buttonOpen.Enabled = true;
                    break;
            }
        }

        private void buttonResolved_Click(object sender, EventArgs e)
        {            
            if (allTicketsListView.SelectedItems.Count == 0)
                return;
            Ticket ticket = (Ticket)allTicketsListView.SelectedItems[0].Tag;
            ticket.Status = GardenGroupModel.Enums.Status.Resolved;
            this.ticketService.ChangeTicketStatus(ticket);
            UpdateUI();
        }        

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (allTicketsListView.SelectedItems.Count == 0)
                return;
            Ticket ticket = (Ticket)allTicketsListView.SelectedItems[0].Tag;
            ticket.Status = GardenGroupModel.Enums.Status.Closed;
            this.ticketService.ChangeTicketStatus(ticket);
            UpdateUI();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (allTicketsListView.SelectedItems.Count == 0)
                return;
            Ticket ticket = (Ticket)allTicketsListView.SelectedItems[0].Tag;
            ticket.Status = GardenGroupModel.Enums.Status.Open;
            this.ticketService.ChangeTicketStatus(ticket);
            UpdateUI();
        }

        private void UpdateUI()
        {
            // update the dashboard
            this.ticketsOfUser = GetAllTicketsOfUser(this.employee);
            ShowDashBoardTickets();            
            DisplayTicketsOfUser(this.ticketsOfUser);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (allTicketsListView.SelectedItems.Count == 0)
                return;
            this.regularEmployeeForm.DockEditTicket((Ticket)allTicketsListView.SelectedItems[0].Tag);
        }
    }
}
