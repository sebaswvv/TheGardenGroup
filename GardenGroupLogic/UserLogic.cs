using System;
using GardenGroupDAL;
using GardenGroupModel;

namespace GardenGroupLogic
{
    public class UserLogic
    {
        // JUST A REFERENCE!!! DONT USE
        private UserDAO userDAO;

        public UserLogic()
        {
            this.userDAO = new UserDAO();
        }
        
        public User GetUser(string username)
        {
            return this.userDAO.GetUser(username);
        }

        public void AddUser(User user)
        {
            this.userDAO.AddUser(user);
        }
    }
}
