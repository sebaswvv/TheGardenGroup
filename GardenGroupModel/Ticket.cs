using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GardenGroupModel
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime DateReported { get; set; }
        public string Subject { get; set; }
        public Priority Priority { get; set; }
        public Deadline Deadline { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
