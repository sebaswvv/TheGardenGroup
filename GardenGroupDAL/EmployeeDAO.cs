﻿using System.Collections.Generic;
using System.Linq;
using GardenGroupModel;
using MongoDB.Driver;

namespace GardenGroupDAL
{
    public class EmployeeDAO : BaseDAO
    {
        private IMongoCollection<Employee> collection;

        public EmployeeDAO()
        {
            this.collection = this.db.GetCollection<Employee>("employees");
        }

        public void AddUser(Employee newUser) 
        {
            this.collection.InsertOne(newUser);
        }        

        public Employee GetUser(string email)
        {
            return this.collection.Find(u => u.Email == email).FirstOrDefault();
        }

        public void UpdateUser(Employee employee)
        {
            this.collection.ReplaceOne(u => u.Email == employee.Email, employee);
        }
        public List<Employee> GetAllEmployees()
        {
            return this.collection.Find(u => true).ToList();
        }
    }
}
