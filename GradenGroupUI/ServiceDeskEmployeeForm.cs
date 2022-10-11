using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradenGroupUI
{
    public partial class ServiceDeskEmployeeForm : Form
    {
        // hallo wereld
        public ServiceDeskEmployeeForm(Employee employee)
        {
            InitializeComponent();
            StyleUI();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            //UserControls.TicketsOverviewUC userControl = new UserControls.TicketsOverviewUC();

            UserControls.CreateNewEmployeeUC userControl = new UserControls.CreateNewEmployeeUC(employee);
            //UserControls.CreateTicketUC userControl = new UserControls.CreateTicketUC(employee);
            userControl.Dock = DockStyle.Fill;
            this.userControlPanel.Controls.Clear();
            this.userControlPanel.Controls.Add(userControl);
        }

        private void StyleUI()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.menuPanel.BackColor = Color.FromArgb(156, 179, 128);
            this.buttonCreateTicket.BackColor = Color.FromArgb(27, 81, 43);
            this.showDashboardButton.BackColor = Color.FromArgb(27, 81, 43);
        }
    }
}
