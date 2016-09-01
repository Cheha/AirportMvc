using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AirportTestMvc.Models.Entities;
using AirportTestMvc.Models.Interfaces;

namespace AirportTestMvc.Models.Repositories
{
    public class PassengerRepository : IPassenger
    {
        DbContext _db;

        public PassengerRepository()
        {
            _db = new AirportContext();
        }

        
    }
}