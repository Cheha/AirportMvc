using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AirportTestMvc.Models.Entities;
using AirportTestMvc.Models.Repositories;

namespace AirportTestMvc.Models
{
    public class AirportContext : DbContext
    {
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
    }
}