using GardenGroupLogic;
using GardenGroupModel;
using GardenGroupModel.Enums;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradenGroupUI.UserControls
{
    public partial class TicketsOverviewUC : UserControl
    {
        private TicketService ticketService;

        public TicketsOverviewUC()
        {
            InitializeComponent();
            ticketService = new TicketService();
        }

        private void TicketsOverviewUC_Load(object sender, EventArgs e)
        {
            LoadTicketsList();
        }

        private void LoadTicketsList()
        {
            // TODO: switch to datagridview for sort and buttons
            List<Ticket> tickets = ticketService.GetAllTickets();
            ticketsList.AutoGenerateColumns = false;
            ticketsList.DataSource = tickets;
            //foreach (var ticket in tickets)
            //{
            //    ListViewItem value = new ListViewItem(new string[]{
            //        ticket.Id,
            //        ticket.Subject,
            //        ticket.Employee.ToString(),
            //        ticket.IncidentType.ToString(),
            //        ticket.Priority.ToString(),
            //        ticket.DateReported.ToString(),
            //        ticket.Status.ToString(),
            //    });
            //    ticketsList.Items.Add(value);
            //}
        }

        private void ticketsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
