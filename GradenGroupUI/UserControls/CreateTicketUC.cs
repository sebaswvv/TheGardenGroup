using GardenGroupLogic;
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
        }

        // Submits a ticket
        private void submitTicketButton_Click(object sender, EventArgs e)
        {
            //Ticket ticket = new Ticket()
            //{
            //    EmployeeID = "", // Employee Id from the current user if it is a regular employee

            //    // TODO make an method that recieves the employee ID from the current user and 
            //    Subject = ticketSubjectIncidentTextBox.Text,
            //    Priority = (GardenGroupModel.Enums.Priority)ticketPriorityComboBox.SelectionStart,


            //};

            TicketService ticketService = new TicketService();
            
        }

        private void cancelTicketButton_Click(object sender, EventArgs e)
        {
            //TODO reset all boxes to default
        }
    }
}
