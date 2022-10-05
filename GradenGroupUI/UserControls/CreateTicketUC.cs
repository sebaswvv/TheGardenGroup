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
        private Employee employee;
        private RegularEmployeeForm regularEmployeeForm;

        public CreateTicketUC(Employee employee, RegularEmployeeForm regularEmployeeForm)
        {            
            InitializeComponent();
            EmployeeService employeeService = new EmployeeService();
            this.employees = employeeService.GetAllEmployees();
            this.employee = employee;
            this.regularEmployeeForm = regularEmployeeForm;

            CheckEmployee(employee);
            
            FillComboBox();
            // TODO hide option to select an employee
        }

        // Submits a ticket
        private void submitTicketButton_Click(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();
            
            string employeeID = this.employee.Id;
            int index = ticketReportedUserComboBox.SelectedIndex;

            if (this.employee.IsServiceDeskEmployee)
            {
                List<Employee> employees = (List<Employee>)ticketReportedUserComboBox.DataSource;
                Employee selectedEmployee = employees[index];
                employeeID = selectedEmployee.Id;
            }
           
            Ticket ticket = new Ticket(employeeID, TicketReportedDateTimePicker.Value, 
                ticketSubjectIncidentTextBox.Text, 
                (GardenGroupModel.Enums.IncidentType)ticketTypeIncidentComboBox.SelectionStart, 
                (GardenGroupModel.Enums.Priority)ticketPriorityComboBox.SelectionStart, 
                (GardenGroupModel.Enums.Deadline)ticketDeadlineFollowUpComboBox.SelectionStart, 
                ticketDescriptionTextBox.Text, GardenGroupModel.Enums.Status.Open);           

            ticketService.AddTicket(ticket);

            //Could add some feedback to the user to let them know that the ticket is made

            //Returns to the DeskViewTicket user control
            this.regularEmployeeForm.DockViewTicketsUC();

        }

        private void cancelTicketButton_Click(object sender, EventArgs e)
        {
            //Returns to the DeskViewTicket user control
            this.regularEmployeeForm.DockViewTicketsUC();
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
            ticketReportedUserComboBox.DisplayMember = "FirstName";
            ticketReportedUserComboBox.DataSource = employees;
        }
    }
}
