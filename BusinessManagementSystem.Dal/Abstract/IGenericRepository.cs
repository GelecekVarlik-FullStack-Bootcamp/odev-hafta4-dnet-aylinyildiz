using BusinessManagementSystem.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Dal.Abstract
{
    public interface IGenericRepository<T> where  T:IEntityBase
    {
        //list
        List<T> GetAll();

        //filtreli list
        List<T> GetAll(Expression<Func<T, bool>> expression);

        //get
        T Find(int id);

        T Add(T item);
        Task<T> AddAsync(T item);

        T Update(T item);

        bool Delete(int id);
        bool Delete(T item);

        //queryable
        IQueryable<T> GetQuearyable();
    }
}
