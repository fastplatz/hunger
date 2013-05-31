using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Db
{
    public class foodInitializer : DropCreateDatabaseIfModelChanges<foodDbContext>
    {
        protected override void Seed(foodDbContext context)
        {
            var foods = new List<Food>
            {
                new Food { UserId = 10, Name = "starvin", DatePosted = DateTime.Now, DateClosed = DateTime.Now.AddDays(2.0) },
                new Food { UserId = 11, Name = "marvin", DatePosted = DateTime.Now, DateClosed = DateTime.Now.AddDays(2.0) },
                new Food { UserId = 12, Name = "carvin", DatePosted = DateTime.Now, DateClosed = DateTime.Now.AddDays(2.0) },
                new Food { UserId = 13, Name = "parvin", DatePosted = DateTime.Now, DateClosed = DateTime.Now.AddDays(2.0) },
                new Food { UserId = 14, Name = "arvin", DatePosted = DateTime.Now, DateClosed = DateTime.Now.AddDays(2.0) },
            };
            foods.ForEach(f => context.Foods.Add(f));
            context.SaveChanges();
        }
    }
}
