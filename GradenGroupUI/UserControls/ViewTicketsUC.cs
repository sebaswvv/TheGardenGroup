using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;
using ChartDirector;

namespace GradenGroupUI.UserControls
{
    public partial class ViewTicketsUC : UserControl
    {
        private Employee employee;
        private TicketService ticketService;

        public ViewTicketsUC(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            ticketService = new TicketService();
        }

        private void showTicketsButton_Click(object sender, EventArgs e)
        {
            List<Ticket> ticketsOfUser = GetAllTicketsOfUser();
            DisplayTicketsOfUser(ticketsOfUser);
        }

        private void showDashboardTicketsButton_Click(object sender, EventArgs e)
        {
            List<Ticket> ticketsOfUser = GetAllTicketsOfUser();            

            // View a dashboard with current status of tickets (% open, % resolved, % closed without resolve)
            //foreach (Ticket ticket in ticketsOfUser)
            //{
            //    switch (ticket.Status)
            //    {
            //        case GardenGroupModel.Enums.Status.Open:
            //            // Add to open tickets
            //            break;
            //        case GardenGroupModel.Enums.Status.Resolved:
            //            // Add to resolved tickets
            //            break;
            //        case GardenGroupModel.Enums.Status.Closed:
            //            // Add to closed without resolve tickets
            //            break;
            //    }
            //}
        }

        private void DisplayTicketsOfUser(List<Ticket> tickets)
        {
            
        }

        private List<Ticket> GetAllTicketsOfUser()
        {
            return this.ticketService.GetTicketsOfUser(this.employee.Id);
        }        
    }
}
