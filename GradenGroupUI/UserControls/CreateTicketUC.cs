﻿using GardenGroupLogic;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradenGroupUI.UserControls
{
    public partial class CreateTicketUC : UserControl
    {
        public CreateTicketUC(Employee employee)
        {
            InitializeComponent();
            // TODO hide option to select an employee
        }      

        // Submits a ticket
        private void submitTicketButton_Click(object sender, EventArgs e)
        {
            //Ticket ticket = new Ticket()
            //{
            //    EmployeeID = , // Employee Id from the current user if it is a regular employee otherwise the ServiceDeskEmployee can select an employee
            //    DateReported = TicketReportedDateTimePicker.Value,
            //    Subject = ticketSubjectIncidentTextBox.Text,
            //    Priority = (GardenGroupModel.Enums.Priority)ticketPriorityComboBox.SelectionStart,
            //    Deadline = (GardenGroupModel.Enums.Deadline)ticketDeadlineFollowUpComboBox.SelectionStart,
            //    Description = ticketDescriptionTextBox.Text,
            //    Status = GardenGroupModel.Enums.Status.Open

            //};

            TicketService ticketService = new TicketService();
            
        }

        private void cancelTicketButton_Click(object sender, EventArgs e)
        {
            //TODO reset all boxes to default
        }

        // 
        //private void CheckEmployee(Employee employee)
        //{

        //}

        //private string GetEmployeeId()
        //{
        //    string 
        //    if (cur)
        //}
    }
}
