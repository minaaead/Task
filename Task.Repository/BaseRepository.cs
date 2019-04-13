using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task.Dal;
using Task.Repository.Interface;

namespace Task.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly Context MyContext;
        public BaseRepository(Context MyContext)
        {
            this.MyContext = MyContext;
        }
        public bool ADD(T Entity)
        {
            try
            {
                MyContext.Set<T>().Add(Entity);
                MyContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int Id)
        {
            try
            {
                MyContext.Set<T>().Remove(GetById(Id));
                MyContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<T> GetAll()
        {
            return MyContext.Set<T>().ToList();
        }
        public bool Update(T Entity)
        {
            try
            {
                MyContext.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
                MyContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public T GetById(int id)
        {
            return MyContext.Set<T>().Find(id);
        }
        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return MyContext.Set<T>().Where(predicate);
        }
    }
}
