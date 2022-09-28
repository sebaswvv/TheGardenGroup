using GardenGroupModel;
using GardenGroupModel.Enums;
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
    public partial class TicketsOverviewUC : UserControl
    {
        public TicketsOverviewUC()
        {
            InitializeComponent();
        }

        private void TicketsOverviewUC_Load(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(
                "16",
                DateTime.Now,
                "I Am Having A Major Skill Issue Please Help Me",
                IncidentType.Service,
                Priority.High,
                Deadline.SevenDays,
                "I Am Having A Major Skill Issue Please Help Me",
                Status.Open
            );
            ListViewItem value = new ListViewItem(new string[]{
                ticket.Id,
                ticket.Subject,
                ticket.EmployeeID,
                ticket.IncidentType.ToString(),
                ticket.Priority.ToString(),
                ticket.DateReported.ToString(),
                ticket.Status.ToString(),
            });
            ticketsList.Items.Clear();
            ticketsList.Items.Add(value);
        }

        private void ticketsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
