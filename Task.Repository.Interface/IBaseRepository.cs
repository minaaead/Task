using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task.Repository.Interface
{
    public interface IBaseRepository<T>
    {
        bool ADD(T Entity);
        bool Delete(int Id);
        List<T> GetAll();
        bool Update(T Entity);
        T GetById(int id);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);

    }
}
