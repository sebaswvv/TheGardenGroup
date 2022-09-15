using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;
using MongoDB.Driver;

namespace GardenGroupDAL
{
    // JUST A REFERENCE!!! DONT USE
    public class UserDAO : BaseDAO
    {
        private IMongoCollection<User> collection;

        public UserDAO()
        {
            this.collection = this.db.GetCollection<User>("Users");
        }

        public void AddUser(User newUser) 
        {
            this.collection.InsertOne(newUser);
        }

        public User GetUser(string username)
        {
            return this.collection.Find(u => u.FirstName == username).FirstOrDefault();
        }
    }
}
