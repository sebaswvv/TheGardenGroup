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

        private void DisplayTicketsOfUser(List<Ticket> tickets)
        {
            
        }

        private List<Ticket> GetAllTicketsOfUser()
        {
            return this.ticketService.GetTicketsOfUser(this.employee.Id);
        }
    }
}
