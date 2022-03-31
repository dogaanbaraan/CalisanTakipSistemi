using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CalisanTakip.DataAccess.Contracts
{
    public interface IRepositoryBase<T> where T : class, new()
    {
        IQueryable GetAll(Expression<Func<T, bool>> filter = null , Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null);
        T Get(int id);
        T GetFirstOfDefault(Expression<Func<T,bool>> filter = null, string includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
