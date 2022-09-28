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
            BsonArray match = new BsonArray();
            match.Add(
                new BsonDocument("$match",
                    new BsonDocument("$expr", new BsonDocument(
                        "$eq", new BsonArray {"$_id", "$$employeeObjId" }
                    )
                ))
            );
            BsonDocument lookup = new BsonDocument("$lookup",
                new BsonDocument()
                    .Add("let", new BsonDocument("employeeObjId", new BsonDocument("$toObjectId", "$EmployeeID")))
                    .Add("from", "employees")
                    .Add("pipeline", match)
                    .Add("as", "Employee")
            );
            BsonDocument unwind = new BsonDocument("$unwind",
                new BsonDocument()
                    .Add("path", "$Employee")
                    .Add("preserveNullAndEmptyArrays", true)
            );

            return this.collection.Aggregate()
                .AppendStage<BsonDocument>(lookup)
                .AppendStage<BsonDocument>(unwind)
                .As<Ticket>()
                .ToList();
        }
    }
}
