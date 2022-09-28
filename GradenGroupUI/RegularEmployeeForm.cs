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
        public RegularEmployeeForm()
        {
            InitializeComponent();
            DockViewTicketsUC();
        }

        private void DockViewTicketsUC()
        {
            // add view tickets to panel
            // Hard coding an employee for now           
            Employee employee = new Employee("Sebastiaan", "van Vliet", "6905921@student.inholland.nl", "0612345678", new Password(), GardenGroupModel.Enums.Location.HaarlemHQ, true);
            employee.Id = "6329c701ac31b8d8e3984b66";
            UserControls.ViewTicketsUC viewTicketsUC = new UserControls.ViewTicketsUC(employee, this);
            viewTicketsUC.Dock = DockStyle.Fill;
            this.viewTicketsPanel.Controls.Clear();
            this.viewTicketsPanel.Controls.Add(viewTicketsUC);
        }
        
        public void DockAddTicketsUC()
        {
            // create UC and dock the UC
        }
    }
}
