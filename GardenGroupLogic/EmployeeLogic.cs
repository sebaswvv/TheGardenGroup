using System;
using GardenGroupDAL;
using GardenGroupModel;

namespace GardenGroupLogic
{
    public class EmployeeLogic
    {        
        private EmployeeDAO userDAO;

        public EmployeeLogic()
        {
            this.userDAO = new EmployeeDAO();
        }
        
        public Employee GetUser(string username)
        {
            return this.userDAO.GetUser(username);
        }

        public void AddUser(Employee user)
        {
            this.userDAO.AddUser(user);
        }
    }
}
