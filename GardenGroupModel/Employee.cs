using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace GardenGroupModel
{
    public abstract class Employee
    {        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Password Password { get; set; }
        public int PhoneNumber { get; set; }
        public Location Location { get; set; }

        public Employee(string firstName, string lastName, string email, int phoneNumber, Location location)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Location = location;
        }                
    }
}
