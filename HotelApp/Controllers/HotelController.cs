using HotelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelApp.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {
            var hotelList = new List<hotel>();
            hotelList.Add(new hotel { Id = 1,Name="A2B" });
            hotelList.Add(new hotel { Id = 1, Name = "Sachin" });
            hotelList.Add(new hotel { Id = 1, Name = "Arun" });
            return View(hotelList);
        }
    }
}