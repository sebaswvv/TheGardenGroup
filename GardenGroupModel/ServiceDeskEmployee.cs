﻿using GardenGroupModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupModel
{
    public class ServiceDeskEmployee : Employee
    {
        public ServiceDeskEmployee(string firstName, string lastName, string email, int phoneNumber, Location location) : base(firstName, lastName, email, phoneNumber, location)
        {
        }
    }
}