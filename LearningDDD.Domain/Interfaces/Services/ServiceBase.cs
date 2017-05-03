using LearningDDD.Domain.Interfaces.Repository.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDDD.Domain.Interfaces.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class, new()
    {
        private readonly IRepositoryBase<T> _repository;
        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }
        public void Delete(T obj)
        {
            try
            {
                _repository.Delete(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IQueryable GetAll()
        {
            try
            {
                var result = _repository.GetAll();
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
                var result = _repository.GetById(id);
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
                _repository.Insert(obj);
                return obj;
            }
            catch (Exception)
            {

                throw;
            }      
        }

        public T Update(T obj)
        {
            try
            {
                _repository.Update(obj);
                return obj;
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}
