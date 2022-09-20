using System;
using GardenGroupDAL;
using GardenGroupModel;

namespace GardenGroupLogic
{
    public class EmployeeService
    {        
        private EmployeeDAO userDAO;

        public EmployeeService()
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
