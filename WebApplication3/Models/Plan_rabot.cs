using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Plan_rabot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public string Resources { get; set; }
    }
}