using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Employee GetUser(string username)
        {
            return this.collection.Find(u => u.FirstName == username).FirstOrDefault();
        }
    }
}
