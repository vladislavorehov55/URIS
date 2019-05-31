using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication3.Models
{
    public class Plan_rabotContext:DbContext
    {
        public DbSet<Plan_rabot> Plans { get; set; }
    }
}