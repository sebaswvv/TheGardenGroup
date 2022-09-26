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
using System.Windows.Forms.DataVisualization.Charting;

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
            
            // Create a new chart.
            Chart chart = new Chart();           

            // Add a chart area.
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "Default";
            chart.ChartAreas.Add(chartArea);           
            
            // make the chart
            chart.Series.Add("Tickets");
            chart.Series["Tickets"].ChartType = SeriesChartType.Pie;            
            chart.BackColor = Color.FromArgb(211, 223, 240);

            // load some sample data
            chart.Series["Tickets"].Points.AddXY("Open", 10);
            chart.Series["Tickets"].Points.AddXY("Closed", 20);
            chart.Series["Tickets"].Points.AddXY("In Progress", 30);   

            // add the chart to the form
            this.pieChartPanel.Controls.Add(chart);
            

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
