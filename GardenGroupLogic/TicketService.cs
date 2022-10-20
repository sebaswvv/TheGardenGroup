using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;
using GardenGroupDAL;
using MongoDB.Bson;

namespace GardenGroupLogic
{
    public class TicketService
    {
        private TicketDAO ticketDAO;

        public TicketService()
        {
            this.ticketDAO = new TicketDAO();
        }

        public void ChangeTicketStatus(Ticket ticket)
        {
            this.ticketDAO.ChangeTicketStatus(ticket);
        }

        public void AddTicket(Ticket ticket)
        {
            this.ticketDAO.AddTicket(ticket);
        }

        public List<Ticket> GetTicketsOfUser(string employeeID)
        {
            return this.ticketDAO.GetTicketsOfUser(employeeID);
        }

        public List<Ticket> GetAllTickets()
        {
            return this.ticketDAO.GetAllTickets();
        }

        public void UpdateTicket(Ticket ticket)
        {
            this.ticketDAO.UpdateTicketDateReported(ticket);
            this.ticketDAO.UpdateTicketSubject(ticket);
            this.ticketDAO.UpdateTicketDeadline(ticket);
            this.ticketDAO.UpdateTicketDescription(ticket);
            this.ticketDAO.UpdateTicketEmployee(ticket);
            this.ticketDAO.UpdateTicketIncidentType(ticket);
            this.ticketDAO.UpdateTicketPriority(ticket);
        }

        public void DeleteTicket(Ticket ticket)
        {
            this.ticketDAO.DeleteTicket(ticket);
        }
    }
}
