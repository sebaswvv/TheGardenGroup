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
        private TicketService ticketService;
        private List<Ticket> ticketsOfUser;

        public ViewTicketsUC(Employee employee)
        {
            InitializeComponent();            
            this.ticketService = new TicketService();
            this.ticketsOfUser = GetAllTicketsOfUser(employee);
            this.allTicketsListView.Visible = false;
            this.pieChartPanel.Visible = false;
        }

        private void showTicketsButton_Click(object sender, EventArgs e)
        {            
            DisplayTicketsOfUser(this.ticketsOfUser);
        }

        private void showDashboardTicketsButton_Click(object sender, EventArgs e)
        {
            this.allTicketsListView.Visible = false;
            this.pieChartPanel.Visible = true;
            
            double[] percentageTicketStatus = GetPercentageTicketStatus();

            // Create a new chart.
            Chart chart = new Chart();               
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "Default";
            chart.ChartAreas.Add(chartArea);           
            
            // make the chart
            chart.Series.Add("Tickets");
            chart.Series["Tickets"].ChartType = SeriesChartType.Pie;            
            chart.BackColor = Color.FromArgb(211, 223, 240);

            // load some sample data
            chart.Series["Tickets"].Points.AddXY("Open", percentageTicketStatus[0]);
            chart.Series["Tickets"].Points.AddXY("Closed", percentageTicketStatus[1]);
            chart.Series["Tickets"].Points.AddXY("Resolved", percentageTicketStatus[2]);   

            // add the chart to the form
            this.pieChartPanel.Controls.Add(chart);
        }

        private double[] GetPercentageTicketStatus()
        {
            int[] ticketSatus = new int[3];
            // View a dashboard with current status of tickets (% open, % resolved, % closed without resolve)
            foreach (Ticket ticket in this.ticketsOfUser)
            {
                switch (ticket.Status)
                {
                    case GardenGroupModel.Enums.Status.Open:
                        ticketSatus[0]++;
                        break;
                    case GardenGroupModel.Enums.Status.Resolved:
                        ticketSatus[1]++;
                        break;
                    case GardenGroupModel.Enums.Status.Closed:
                        ticketSatus[2]++;
                        break;
                }
            }
            double[] percentageTicketStatus = new double[3];
            for (int i = 0; i < ticketSatus.Length; i++)
                percentageTicketStatus[i] = (double)ticketSatus[i] / ticketsOfUser.Count * 100;
            return percentageTicketStatus;
        }

        private void DisplayTicketsOfUser(List<Ticket> tickets)
        {
            this.allTicketsListView.Visible = true;
            this.pieChartPanel.Visible = false;
            this.allTicketsListView.Items.Clear();            
            
            foreach (Ticket ticket in tickets)
            {
                string deadline = "";                

                // make deadline a string
                switch (ticket.Deadline)
                {
                    case GardenGroupModel.Enums.Deadline.SevenDays:
                        deadline = "7 days";
                        break;
                    case GardenGroupModel.Enums.Deadline.FourtheenDays:
                        deadline = "14 days";
                        break;
                    case GardenGroupModel.Enums.Deadline.TwentyEightDays:
                        deadline = "28 days";
                        break;
                    case GardenGroupModel.Enums.Deadline.SixMonths:
                        deadline = "6 months";
                        break;
                }
                
                ListViewItem item = new ListViewItem(new string[] { ticket.Id,
                    ticket.DateReported.ToString(), ticket.Subject, ticket.Description,
                    ticket.Priority.ToString(), deadline,
                    ticket.Status.ToString() });
                this.allTicketsListView.Items.Add(item);
            }
        }

        private List<Ticket> GetAllTicketsOfUser(Employee employee)
        {
            return this.ticketService.GetTicketsOfUser(employee.Id);
        }        
    }
}
