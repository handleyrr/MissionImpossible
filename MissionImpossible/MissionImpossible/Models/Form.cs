using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MissionImpossible.Models
{
    public class Form
    {
        public int Id { get; set;}
        public string Form_name { get; set; }
        public string Description { get; set; }
        public Type Type { get; set; }
    }

    public enum Type
    {
        Event = 1, 
        Volunteer, 
        Job
    }
}