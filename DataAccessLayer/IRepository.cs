using System;

namespace DataAccessLayer
{
    public interface IRepository<T>
    {
        T[] GetAll();
        T[] GetAllByDateRange(DateTime start, DateTime end);
        T GetByID(int id);
        T[] GetAllByUserId(int userId);
        T GetByName(string name);
        void AddItem(T item);
        void DeleteItem(T item);
        void UpdateItem(T item);
    }
}
