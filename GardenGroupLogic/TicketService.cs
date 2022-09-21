using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;
using GardenGroupDAL;

namespace GardenGroupLogic
{
    public class TicketService
    {
        private TicketDAO ticketDAO;

        public TicketService()
        {
            this.ticketDAO = new TicketDAO();
        }

        public void AddTicket(Ticket ticket)
        {
            this.ticketDAO.AddTicket(ticket);
        }

        public List<Ticket> GetTicketsOfUser(string employeeID)
        {
            return this.ticketDAO.GetTicketsOfUser(employeeID);
        }
    }
}
