using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Db
{
    public class foodDbContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }

        //// stackoverflow 12165185. do this or rename to "DefaultConnection" in the connstring in web.config
        //public foodDbContext()
        //    : base("foodDbContext")
        //{
        //}
    }
}
