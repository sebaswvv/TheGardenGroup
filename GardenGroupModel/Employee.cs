using GardenGroupModel.Enums;
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
        public string Email { get; set; }
        public Password Password { get; set; }
        public string PhoneNumber { get; set; }
        public Location Location { get; set; }
        public bool IsServiceDeskEmployee{ get; set; }

        public Employee(string firstName, string lastName, string email, string phoneNumber, Password password, Location location, bool isServiceDeskEmployee)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Location = location;
            Password = password;
            IsServiceDeskEmployee = isServiceDeskEmployee;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
