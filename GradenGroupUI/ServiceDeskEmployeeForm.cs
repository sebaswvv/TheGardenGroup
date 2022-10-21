using GardenGroupModel;
using GradenGroupUI.UserControls;
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
        Employee employee;
        public ServiceDeskEmployeeForm(Employee employee)
        {
            InitializeComponent();
            StyleUI();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.employee = employee;

            ShowDashBoard();
        }

        public void ShowDashBoard()
        {
            TicketsOverviewUC userControl = new TicketsOverviewUC();
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
            this.createEmployeeButton.BackColor = Color.FromArgb(27, 81, 43);
            this.logoutButton.BackColor = Color.White;
        }

        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            this.userControlPanel.Controls.Clear();
            CreateTicketUC createTicketUserControl = new CreateTicketUC(this.employee, this);
            this.userControlPanel.Controls.Add(createTicketUserControl);
        }

        private void showDashboardButton_Click(object sender, EventArgs e)
        {
            this.userControlPanel.Controls.Clear();
            TicketsOverviewUC showDashBoarduserControl = new TicketsOverviewUC();
            this.userControlPanel.Controls.Add(showDashBoarduserControl);
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            this.userControlPanel.Controls.Clear();
            CreateNewEmployeeUC createNewEmployeeUserControl = new CreateNewEmployeeUC();
            this.userControlPanel.Controls.Add(createNewEmployeeUserControl);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
            loginForm.Closed += (s, args) => this.Close();
        }
    }
}
