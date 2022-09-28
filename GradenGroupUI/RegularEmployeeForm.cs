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

namespace GradenGroupUI
{
    public partial class RegularEmployeeForm : Form
    {
        private Employee employee;
        public RegularEmployeeForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            DockViewTicketsUC();
        }

        private void DockViewTicketsUC()
        {            
            UserControls.ViewTicketsUC viewTicketsUC = new UserControls.ViewTicketsUC(this.employee, this);
            viewTicketsUC.Dock = DockStyle.Fill;
            this.viewTicketsPanel.Controls.Clear();
            this.viewTicketsPanel.Controls.Add(viewTicketsUC);
        }
        
        public void DockAddTicketsUC()
        {
            this.viewTicketsPanel.Controls.Clear();        
       
            // make and dock
            UserControls.CreateTicketUC createTicketUC = new UserControls.CreateTicketUC(this.employee);
            createTicketUC.Dock = DockStyle.Fill;
            this.viewTicketsPanel.Controls.Add(createTicketUC);
        }

        private void RegularEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
