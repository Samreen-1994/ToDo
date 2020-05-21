using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
        List<T> GetItems(Expression<Func<T, bool>> predicate, params string[] navigationProperties);
    }
}
