using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace GardenGroupModel
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string EmployeeID { get; set; }
        [BsonIgnoreIfNull]
        public Employee Employee { get; set; }
        public DateTime DateReported { get; set; }
        public string Subject { get; set; }
        public IncidentType IncidentType { get; set; }
        public Priority Priority { get; set; }
        public Deadline Deadline { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        
        public Ticket(string employeeID, DateTime dateReported, string subject, IncidentType incidentType, Priority priority, Deadline deadline, string description, Status status)
        {
            EmployeeID = employeeID;
            DateReported = dateReported;
            Subject = subject;
            IncidentType = incidentType;
            Priority = priority;
            Deadline = deadline;
            Description = description;
            Status = status;
        }

        public string FormattedDeadline
        {
            get => this.Deadline switch
            {
                Deadline.SevenDays => "7 days",
                Deadline.FourtheenDays => "14 days",
                Deadline.TwentyEightDays => "28 days",
                Deadline.SixMonths => "6 months",
                _ => this.Deadline.ToString(),
            };
        }
    }
}
