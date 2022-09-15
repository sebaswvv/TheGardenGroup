using System;
using System.Configuration;
using MongoDB.Driver;

namespace GardenGroupDAL
{    
    public abstract class BaseDAO
    {
        private MongoClient mongoClient;
        protected IMongoDatabase db;

        public BaseDAO()
        {
            this.mongoClient = new MongoClient(ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString);
            this.db = this.mongoClient.GetDatabase("Main");
        }
    }
}
