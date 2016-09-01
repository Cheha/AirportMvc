using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AirportTestMvc.Models.Entities;
using AirportTestMvc.Models.Interfaces;

namespace AirportTestMvc.Models.Repositories
{
    public class FlightRepository : IFlight
    {
        AirportContext _db;

        public FlightRepository()
        {
            _db = new AirportContext();
        }

        public List<Flight> GetFlights()
        {
            return _db.Flights.ToList<Flight>();
        }

        public void Add(Flight flight)
        {
            _db.Flights.Add(flight);
            _db.SaveChanges();
        }

        public void Update(Flight flight)
        {
            var _flight = _db.Flights.Find(flight.Id);
            if (_flight != null)
            {
                _db.Entry(_flight).CurrentValues.SetValues(flight);
                _db.SaveChanges();
            }
            else 
            {
                throw new Exception("Current entity cannot be updated, because it doesn't exist");
            }
        }

        public void Delete(int id)
        {
            var flight = GetFlightById(id);
            _db.Flights.Remove(flight);
            _db.SaveChanges();
        }


        public Flight GetFlightById(int id)
        {
            return _db.Flights.First(f => f.Id == id);
        }
    }
}