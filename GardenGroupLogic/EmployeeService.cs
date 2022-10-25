using System;
using System.Collections.Generic;
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
        
        public Employee GetEmployee(string email)
        {
            return this.userDAO.GetUser(email);
        }
        

        public void AddEmployee(Employee user)
        {
            this.userDAO.AddUser(user);
        }

        public List<Employee> GetAllEmployees()
        {
            return this.userDAO.GetAllEmployees();
        }
        
        public void UpdateEmployee(Employee user)
        {
            this.userDAO.UpdateUser(user);
        }
    }
}
