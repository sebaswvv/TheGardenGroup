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
            List<Ticket> tickets = ticketService.GetAllTickets();
            // sort by status (open tickets first), then by date (newest first)
            tickets.Sort((a, b) => {
                int statusComparer = a.Status.CompareTo(b.Status);
                if (statusComparer != 0) return statusComparer;
                return b.DateReported.CompareTo(a.DateReported);
            });
            
            ticketsList.AutoGenerateColumns = false;
            // a sortable binding list is needed in order for column headers to be sortable by the user
            ticketsList.DataSource = new SortableBindingList<Ticket>(tickets);
        }

        private void ticketsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ticketsList.Columns[e.ColumnIndex] is not DataGridViewButtonColumn || e.RowIndex == -1)
                return;

            Ticket ticket = (Ticket) ticketsList.Rows[e.RowIndex].DataBoundItem;
            MessageBox.Show(ticket.Subject);

            DeskViewTicketUC viewTicketUserControl = new DeskViewTicketUC(ticket);
            viewTicketUserControl.ShowDialog();
        }
    }
}
