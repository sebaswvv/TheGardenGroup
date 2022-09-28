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
using GardenGroupModel;

namespace GradenGroupUI
{
    public partial class ServiceDeskEmployeeForm : Form
    {
        // hallo wereld
        public ServiceDeskEmployeeForm(Employee employee)
        {
            InitializeComponent();
            UserControls.TicketsOverviewUC userControl = new UserControls.TicketsOverviewUC();
            userControl.Dock = DockStyle.Fill;
            this.userControlPanel.Controls.Clear();
            this.userControlPanel.Controls.Add(userControl);
        }

        
    }
}
