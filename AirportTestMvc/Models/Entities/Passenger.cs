﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirportTestMvc.Models.Entities
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string Gender { get; set; }
    }
}