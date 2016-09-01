using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AirportTestMvc.Models;
using AirportTestMvc.Models.Entities;
using AirportTestMvc.Models.Interfaces;

namespace AirportTestMvc.Models.Repositories
{
    public class TerminalRepository : ITerminal
    {
        DbContext _db;

        public TerminalRepository() {
            _db = new AirportContext();
        }
    }
}