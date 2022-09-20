using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GardenGroupModel
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string EmployeeID { get; set; }
        public DateTime DateReported { get; set; }
        public string Subject { get; set; }
        public Priority Priority { get; set; }
        public Deadline Deadline { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }

        public Ticket(string employeeID, DateTime dateReported, string subject, Priority priority, Deadline deadline, string description, Status status)
        {
            EmployeeID = employeeID;
            DateReported = dateReported;
            Subject = subject;
            Priority = priority;
            Deadline = deadline;
            Description = description;
            Status = status;
        }
    }
}
