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
        private List<Employee> employees;

        public CreateTicketUC(Employee employee)
        {            
            InitializeComponent();
            EmployeeService employeeService = new EmployeeService();
            this.employees = employeeService.GetAllEmployees();
            FillComboBox();
            // TODO hide option to select an employee
        }
              

        // Submits a ticket
        private void submitTicketButton_Click(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();

            // tag in comboBox 
            //string employeeID = ticketReportedUserComboBox.SelectedIndex.ToString();
            //Ticket ticket = new Ticket()
            //{
            //    EmployeeID = (string)ticketReportedUserComboBox.SelectedItem, // Employee Id from the current user if it is a regular employee otherwise the ServiceDeskEmployee can select an employee
            //    DateReported = TicketReportedDateTimePicker.Value,
            //    Subject = ticketSubjectIncidentTextBox.Text,
            //    Priority = (GardenGroupModel.Enums.Priority)ticketPriorityComboBox.SelectionStart,
            //    Deadline = (GardenGroupModel.Enums.Deadline)ticketDeadlineFollowUpComboBox.SelectionStart,
            //    Description = ticketDescriptionTextBox.Text,
            //    Status = GardenGroupModel.Enums.Status.Open
            //};

            
            //ticketService.AddTicket(ticket);
        }

        private void cancelTicketButton_Click(object sender, EventArgs e)
        {
            //TODO reset all boxes to default and empty
        }

        private void CheckEmployee(Employee employee)
        {
            if (employee.IsServiceDeskEmployee)
            {
                ticketReportedUserLabel.Show();
                ticketReportedUserComboBox.Show();
            }
        }

        private void FillComboBox()
        {
            foreach (Employee employee in employees)
            {
                ticketReportedUserComboBox.Items.Add(employee.FirstName);
                ticketReportedUserComboBox.Tag = employee;
            }
        }
    }
}
