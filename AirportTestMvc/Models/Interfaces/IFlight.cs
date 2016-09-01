using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AirportTestMvc.Models.Entities;

namespace AirportTestMvc.Models.Interfaces
{
    public interface IFlight
    {
        List<Flight> GetFlights();
        Flight GetFlightById(int id);
        void Add(Flight flight);
        void Update(Flight flight);
        void Delete(int id);
    }
}