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

namespace GradenGroupUI
{
    public partial class Form1 : Form
    {
        MongoClient mongoClient;
        IMongoDatabase db;
        IMongoCollection<User> collection;
        public Form1()
        {
            InitializeComponent();
            //this.firstName.Text = "test";             
            this.mongoClient = new MongoClient(System.Configuration.ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString);
            this.db = this.mongoClient.GetDatabase("Main");
            this.collection = this.db.GetCollection<User>("Users");
            
            // create a User
            User user = new User
            {
                FirstName = "John",
                LastName = "Doe"
            };
            InsertUser(user);
            this.firstName.Text = FindTheUser().FirstName;
        }

        private User FindTheUser()
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("FirstName", "John");
            User user = this.collection.Find(filter).FirstOrDefault();
            return user;
        }

        private void InsertUser(User user)
        {
            this.collection.InsertOne(user);
        }
    }
}
