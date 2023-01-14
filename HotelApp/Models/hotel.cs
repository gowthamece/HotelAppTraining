using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelApp.Models
{
    public class hotel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
    }
}