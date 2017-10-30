using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MissionImpossible.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public long Phone { get; set; }
    }
}