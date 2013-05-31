using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Db;

namespace DataAccessLayer.Repositories
{
    public class FoodRepository : baseRepository, IRepository<Food>
    {
        public static readonly DataAccessLayer.Repositories.FoodRepository Instance = new DataAccessLayer.Repositories.FoodRepository();

        #region Implementation of IRepository<Food>
        public Food[] GetAll()
        {
            return _db.Foods.ToArray();
        }

        public Food[] GetAllByDateRange(DateTime start, DateTime end)
        {
            return _db.Foods.Where(i => (i.DatePosted >= start) && (i.DatePosted <= end)).ToArray();
        }

        public Food GetByID(int id)
        {
            return _db.Foods.FirstOrDefault(i => i.ID == id);
        }

        public Food[] GetAllByUserId(int userId)
        {
            return _db.Foods.Where(i => i.UserId == userId).ToArray();
        }

        public Food GetByName(string name)
        {
            return _db.Foods.FirstOrDefault(i => i.Name == name);
        }

        public void AddItem(Food item)
        {
            _db.Foods.Add(item);
            _db.SaveChanges();
        }

        public void DeleteItem(Food item)
        {
            _db.Foods.Remove(item);
            _db.SaveChanges();
        }

        public void UpdateItem(Food item)
        {
            var currentFood = _db.Foods.Find(item.ID);
            _db.Entry(currentFood).CurrentValues.SetValues(item);

            _db.SaveChanges();
        }

        #endregion
    }
}
