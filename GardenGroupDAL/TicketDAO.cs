using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GardenGroupDAL
{
    public class TicketDAO : BaseDAO
    {
        private IMongoCollection<Ticket> collection;

        public TicketDAO()
        {
            this.collection = this.db.GetCollection<Ticket>("tickets");
        }

        public void AddTicket(Ticket ticket)
        {
            this.collection.InsertOne(ticket);
        }

        // get all tickets of a user
        public List<Ticket> GetTicketsOfUser(string employeeID)
        {
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("EmployeeID", employeeID);
            return this.collection.Find(filter).ToList();
        }

        public List<Ticket> GetAllTickets()
        {
            var test = this.collection.Aggregate()
                .Lookup("employees", new BsonDocument {
                    { "employeeObjID", new BsonDocument {
                        { "$toObjectId", "$EmployeeID" }
                    }}
                }, new EmptyPipelineDefinition().AppendStage($"{{$match: {{\r\n    $expr: {{\r\n      $eq: [\r\n        \"$_id\", \"$$employeeObjId\"\r\n      ]\r\n    }}}"),
                "EmployeeID", "Employee")
                .As<BsonDocument>()
                .ToList();
            return;
        }
    }
}
