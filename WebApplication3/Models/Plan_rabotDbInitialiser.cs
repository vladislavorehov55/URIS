using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class Plan_rabotDbInitialiser: DropCreateDatabaseAlways<Plan_rabotContext>
    {
        protected override void Seed(Plan_rabotContext db)
        {
            
            db.Plans.Add(new Plan_rabot { Name="Составление ТЗ", Duration = 16,
                Begin = new DateTime(2019, 5, 15), End = new DateTime(2019,5,31), Resources="РП"});
            base.Seed(db);
        }
    }
}