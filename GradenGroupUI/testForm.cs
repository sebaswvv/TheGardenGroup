using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using GardenGroupModel;
using GardenGroupLogic;

namespace GradenGroupUI
{
    public partial class testForm : Form
    {
        private UserLogic userLogic;
        
        public testForm()
        {            
            InitializeComponent();
            this.userLogic = new UserLogic();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            this.userLogic.AddUser(new User(firstName, lastName));
            User userAdded = this.userLogic.GetUser(firstName);
            newUser.Text = userAdded.FirstName + " " + userAdded.LastName;
        }
    }
}
