using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Db;

namespace DataAccessLayer.Repositories
{
    public class baseRepository
    {
        protected static foodDbContext _db = new foodDbContext();

    }
}
