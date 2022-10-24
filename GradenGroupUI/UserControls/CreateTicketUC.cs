using GardenGroupLogic;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GradenGroupUI.UserControls
{
    public partial class CreateTicketUC : UserControl
    {
        private List<Employee> employees;
        private Employee employee;
        private Form form;        
        private Ticket ticket;

        public CreateTicketUC(Employee employee)
        {
            InitializeComponent();
            EmployeeService employeeService = new EmployeeService();
            this.employees = employeeService.GetAllEmployees();
            this.employee = employee;

            CheckEmployee(employee);
            FillComboBox();
        }

        // Constructor for creating a ticket for a regular employee
        public CreateTicketUC(Employee employee, RegularEmployeeForm regularEmployeeForm) : this(employee)
        {            
            this.form = regularEmployeeForm;
        }

        // Constructor for creating a ticket for a servicedesk employee
        public CreateTicketUC(Employee employee, ServiceDeskEmployeeForm serviceDeskEmployeeForm) : this(employee)
        {
            this.form = serviceDeskEmployeeForm;
        }

        // Constructor for updating a ticket for a regular employee
        public CreateTicketUC(Employee employee, RegularEmployeeForm regularEmployeeForm, Ticket ticket) : this(employee)
        {
            this.form = regularEmployeeForm;
            this.ticket = ticket;

            ChangeToUpdate(ticket);
        }

        // Constructor for updating a ticket for a servicedesk employee
        public CreateTicketUC(Employee employee, ServiceDeskEmployeeForm serviceDeskForm, Ticket ticket) : this(employee)
        {
            this.form = serviceDeskForm;
            this.ticket = ticket;

            ChangeToUpdate(ticket);
        }

        // Submits a ticket if all boxes are filled or selected
        private void submitTicketButton_Click(object sender, EventArgs e)
        {
            if (!BoxesAreFilled())
            {
                createTicketWarningLabel.Show();
            }
            else
            {
                createTicketWarningLabel.Hide();

                // creates the ticket from the given values with the employeeID of the right user and sends it to the logic layer
                TicketService ticketService = new TicketService();
                ticketService.AddTicket(MakeTicketFromValues(RecieveEmployeeID()));

                ReturnToAllTicketsOverview();
            }
        }

        private void cancelTicketButton_Click(object sender, EventArgs e)
        {
            //Returns to the DeskViewTicket user control or DockViewticketsUC depending on the kind of employee
            ReturnToAllTicketsOverview();
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

        // Fills the reported by user combobox with the employees that are in the database
        private void FillComboBox()
        {            
            ticketReportedUserComboBox.DisplayMember = "FirstName" + "LastName";
            ticketReportedUserComboBox.DataSource = this.employees;            
        }

        // changes the UI elements that are used for creating a ticket to UI elements that are used for updating a ticket
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
            // The selected employee in the user combobox is by default the first (admin), so there is always an employee connected (an other employee can still be selected)
            ticketReportedDateTimePicker.Value = ticket.DateReported;
            ticketSubjectIncidentTextBox.Text = ticket.Subject;
            ticketTypeIncidentComboBox.Text = ticket.IncidentType.ToString();
            ticketPriorityComboBox.Text = ticket.Priority.ToString();
            ticketDeadlineFollowUpComboBox.Text = ticket.Deadline.ToString();
            ticketDescriptionTextBox.Text = ticket.Description.ToString();
        }

        // Sends the updated values to the ticketservice
        private void updateTicketButton_Click(object sender, EventArgs e)
        {
            if (!BoxesAreFilled())
            {
                createTicketWarningLabel.Show();
            }
            else
            {
                createTicketWarningLabel.Hide();

                TicketService ticketService = new TicketService();
                Ticket updatedTicket = MakeTicketFromValues(RecieveEmployeeID());
                updatedTicket.Id = this.ticket.Id;
                ticketService.UpdateTicket(updatedTicket);

                ReturnToAllTicketsOverview();
            }
        }

        // Makes a ticket from the values that where given by the user
        private Ticket MakeTicketFromValues(string employeeID)
        {
            Ticket ticket = new Ticket(employeeID, ticketReportedDateTimePicker.Value,
                ticketSubjectIncidentTextBox.Text,
                (GardenGroupModel.Enums.IncidentType)ticketTypeIncidentComboBox.SelectedIndex,
                (GardenGroupModel.Enums.Priority)ticketPriorityComboBox.SelectedIndex,
                (GardenGroupModel.Enums.Deadline)ticketDeadlineFollowUpComboBox.SelectedIndex,
                ticketDescriptionTextBox.Text, GardenGroupModel.Enums.Status.Open);

            return ticket;
        }


        // Recieves an employeeID based on the type of user that is logged in and returns it.
        private string RecieveEmployeeID()
        {
            string employeeID = this.employee.Id;
            int index = ticketReportedUserComboBox.SelectedIndex;

            if (this.employee.IsServiceDeskEmployee)
            {
                List<Employee> employees = (List<Employee>)ticketReportedUserComboBox.DataSource;
                Employee selectedEmployee = employees[index];
                employeeID = selectedEmployee.Id;
            }

            return employeeID;
        }

        //Returns to the DeskViewTicket user control or DockViewticketsUC depending on the kind of employee.
        private void ReturnToAllTicketsOverview()
        {
            if (this.employee.IsServiceDeskEmployee)
                ((ServiceDeskEmployeeForm)this.form).ShowDashBoard();
            else
                ((RegularEmployeeForm)this.form).DockViewTicketsUC();
        }

        // Checks if any boxes are left empty or unselected and returns false if they are.
        private bool BoxesAreFilled()
        {
            if (ticketSubjectIncidentTextBox.Text == "" || ticketTypeIncidentComboBox.SelectedIndex == -1 || ticketPriorityComboBox.SelectedIndex == -1 || ticketDeadlineFollowUpComboBox.SelectedIndex == -1 || ticketDescriptionTextBox.Text == "")
            {
                return false;
            }

            return true;
        }
    }
}
