using LearningDDD.Domain.Interfaces.Repository.RepositoryBase;
using LearningDDD.Repository.Infra.EntityContext;
using System;
using System.Data.Entity;
using System.Linq;

namespace LearningDDD.Repository.Infra.Repository.RepositoryBase
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class, new()
    {
        protected Context _context = new Context();
        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);      
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IQueryable GetAll()
        {
            try
            {
                var result = _context.Set<T>().AsQueryable();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T GetById(int id)
        {
            try
            {
                var result = _context.Set<T>().Find(id);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T Insert(T obj)
        {
            try
            {
                _context.Set<T>().Add(obj);
                _context.SaveChanges();
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
        }

    }
}
