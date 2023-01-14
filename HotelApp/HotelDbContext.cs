using HotelApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelApp
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext() : base("HotelConntectionString")
        {

        }
        public DbSet<hotel> hotel { get; set; }

    }
}