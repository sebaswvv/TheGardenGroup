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
    public partial class S : UserControl
    {
        private List<Employee> employees;
        private Employee employee;
        private RegularEmployeeForm regularEmployeeForm;

        // Constructor for creating a ticket
        public S(Employee employee, RegularEmployeeForm regularEmployeeForm)
        {            
            InitializeComponent();
            EmployeeService employeeService = new EmployeeService();
            this.employees = employeeService.GetAllEmployees();
            this.employee = employee;
            this.regularEmployeeForm = regularEmployeeForm;

            CheckEmployee(employee);
            
            FillComboBox();
        }

        // Constructor for updating a ticket
        public S(Employee employee, RegularEmployeeForm regularEmployeeForm, Ticket ticket)
        {
            InitializeComponent();
            EmployeeService employeeService = new EmployeeService();
            this.employees = employeeService.GetAllEmployees();
            this.employee = employee;
            this.regularEmployeeForm = regularEmployeeForm;

            CheckEmployee(employee);

            FillComboBox();
            ChangeToUpdate(ticket);
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
           
            Ticket ticket = new Ticket(employeeID, ticketReportedDateTimePicker.Value, 
                ticketSubjectIncidentTextBox.Text, 
                (GardenGroupModel.Enums.IncidentType)ticketTypeIncidentComboBox.SelectedIndex, 
                (GardenGroupModel.Enums.Priority)ticketPriorityComboBox.SelectedIndex, 
                (GardenGroupModel.Enums.Deadline)ticketDeadlineFollowUpComboBox.SelectedIndex, 
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

        // Hides the option to select an employee
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

        private void ChangeToUpdate(Ticket ticket)
        {
            createTicketHeaderLabel.Hide();
            updateTicketLabel.Show();
            submitTicketButton.Hide();
            updateTicketButton.Show();
            
            FillBoxesWithSelectedTicket(ticket);
        }

        // FIlls all the boxes with the data from the current ticket
        private void FillBoxesWithSelectedTicket(Ticket ticket)
        {
            ticketReportedDateTimePicker.Value = ticket.DateReported;
            ticketSubjectIncidentTextBox.Text = ticket.Subject;
            ticketTypeIncidentComboBox.Text = ticket.IncidentType.ToString();
            ticketPriorityComboBox.Text = ticket.Priority.ToString();
            ticketDeadlineFollowUpComboBox.Text = ticket.Deadline.ToString();
            ticketDescriptionTextBox.Text = ticket.Description.ToString();
        }

        // TODO add the updated values to the ticket
        private void updateTicketButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
