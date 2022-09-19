using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace GardenGroupModel
{
    public class Employee
    {        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
