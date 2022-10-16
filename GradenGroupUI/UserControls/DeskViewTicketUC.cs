using GardenGroupLogic;
using GardenGroupModel;
using GardenGroupModel.Enums;
using System;
using System.Windows.Forms;

namespace GradenGroupUI.UserControls
{
    public partial class DeskViewTicketUC : Form
    {
        private Ticket ticket;
        private TicketService ticketService;

        public DeskViewTicketUC(Ticket ticket, TicketService ticketService)
        {
            InitializeComponent();
            this.ticket = ticket;
            this.ticketService = ticketService;
        }

        private void DeskViewTicketUC_Load(object sender, EventArgs e)
        {
            FillTable(this.ticket);
        }
        
        private void FillTable(Ticket ticket)
        {
            reportedByValue.Text = ticket.Employee.ToString();
            reportedAtValue.Text = ticket.DateReported.ToString();
            priorityValue.Text = ticket.Priority.ToString();
            deadlineValue.Text = ticket.FormattedDeadline;
            incidentTypeValue.Text = ticket.IncidentType.ToString();
            statusValue.Text = ticket.Priority.ToString();
            subjectValue.Text = ticket.Subject;
            descriptionValue.Text = ticket.Description;
            reopenButton.Visible = ticket.Status != Status.Open;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // open edit ticket dialog
            //EditTicketUC editTicketUserControl = new EditTicketUC(ticket);
            //editTicketUserControl.ShowDialog();
            //FillTable(editTicketUserControl.ticket);
        }
        
        private void ChangeStatusButton(Status newStatus)
        {
            ticket.Status = newStatus;
            ticketService.ChangeTicketStatus(ticket);
            statusValue.Text = newStatus.ToString();
            reopenButton.Visible = ticket.Status != Status.Open;
        }

        private void resolveButton_Click(object sender, EventArgs e)
        {
            ChangeStatusButton(Status.Resolved);
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            ChangeStatusButton(Status.Closed);
        }

        private void reopenButton_Click(object sender, EventArgs e)
        {
            ChangeStatusButton(Status.Open);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult alert = MessageBox.Show("Are you sure you want to delete this ticket?", "Delete Ticket", MessageBoxButtons.YesNo);
            if (alert == DialogResult.Yes)
            {
                ticketService.DeleteTicket(ticket);
                this.Close();
            }
        }
    }
}
