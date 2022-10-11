using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GradenGroupUI.UserControls
{
    public partial class DeskViewTicketUC : Form
    {
        private Ticket ticket;

        public DeskViewTicketUC(Ticket ticket)
        {
            InitializeComponent();
            this.ticket = ticket;
        }
    }
}
